using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestSystem_3M.Data;
using TestSystem_3M.Services;

namespace TestSystem_3M
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TestSystemService service = new TestSystemService();

        private DateTime startTime;
        private DateTime endTime;

        public MainWindow()
        {
            InitializeComponent();
            RegisterWindow registerWindow = new RegisterWindow(service, this);
            registerWindow.Show();
            this.Visibility = Visibility.Hidden;
        }

        public void LoadProgram()
        {
            lblInfo.Content = $"Name: {service.User.Login} Id: {service.User.Id}";
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            txtQuestion.Text = service.CurrentQuestionContent;

            startTime = DateTime.Now;
        }

        private void ButtonAnswer_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if(service.CheckAnswer(button.Content.ToString()))
            {
                lblInfo.Content = service.Score;
                txtQuestion.Text = service.CurrentQuestionContent;
            }
            else
            {
                MessageBox.Show("END!");
                btnYes.IsEnabled = false;
                btnNo.IsEnabled = false;
            }

            service.Result.NumCurrentQuestion++;

            if (service.Result.NumCurrentQuestion == service.QuestionCount)
            {
                endTime = DateTime.Now;
                service.SaveResultToDb(startTime, endTime);
            }
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            ResultWindow resultWindow = new ResultWindow(service);
            resultWindow.Show();
        }
    }
}
