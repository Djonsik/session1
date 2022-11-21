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
    
    public partial class PageEditProduct : Page
    {
        private Product product = new Product();
        public PageEditProduct(Product item)
        {
            InitializeComponent();

            TitleTextBox.Text = item.Title;
            DescriptionTextBox.Text = item.Description;
            ImageTextBox.Text = item.Image;
            PriceTextBox.Text = item.Price.ToString();
            CountTextBox.Text = item.Count.ToString();

            product = item;
        }

        private void ButtonEditProduct_Click(object sender, RoutedEventArgs e)
        {
            product.Title = TitleTextBox.Text;
            product.Description = DescriptionTextBox.Text;
            product.Image = ImageTextBox.Text;
            product.Price = int.Parse(PriceTextBox.Text);
            product.Count = int.Parse(CountTextBox.Text);

            Core.db.SaveChanges();
            NavigationService.Navigate(new PageAdmin() );
        }
    }
}
