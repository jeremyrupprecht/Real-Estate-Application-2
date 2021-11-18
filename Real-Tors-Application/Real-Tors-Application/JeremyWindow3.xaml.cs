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
    /// Interaction logic for JeremyWindow3.xaml
    /// </summary>
    public partial class JeremyWindow3 : Page
    {

        public readonly Random rand = new Random();
        public int numOfListing;
        public event System.Windows.Navigation.LoadCompletedEventHandler LoadCompleted;
        public Listing list1;
        public List<Listing> ListOfListings = new List<Listing>();
        public List<Listing> OldListings = new List<Listing>();
        public List<Listing> FavoritedListings = new List<Listing>();

        public JeremyWindow3()
        {
            InitializeComponent();
            GenerateListings();
        }

        public void SetUpNavigationHandler(NavigationService ns)
        {
            ns.LoadCompleted += NavigationService_LoadCompleted;
        }

        private void NavigationService_LoadCompleted(object sender, NavigationEventArgs e)
        {
            Tuple<List<Listing>, List<Listing>, int> listAndNum = (Tuple<List<Listing>, List<Listing>, int>)e.ExtraData;
            OldListings = listAndNum.Item1;
            FavoritedListings = listAndNum.Item2;
            numOfListing = listAndNum.Item3;
            
            if (numOfListing==1)
            {
                LeftArrow.Visibility = Visibility.Collapsed;
            }
            else if(numOfListing==9)
            {
                RightArrow.Visibility = Visibility.Collapsed;
            }
            list1 = OldListings[numOfListing-1];
            ShowMainListing();
            
        }

        // button listener to go back to home page
        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        private void btn_saveForLater_Click(object sender, RoutedEventArgs e)
        {
            OldListings[numOfListing].Favorited = !ListOfListings[numOfListing].Favorited;
            list1.Favorited = !list1.Favorited;
            if (ListOfListings[numOfListing].Favorited)
            {
                FavoritedListings.Add(list1);
            }
            else
            {
                FavoritedListings.Remove(list1);
            }
            FavoritedListing.Source = list1.Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative));
        }

        private void btn_contractRealtor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_amenities_Click(object sender, RoutedEventArgs e)
        {

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
                expandedListingScrollViewer.Width = 1420;
            }
            else
            {
                FilterPanel.Visibility = Visibility.Collapsed;
                expandedListingScrollViewer.Width = 1700;

            }

        }

        private void prevLisiting(object sender, MouseButtonEventArgs e)
        {
            Tuple<List<Listing>, List<Listing>, int> listAndNum = new Tuple<List<Listing>, List<Listing>, int>(OldListings, FavoritedListings, numOfListing - 1);
            JeremyWindow3 pNext = new JeremyWindow3();
            pNext.SetUpNavigationHandler(this.NavigationService);
            this.NavigationService.Navigate(pNext, listAndNum);
        }

        private void nextListing(object sender, MouseButtonEventArgs e)
        {
            Tuple<List<Listing>, List<Listing>, int> listAndNum = new Tuple<List<Listing>, List<Listing>, int>(OldListings, FavoritedListings, numOfListing + 1);
            JeremyWindow3 pNext = new JeremyWindow3();
            pNext.SetUpNavigationHandler(this.NavigationService);
            this.NavigationService.Navigate(pNext, listAndNum);
        }

        public void ShowMainListing()
        {
            Address.Content = list1.Address;
            PriceNumber.Content = "$" + list1.Price;
            Neighbourhood.Content = list1.Neighbourhood;
            DescriptionText.Text = list1.Description;
            BedNumber.Content = list1.BedNum;
            BathNumber.Content = list1.BathNum;
            SizeNumber.Content = list1.Size + " sq ft";
            MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +list1.NumOfImg + ".jpg", UriKind.Relative));
            FavoritedListing.Source = (list1.Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));

        }

        public void GenerateListings()
        {
            for (int i = 0; i < 6; i++)
            {
                ListOfListings.Add(new Listing(rand));
            }

            Neighbourhood0.Content = ListOfListings[0].Neighbourhood;
            PriceNum0.Content = "$" + ListOfListings[0].Price;
            BedNumber0.Content = ListOfListings[0].BedNum;
            BathNumber0.Content = ListOfListings[0].BathNum;
            SizeNumber0.Content = ListOfListings[0].Size + " sq ft";
            HouseImage0.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[0].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood1.Content = ListOfListings[1].Neighbourhood;
            PriceNum1.Content = "$" + ListOfListings[1].Price;
            BedNumber1.Content = ListOfListings[1].BedNum;
            BathNumber1.Content = ListOfListings[1].BathNum;
            SizeNumber1.Content = ListOfListings[1].Size + " sq ft";
            HouseImage1.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[1].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood2.Content = ListOfListings[2].Neighbourhood;
            PriceNum2.Content = "$" + ListOfListings[2].Price;
            BedNumber2.Content = ListOfListings[2].BedNum;
            BathNumber2.Content = ListOfListings[2].BathNum;
            SizeNumber2.Content = ListOfListings[2].Size + " sq ft";
            HouseImage2.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[2].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood3.Content = ListOfListings[3].Neighbourhood;
            PriceNum3.Content = "$" + ListOfListings[3].Price;
            BedNumber3.Content = ListOfListings[3].BedNum;
            BathNumber3.Content = ListOfListings[3].BathNum;
            SizeNumber3.Content = ListOfListings[3].Size + " sq ft";
            HouseImage3.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[3].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood4.Content = ListOfListings[4].Neighbourhood;
            PriceNum4.Content = "$" + ListOfListings[4].Price;
            BedNumber4.Content = ListOfListings[4].BedNum;
            BathNumber4.Content = ListOfListings[4].BathNum;
            SizeNumber4.Content = ListOfListings[4].Size + " sq ft";
            HouseImage4.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[4].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood5.Content = ListOfListings[5].Neighbourhood;
            PriceNum5.Content = "$" + ListOfListings[5].Price;
            BedNumber5.Content = ListOfListings[5].BedNum;
            BathNumber5.Content = ListOfListings[5].BathNum;
            SizeNumber5.Content = ListOfListings[5].Size + " sq ft";
            HouseImage5.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[5].NumOfImg + ".jpg", UriKind.Relative));



        }


        private void ChangeFavorite(object sender, MouseButtonEventArgs e)
        {
            OldListings[numOfListing].Favorited = !ListOfListings[numOfListing].Favorited;
            list1.Favorited = !list1.Favorited;
            if (ListOfListings[numOfListing].Favorited)
            {
                FavoritedListings.Add(list1);
            }
            else
            {
                FavoritedListings.Remove(list1);
            }
            FavoritedListing.Source = list1.Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative));
        }
    }
}
