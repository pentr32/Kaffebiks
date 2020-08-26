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
using Modellen;
using DAL;

namespace Kaffebiks
{
    public partial class MainWindow : Window
    {
        CoffeeRepository _CoffeeRepo = new CoffeeRepository();
        public MainWindow()
        {
            InitializeComponent();
            _CoffeeRepo.LoadCoffees();
            cmbCoffee.ItemsSource = _CoffeeRepo.coffees;
            cmbDeleteCoffeeByName.ItemsSource = _CoffeeRepo.coffees;

            cmbCoffee.SelectedIndex = 0;
            cmbDeleteCoffeeByName.SelectedIndex = 0;

            cmbAddCountry.ItemsSource = Enum.GetValues(typeof(Country));

            ListAllCoffees.ItemsSource = _CoffeeRepo.coffees;


        }

        private void BtnFindCoffee_Click(object sender, RoutedEventArgs e)
        {
            Coffee fundetKaffe = _CoffeeRepo.GetACoffee(cmbCoffee.Text);

            txtCoffeeID.Text = fundetKaffe.CoffeeId.ToString();
            txtImageID.Text = fundetKaffe.ImageId.ToString();
            txtDesc.Text = fundetKaffe.Description;

            txtCoffeePrice.Text = fundetKaffe.Price.ToString();
            dtAddedInStock.Text = fundetKaffe.FirstAddedToStockDate.ToString();
            txtAmountInStock.Text = fundetKaffe.AmountInStock.ToString();

            txtIsInStock.Text = fundetKaffe.InStock.ToString();
            txtCoffeeCountry.Text = fundetKaffe.OriginCountry.ToString();
            imgCoffee.Source = new BitmapImage(new Uri("/Kaffebiks;component/Images/coffee" + fundetKaffe.ImageId.ToString() + ".jpg", UriKind.Relative));

            //switch (fundetKaffe.CoffeeName)
            //{
            //    case "Gill's home-made latte":
            //        imgCoffee.Source = new BitmapImage(new Uri("/Kaffebiks;component/Images/coffee1.jpg", UriKind.Relative));
            //        break;
            //    case "Espresso":
            //        imgCoffee.Source = new BitmapImage(new Uri("/Kaffebiks;component/Images/coffee2.jpg", UriKind.Relative));
            //        break;
            //    case "Capuccino coffee":
            //        imgCoffee.Source = new BitmapImage(new Uri("/Kaffebiks;component/Images/coffee3.jpg", UriKind.Relative));
            //        break;
            //    case "Americano":
            //        imgCoffee.Source = new BitmapImage(new Uri("/Kaffebiks;component/Images/coffee4.jpg", UriKind.Relative));
            //        break;
            //    case "Caffe Latte":
            //        imgCoffee.Source = new BitmapImage(new Uri("/Kaffebiks;component/Images/coffee5.jpg", UriKind.Relative));
            //        break;
            //    case "Cafe au Lait":
            //        imgCoffee.Source = new BitmapImage(new Uri("/Kaffebiks;component/Images/coffee6.jpg", UriKind.Relative));
            //        break;
            //    case "Cafe Mocha":
            //        imgCoffee.Source = new BitmapImage(new Uri("/Kaffebiks;component/Images/coffee7.jpg", UriKind.Relative));
            //        break;
            //    case "Caramel Macchiato":
            //        imgCoffee.Source = new BitmapImage(new Uri("/Kaffebiks;component/Images/coffee8.jpg", UriKind.Relative));
            //        break;
            //}
        }

        private void BtnAddCoffee_Click(object sender, RoutedEventArgs e)
        {
            _CoffeeRepo.CreateCoffee(txtAddCoffeName.Text, txtAddCoffeeDesc.Text, Convert.ToInt32(cmbImageID.Text), Convert.ToBoolean(cmbAddIsInStock.Text), Convert.ToInt32(txtAddAmount.Text), Convert.ToDateTime(dtAddDateInStock.Text), (Country)cmbAddCountry.SelectedItem, Convert.ToInt32(txtAddPrice.Text));
            cmbCoffee.Items.Refresh();
            cmbDeleteCoffeeByName.Items.Refresh();
        }

        private void BtnFindDeleteCoffee_Click(object sender, RoutedEventArgs e)
        {
            _CoffeeRepo.DeleteCoffee(cmbDeleteCoffeeByName.Text);
            cmbCoffee.Items.Refresh();
            cmbDeleteCoffeeByName.Items.Refresh();

            txtCoffeeID_Copy.Text = null;
            txtImageID_Copy.Text = null;
            txtDesc_Copy.Text = null;

            txtCoffeePrice_Copy.Text = null;
            dtAddedInStock_Copy.Text = null;
            txtAmountInStock_Copy.Text = null;

            txtIsInStock_Copy.Text = null;
            txtCoffeeCountry_Copy.Text = null;
            imgCoffee_Copy.Source = null;
        }

        private void BtnFindCoffeeToDel_Click(object sender, RoutedEventArgs e)
        {
            Coffee fundetKaffe = _CoffeeRepo.GetACoffee(cmbDeleteCoffeeByName.Text);

            txtCoffeeID_Copy.Text = fundetKaffe.CoffeeId.ToString();
            txtImageID_Copy.Text = fundetKaffe.ImageId.ToString();
            txtDesc_Copy.Text = fundetKaffe.Description;

            txtCoffeePrice_Copy.Text = fundetKaffe.Price.ToString();
            dtAddedInStock_Copy.Text = fundetKaffe.FirstAddedToStockDate.ToString();
            txtAmountInStock_Copy.Text = fundetKaffe.AmountInStock.ToString();

            txtIsInStock_Copy.Text = fundetKaffe.InStock.ToString();
            txtCoffeeCountry_Copy.Text = fundetKaffe.OriginCountry.ToString();
            imgCoffee_Copy.Source = new BitmapImage(new Uri("/Kaffebiks;component/Images/coffee" + fundetKaffe.ImageId.ToString() + ".jpg", UriKind.Relative));
        }
    }
}
