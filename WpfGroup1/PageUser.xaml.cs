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
    /// Логика взаимодействия для PageUser.xaml
    /// </summary>
    public partial class PageUser : Page
    {
        public PageUser()
        {
            InitializeComponent();
            MyDataGrid.ItemsSource = Core.db.Product.ToList();
            ComboBoxSort.SelectedIndex = 0;
        }

        private void ComboBoxSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxSort.SelectedIndex == 0)
            {
                MyDataGrid.ItemsSource = Core.db.Product.ToList();
            }
            else if (ComboBoxSort.SelectedIndex == 1)
            {
                MyDataGrid.ItemsSource = Core.db.Product.OrderByDescending(p=>p.Price).ToList();
            }
            else if (ComboBoxSort.SelectedIndex == 2)
            {
                MyDataGrid.ItemsSource = Core.db.Product.OrderBy(p => p.Price).ToList();
            }
            else if (ComboBoxSort.SelectedIndex == 3)
            {
                MyDataGrid.ItemsSource = Core.db.Product.Where(p=>p.Price>2000).ToList();
            }
        }

        private void TextBoxF_SelectionChanged(object sender, RoutedEventArgs e)
        {
            MyDataGrid.ItemsSource = Core.db.Product.Where(t=>t.Title.StartsWith(TextBoxF.Text) || t.Description.StartsWith(TextBoxF.Text)).ToList();
        }
    }
}
