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
using System.Windows.Shapes;
using TestSystem_3M.Services;

namespace TestSystem_3M
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private TestSystemService service;
        private MainWindow mainWindow;

        public RegisterWindow(TestSystemService service, MainWindow mainWindow)
        {
            InitializeComponent();

            this.service = service;
            this.mainWindow = mainWindow;
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            if (service.SignIn(txtLogin.Text, txtPassword.Text))
            {
                mainWindow.Visibility = Visibility.Visible;
                this.Close();
            }
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLoginReg.Text;
            string password = txtPasswordReg.Text;
            string repeatPassword = txtRepeatPasswordReg.Text;

            if (password != repeatPassword)
            {
                MessageBox.Show("Пароли не совпадают!");
            }
            else if (password.Length <= 5)
            {
                MessageBox.Show("Пароль должен состоять минимум из 5 символов!");
            }
            else if (login.Length <= 2)
            {
                MessageBox.Show("Логин должен состоять минимум из 3 символов!");
            }
            else
            {
                if (service.SignUp(login, password))
                {
                    MessageBox.Show("Регистрация прошла успешно! " + $"Используйте login: {login} и пароль: {password} для входа в систему");

                    txtLoginReg.Text = "";
                    txtPasswordReg.Text = "";
                    txtRepeatPasswordReg.Text = "";
                }
                else
                {
                    MessageBox.Show($"Логин: {login} уже есть в системе. Придумайте другой");
                }
            }
        }
    }
}
