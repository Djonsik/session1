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
    /// Логика взаимодействия для PageAddProduct.xaml
    /// </summary>
    public partial class PageAddProduct : Page
    {
        private Product product = new Product();
        public PageAddProduct()
        {
            InitializeComponent();
        }

        private void ButtonAddProduct_Click(object sender, RoutedEventArgs e)
        {
            product.Title = TitleTextBox.Text;
            product.Description = DescriptionTextBox.Text;
            product.Image = ImageTextBox.Text;
            product.Price = int.Parse(PriceTextBox.Text);
            product.Count = int.Parse(CountTextBox.Text);

            Core.db.Product.Add(product);
            Core.db.SaveChanges();

            NavigationService.Navigate(new PageAdmin());
        }
    }
}
