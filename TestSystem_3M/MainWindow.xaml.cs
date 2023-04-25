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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            var questions = DataAccessLayer.GetQuestions();
            service.SetQuestions(questions);

            txtQuestion.Text = service.CurrentQuestionContent;
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
            
        }
    }
}
