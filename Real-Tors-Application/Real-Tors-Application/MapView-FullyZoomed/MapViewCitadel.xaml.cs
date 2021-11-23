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

namespace Real_Tors_Application.MapView_FullyZoomed
{
    /// <summary>
    /// Interaction logic for MapViewCitadel.xaml
    /// </summary>
    public partial class MapViewCitadel : Page
    {
        public MapViewCitadel()
        {
            InitializeComponent();
            GetListings();
        }

        private void GetListings()
        {
            GlobalState.paramNeighbourhood.Clear();
            GlobalState.paramNeighbourhood.Add("Citadel");
            GlobalState.Generate();
            Tuple<double, double> offset;
            Listing curr;

            if(GlobalState.currentList[0]!=-1)
            {
                btn_Pin1.Visibility = Visibility.Visible;
                curr = GlobalState.totalList[GlobalState.currentList[0]];
                offset = curr.Coordinates;
                Neighbourhood1.Content = curr.Neighbourhood;
                PriceNum1.Content = "$"+curr.Price;
                SizeNumber1.Content = curr.Size + " sqft";
                BedNumber1.Content = curr.BedNum;
                BathNumber1.Content = curr.BathNum;
                HouseImage1.Source = new BitmapImage(new Uri(@"../houseImg" + curr.NumOfImg + ".jpg", UriKind.Relative));
                Heart1.Source = curr.Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));
            }
        }

        private void Btn_Map_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MapViewZoomed2Hovered.xaml", UriKind.Relative));
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

        private void toggleTypes(object sender, RoutedEventArgs e)
        {
            if (HomeTypesSelect.Visibility == Visibility.Collapsed)
            {
                HomeTypesSelect.Visibility = Visibility.Visible;
            }
            else
            {
                HomeTypesSelect.Visibility = Visibility.Collapsed;
            }
        }

        private void OpenAmenities_Click(object sender, RoutedEventArgs e)
        {
            if (AmenTypesSelect.Visibility == Visibility.Collapsed)
            {
                AmenTypesSelect.Visibility = Visibility.Visible;
            }
            else
            {
                AmenTypesSelect.Visibility = Visibility.Collapsed;
            }

        }

        private void toggleNeigh(object sender, RoutedEventArgs e)
        {
            if (NeighTypesSelect.Visibility == Visibility.Collapsed)
            {
                NeighTypesSelect.Visibility = Visibility.Visible;
            }
            else
            {
                NeighTypesSelect.Visibility = Visibility.Collapsed;
            }
        }

        private void ToggleFilter(object sender, RoutedEventArgs e)
        {
            if (FilterPanel.Visibility == Visibility.Collapsed)
            {
                FilterPanel.Visibility = Visibility.Visible;

            }
            else
            {
                FilterPanel.Visibility = Visibility.Collapsed;

            }

        }

        private void GiveBorder(object sender, MouseEventArgs e)
        {
            var needsBorder = (sender as Image).Parent as Border;
            needsBorder.BorderThickness = new Thickness(5);
        }

        private void TakeBorder(object sender, MouseEventArgs e)
        {
            var needsBorder = (sender as Image).Parent as Border;
            needsBorder.BorderThickness = new Thickness(0);
        }

        private void MouseOverPin1(object sender, MouseEventArgs e)
        {
            Listing1.Visibility = Visibility.Visible;
        }

        private void MouseOut1(object sender, MouseEventArgs e)
        {
            Listing1.Visibility = Visibility.Hidden;
        }


        private void expandListing(object sender, MouseButtonEventArgs e)
        {
            //var currentListing = (sender as Rectangle).Parent;
            //int numOfListing = Int16.Parse(currentListing.GetType().GetProperty("Name").GetValue(currentListing).ToString().Substring(7)) - 1;
            //GlobalState.currentIndex = numOfListing;
            //JeremyWindow3 pNext = new JeremyWindow3();
            //this.NavigationService.Navigate(pNext);
        }

        private void expandListingImg(object sender, MouseButtonEventArgs e)
        {
            //var currentListing = (sender as Image).Parent;
            //int numOfListing = Int16.Parse(currentListing.GetType().GetProperty("Name").GetValue(currentListing).ToString().Substring(7)) - 1;
            //GlobalState.currentIndex = numOfListing;
            //JeremyWindow3 pNext = new JeremyWindow3();
            //this.NavigationService.Navigate(pNext);
        }

        private void ChangeFavorite(object sender, MouseButtonEventArgs e)
        {
            int numOfListing = Int16.Parse(sender.GetType().GetProperty("Name").GetValue(sender).ToString().Substring(5));
            GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited = !GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited;

            var heartImg = (sender as Image);
            heartImg.Source = GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));
        }
    }
}
