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
    /// Логика взаимодействия для ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        private TestSystemService service;

        public ResultWindow(TestSystemService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            resultDataGrid.ItemsSource = service.GetViewModelResultUsers();
        }
    }
}
