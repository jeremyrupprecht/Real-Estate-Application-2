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

namespace Real_Tors_Application
{
    /// <summary>
    /// Interaction logic for MapViewZoomed2Hovered.xaml
    /// </summary>
    public partial class MapViewZoomed2Hovered : Page
    {
        public MapViewZoomed2Hovered()
        {
            InitializeComponent();

            ShowListings();
        }


        public void ShowListings()
        {
            Random rand = new Random();
            string[] neighbourhoodList = { "Southview" };
            Listing listingDefault = new Listing(rand, neighbourhoodList);
            Neighbourhood0.Content = listingDefault.Neighbourhood;
            PriceNum0.Content = "$" + listingDefault.Price;
            BedNumber0.Content = listingDefault.BedNum;
            BathNumber0.Content = listingDefault.BathNum;
            SizeNumber0.Content = listingDefault.Size + " sq ft";
            HouseImage0.Source = new BitmapImage(new Uri(@"/houseImg" + rand.Next(25) + ".jpg", UriKind.Relative));
        }

        private void Btn_Map_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MapViewUnZoomed.xaml", UriKind.Relative));
        }

        private void Btn_Zoomout_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MapViewUnZoomed.xaml", UriKind.Relative));
        }

        private void Btn_ListView_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ListView.xaml", UriKind.Relative));
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        private void navLogInButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("SignupView.xaml", UriKind.Relative));
        }
    }
}
