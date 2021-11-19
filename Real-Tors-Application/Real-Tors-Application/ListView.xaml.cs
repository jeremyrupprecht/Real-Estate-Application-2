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
    /// Interaction logic for ListView.xaml
    /// </summary>
    public partial class ListView : Page
    {
        public readonly Random rand = new Random();
        public List<Listing> ListOfListings = new List<Listing>();
        public List<Listing> FavoritedListings = new List<Listing>();



        public ListView()
        {
            InitializeComponent();
            GenerateListings();
        }

        private void btn_MapView_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MapViewUnZoomed.xaml", UriKind.Relative));
        }

        public void GenerateListings()
        {
            for (int i = 0; i < 9; i++)
            {
                ListOfListings.Add(new Listing(rand));
            }

           
            Neighbourhood0.Content = ListOfListings[0].Neighbourhood;
            PriceNum0.Content = "$" + ListOfListings[0].Price;
            BedNumber0.Content = ListOfListings[0].BedNum;
            BathNumber0.Content = ListOfListings[0].BathNum;
            SizeNumber0.Content = ListOfListings[0].Size + " sq ft";
            HouseImage0.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[0].NumOfImg + ".jpg", UriKind.Relative));
            Heart0.Source = (ListOfListings[0].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));

            Neighbourhood1.Content = ListOfListings[1].Neighbourhood;
            PriceNum1.Content = "$" + ListOfListings[1].Price;
            BedNumber1.Content = ListOfListings[1].BedNum;
            BathNumber1.Content = ListOfListings[1].BathNum;
            SizeNumber1.Content = ListOfListings[1].Size + " sq ft";
            HouseImage1.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[1].NumOfImg + ".jpg", UriKind.Relative));
            Heart1.Source = (ListOfListings[0].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));


            Neighbourhood2.Content = ListOfListings[2].Neighbourhood;
            PriceNum2.Content = "$" + ListOfListings[2].Price;
            BedNumber2.Content = ListOfListings[2].BedNum;
            BathNumber2.Content = ListOfListings[2].BathNum;
            SizeNumber2.Content = ListOfListings[2].Size + " sq ft";
            HouseImage2.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[2].NumOfImg + ".jpg", UriKind.Relative));
            Heart2.Source = (ListOfListings[0].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));


            Neighbourhood3.Content = ListOfListings[3].Neighbourhood;
            PriceNum3.Content = "$" + ListOfListings[3].Price;
            BedNumber3.Content = ListOfListings[3].BedNum;
            BathNumber3.Content = ListOfListings[3].BathNum;
            SizeNumber3.Content = ListOfListings[3].Size + " sq ft";
            HouseImage3.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[3].NumOfImg + ".jpg", UriKind.Relative));
            Heart3.Source = (ListOfListings[0].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));


            Neighbourhood4.Content = ListOfListings[4].Neighbourhood;
            PriceNum4.Content = "$" + ListOfListings[4].Price;
            BedNumber4.Content = ListOfListings[4].BedNum;
            BathNumber4.Content = ListOfListings[4].BathNum;
            SizeNumber4.Content = ListOfListings[4].Size + " sq ft";
            HouseImage4.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[4].NumOfImg + ".jpg", UriKind.Relative));
            Heart4.Source = (ListOfListings[0].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));


            Neighbourhood5.Content = ListOfListings[5].Neighbourhood;
            PriceNum5.Content = "$" + ListOfListings[5].Price;
            BedNumber5.Content = ListOfListings[5].BedNum;
            BathNumber5.Content = ListOfListings[5].BathNum;
            SizeNumber5.Content = ListOfListings[5].Size + " sq ft";
            HouseImage5.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[5].NumOfImg + ".jpg", UriKind.Relative));
            Heart5.Source = (ListOfListings[0].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));


            Neighbourhood6.Content = ListOfListings[6].Neighbourhood;
            PriceNum6.Content = "$" + ListOfListings[6].Price;
            BedNumber6.Content = ListOfListings[6].BedNum;
            BathNumber6.Content = ListOfListings[6].BathNum;
            SizeNumber6.Content = ListOfListings[6].Size + " sq ft";
            HouseImage6.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[6].NumOfImg + ".jpg", UriKind.Relative));
            Heart6.Source = (ListOfListings[0].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));


            Neighbourhood7.Content = ListOfListings[7].Neighbourhood;
            PriceNum7.Content = "$" + ListOfListings[7].Price;
            BedNumber7.Content = ListOfListings[7].BedNum;
            BathNumber7.Content = ListOfListings[7].BathNum;
            SizeNumber7.Content = ListOfListings[7].Size + " sq ft";
            HouseImage7.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[7].NumOfImg + ".jpg", UriKind.Relative));
            Heart7.Source = (ListOfListings[0].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));


            Neighbourhood8.Content = ListOfListings[8].Neighbourhood;
            PriceNum8.Content = "$" + ListOfListings[8].Price;
            BedNumber8.Content = ListOfListings[8].BedNum;
            BathNumber8.Content = ListOfListings[8].BathNum;
            SizeNumber8.Content = ListOfListings[8].Size + " sq ft";
            HouseImage8.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[8].NumOfImg + ".jpg", UriKind.Relative));
            Heart8.Source = (ListOfListings[0].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));

            ShrinkNeighbourhoodText(Neighbourhood0);
            ShrinkNeighbourhoodText(Neighbourhood1);
            ShrinkNeighbourhoodText(Neighbourhood2);
            ShrinkNeighbourhoodText(Neighbourhood3);
            ShrinkNeighbourhoodText(Neighbourhood4);
            ShrinkNeighbourhoodText(Neighbourhood5);
            ShrinkNeighbourhoodText(Neighbourhood6);
            ShrinkNeighbourhoodText(Neighbourhood7);
            ShrinkNeighbourhoodText(Neighbourhood8);

        }

        public void ShrinkNeighbourhoodText(Label nText)
        {
            int smallerFontSize = 20;
            int neighbourhoodLengthLimit = 15;
            if (nText.Content.ToString().Length > neighbourhoodLengthLimit)
            {
                nText.FontSize = smallerFontSize;
            }
        }

        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void teamButton_Click(object sender, RoutedEventArgs e)
        {

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
                listResultsGrid.Width = 1420;

            }
            else
            {
                FilterPanel.Visibility = Visibility.Collapsed;
                listResultsGrid.Width = 1850;

            }

        }

        private void expandListing(object sender, MouseButtonEventArgs e)
        {
            var currentListing = (sender as Rectangle).Parent;
            Console.WriteLine(currentListing.GetType().GetProperty("Name").GetValue(currentListing).ToString());
            int numOfListing = Int16.Parse(currentListing.GetType().GetProperty("Name").GetValue(currentListing).ToString().Substring(7));
            Tuple<List<Listing>, List<Listing>, Listing, int> listAndNum = new Tuple<List<Listing>, List<Listing>, Listing, int>(ListOfListings, FavoritedListings, null, numOfListing);
            JeremyWindow3 pNext = new JeremyWindow3();
            pNext.SetUpNavigationHandler(this.NavigationService);
            this.NavigationService.Navigate(pNext, listAndNum);
        }

        private void expandListingImg(object sender, MouseButtonEventArgs e)
        {
            var currentListing = (sender as Image).Parent;
            Console.WriteLine(currentListing.GetType().GetProperty("Name").GetValue(currentListing).ToString());
            int numOfListing = Int16.Parse(currentListing.GetType().GetProperty("Name").GetValue(currentListing).ToString().Substring(7));
            Tuple<List<Listing>, List<Listing>, Listing, int> listAndNum = new Tuple<List<Listing>, List<Listing>, Listing, int>(ListOfListings, FavoritedListings, null, numOfListing);
            JeremyWindow3 pNext = new JeremyWindow3();
            pNext.SetUpNavigationHandler(this.NavigationService);
            this.NavigationService.Navigate(pNext, listAndNum);
        }

        private void ChangeFavorite(object sender, MouseButtonEventArgs e)
        {
            int numOfListing = Int16.Parse(sender.GetType().GetProperty("Name").GetValue(sender).ToString().Substring(5));
            ListOfListings[numOfListing].Favorited = !ListOfListings[numOfListing].Favorited;
            if(ListOfListings[numOfListing].Favorited)
            {
                FavoritedListings.Add(ListOfListings[numOfListing]);
            }
            else
            {
                FavoritedListings.Remove(ListOfListings[numOfListing]);
            }
            
            var heartImg = (sender as Image);
            heartImg.Source = ListOfListings[numOfListing].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative));
        }

    }
}

