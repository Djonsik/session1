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

namespace WpfGroup1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxLogin.Text == "Admin" && TextBoxPassword.Text == "Admin")
            {
                MyFrame.Navigate(new PageAdmin());
            }
            else if (TextBoxLogin.Text == "User" && TextBoxPassword.Text == "User")
            {
                MyFrame.Navigate(new PageUser());
            }
            else MessageBox.Show($"Пользователя с логином - {TextBoxLogin.Text} не существует! Попробуйте снова!");
        }
    }
}
