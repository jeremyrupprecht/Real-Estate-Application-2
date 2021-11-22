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
        public Listing list1;
        public List<Listing> ListOfListings = new List<Listing>();


        public JeremyWindow3()
        {
            InitializeComponent();
            if (GlobalState.similar != null)
            {
                Console.WriteLine("Similar Listing " + GlobalState.similar.Address);
                LeftArrow.Visibility = Visibility.Collapsed;
                RightArrow.Visibility = Visibility.Collapsed;
                BackIfSimilar.Visibility = Visibility.Visible;
                //BackIfSimilar.Content = "Back to " + GlobalState.totalList[GlobalState.currentList[GlobalState.currentIndex]].Address;
                list1 = GlobalState.similar;
            }
            else
            {
                if (GlobalState.currentIndex == 0)
                {
                    LeftArrow.Visibility = Visibility.Collapsed;
                }
                else if (GlobalState.currentIndex == 8 || GlobalState.currentList[GlobalState.currentIndex+1]==-1)
                {
                    RightArrow.Visibility = Visibility.Collapsed;
                }
                list1 = GlobalState.totalList[GlobalState.currentList[GlobalState.currentIndex]];
            }
            ShowMainListing();
            GenerateListings();
        }

        // button listener to go back to home page
        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        private void btn_saveForLater_Click(object sender, RoutedEventArgs e)
        {
            ChangeFavoriteActivate();
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
            GlobalState.currentIndex--;
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
        }

        private void nextListing(object sender, MouseButtonEventArgs e)
        {
            GlobalState.currentIndex++;
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
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
            for (int i = 0; i < 12; i++)
            {
                ListOfListings.Add(new Listing(rand));
            }

            Neighbourhood1.Content = ListOfListings[0].Neighbourhood;
            PriceNum1.Content = "$" + ListOfListings[0].Price;
            BedNumber1.Content = ListOfListings[0].BedNum;
            BathNumber1.Content = ListOfListings[0].BathNum;
            SizeNumber1.Content = ListOfListings[0].Size + " sq ft";
            HouseImage1.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[0].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood2.Content = ListOfListings[1].Neighbourhood;
            PriceNum2.Content = "$" + ListOfListings[1].Price;
            BedNumber2.Content = ListOfListings[1].BedNum;
            BathNumber2.Content = ListOfListings[1].BathNum;
            SizeNumber2.Content = ListOfListings[1].Size + " sq ft";
            HouseImage2.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[1].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood3.Content = ListOfListings[2].Neighbourhood;
            PriceNum3.Content = "$" + ListOfListings[2].Price;
            BedNumber3.Content = ListOfListings[2].BedNum;
            BathNumber3.Content = ListOfListings[2].BathNum;
            SizeNumber3.Content = ListOfListings[2].Size + " sq ft";
            HouseImage3.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[2].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood4.Content = ListOfListings[3].Neighbourhood;
            PriceNum4.Content = "$" + ListOfListings[3].Price;
            BedNumber4.Content = ListOfListings[3].BedNum;
            BathNumber4.Content = ListOfListings[3].BathNum;
            SizeNumber4.Content = ListOfListings[3].Size + " sq ft";
            HouseImage4.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[3].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood5.Content = ListOfListings[4].Neighbourhood;
            PriceNum5.Content = "$" + ListOfListings[4].Price;
            BedNumber5.Content = ListOfListings[4].BedNum;
            BathNumber5.Content = ListOfListings[4].BathNum;
            SizeNumber5.Content = ListOfListings[4].Size + " sq ft";
            HouseImage5.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[4].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood6.Content = ListOfListings[5].Neighbourhood;
            PriceNum6.Content = "$" + ListOfListings[5].Price;
            BedNumber6.Content = ListOfListings[5].BedNum;
            BathNumber6.Content = ListOfListings[5].BathNum;
            SizeNumber6.Content = ListOfListings[5].Size + " sq ft";
            HouseImage6.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[5].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood7.Content = ListOfListings[6].Neighbourhood;
            PriceNum7.Content = "$" + ListOfListings[6].Price;
            BedNumber7.Content = ListOfListings[6].BedNum;
            BathNumber7.Content = ListOfListings[6].BathNum;
            SizeNumber7.Content = ListOfListings[6].Size + " sq ft";
            HouseImage7.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[6].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood8.Content = ListOfListings[7].Neighbourhood;
            PriceNum8.Content = "$" + ListOfListings[7].Price;
            BedNumber8.Content = ListOfListings[7].BedNum;
            BathNumber8.Content = ListOfListings[7].BathNum;
            SizeNumber8.Content = ListOfListings[7].Size + " sq ft";
            HouseImage8.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[7].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood9.Content = ListOfListings[8].Neighbourhood;
            PriceNum9.Content = "$" + ListOfListings[8].Price;
            BedNumber9.Content = ListOfListings[8].BedNum;
            BathNumber9.Content = ListOfListings[8].BathNum;
            SizeNumber9.Content = ListOfListings[8].Size + " sq ft";
            HouseImage9.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[8].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood10.Content = ListOfListings[9].Neighbourhood;
            PriceNum10.Content = "$" + ListOfListings[9].Price;
            BedNumber10.Content = ListOfListings[9].BedNum;
            BathNumber10.Content = ListOfListings[9].BathNum;
            SizeNumber10.Content = ListOfListings[9].Size + " sq ft";
            HouseImage10.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[9].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood11.Content = ListOfListings[10].Neighbourhood;
            PriceNum11.Content = "$" + ListOfListings[10].Price;
            BedNumber11.Content = ListOfListings[10].BedNum;
            BathNumber11.Content = ListOfListings[10].BathNum;
            SizeNumber11.Content = ListOfListings[10].Size + " sq ft";
            HouseImage11.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[10].NumOfImg + ".jpg", UriKind.Relative));

            Neighbourhood12.Content = ListOfListings[11].Neighbourhood;
            PriceNum12.Content = "$" + ListOfListings[11].Price;
            BedNumber12.Content = ListOfListings[11].BedNum;
            BathNumber12.Content = ListOfListings[11].BathNum;
            SizeNumber12.Content = ListOfListings[11].Size + " sq ft";
            HouseImage12.Source = new BitmapImage(new Uri(@"/houseImg" + ListOfListings[11].NumOfImg + ".jpg", UriKind.Relative));

            ShrinkNeighbourhoodText(Neighbourhood1);
            ShrinkNeighbourhoodText(Neighbourhood2);
            ShrinkNeighbourhoodText(Neighbourhood3);
            ShrinkNeighbourhoodText(Neighbourhood4);
            ShrinkNeighbourhoodText(Neighbourhood5);
            ShrinkNeighbourhoodText(Neighbourhood6);
            ShrinkNeighbourhoodText(Neighbourhood7);
            ShrinkNeighbourhoodText(Neighbourhood8);
            ShrinkNeighbourhoodText(Neighbourhood9);
            ShrinkNeighbourhoodText(Neighbourhood10);
            ShrinkNeighbourhoodText(Neighbourhood11);
            ShrinkNeighbourhoodText(Neighbourhood12);

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

        private void ChangeFavoriteActivate()
        {
            if (GlobalState.similar != null)
            {
                list1.Favorited = !list1.Favorited;
                if (list1.Favorited)
                {
                    GlobalState.additionalFavorites.Add(list1);
                }
                else
                {
                    GlobalState.additionalFavorites.Remove(list1);
                }
                FavoritedListing.Source = list1.Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative));
            }
            else
            {
                int numOfListing = GlobalState.currentIndex;
                GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited = !GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited;

                var heartImg = FavoritedListing;
                heartImg.Source = GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative));
            }
        }

        private void ChangeFavorite(object sender, MouseButtonEventArgs e)
        {
            ChangeFavoriteActivate();
        }

        private void expandListing(object sender, MouseButtonEventArgs e)
        {
            int numOfListing = Int16.Parse(sender.GetType().GetProperty("Name").GetValue(sender).ToString().Substring(7))-1;
            GlobalState.similar = ListOfListings[numOfListing];
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
        }

        private void BackToSelection(object sender, RoutedEventArgs e)
        {
            GlobalState.similar = null;
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
        }
    }
}
