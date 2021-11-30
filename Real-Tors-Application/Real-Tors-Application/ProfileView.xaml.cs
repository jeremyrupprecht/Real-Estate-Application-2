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
    /// Interaction logic for ProfileView.xaml
    /// </summary>
    public partial class ProfileView : Page
    {
        public readonly Random rand = new Random();
        public List<Listing> ListOfListings = new List<Listing>();

        public ProfileView()
        {
            InitializeComponent();
            //GenerateListings();
            GenerateFaveListings();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
        }

        private void navLogOutButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
        }

        private void myAccountDropdownButton_Click(object sender, RoutedEventArgs e)
        {
            if (accountViewCollapse.Visibility == Visibility.Collapsed)
            {
                myAccountButtonImage.Source = new BitmapImage(new Uri("sortup_icon.png", UriKind.RelativeOrAbsolute));
                accountViewCollapse.Visibility = Visibility.Visible;

                Thickness margin = favListingLabel.Margin;
                margin.Top = 602;
                favListingLabel.Margin = margin;

                margin = favListingScrollView.Margin;
                margin.Top = 649;
                favListingScrollView.Margin = margin;
            } 
            else
            {
                myAccountButtonImage.Source = new BitmapImage(new Uri("sortdown_icon.png", UriKind.RelativeOrAbsolute));
                accountViewCollapse.Visibility = Visibility.Collapsed;

                Thickness margin = favListingLabel.Margin;
                margin.Top = 204;
                favListingLabel.Margin = margin;

                margin = favListingScrollView.Margin;
                margin.Top = 251;
                favListingScrollView.Margin = margin;
            }
            
        }

        // TODO:
        // Get listings from all listings in global state
        // Check if the listing is faved
        // If so populate the fave listing in profile with 9?
        // If it does not fill, grab from additional listing
        public void GenerateListings()
        {
            GlobalState.currentList[8] = -1;
            if (GlobalState.currentList[0] != -1)
            {
                Neighbourhood0.Content = GlobalState.totalList[GlobalState.currentList[0]].Neighbourhood;
                PriceNum0.Content = "$" + GlobalState.totalList[GlobalState.currentList[0]].Price;
                BedNumber0.Content = GlobalState.totalList[GlobalState.currentList[0]].BedNum;
                BathNumber0.Content = GlobalState.totalList[GlobalState.currentList[0]].BathNum;
                SizeNumber0.Content = GlobalState.totalList[GlobalState.currentList[0]].Size + " sq ft";
                HouseImage0.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[0]].NumOfImg + ".jpg", UriKind.Relative));
                Heart0.Source = (GlobalState.totalList[GlobalState.currentList[0]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
            }
            else
            {
                Listing1.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[1] != -1)
            {
                Neighbourhood1.Content = GlobalState.totalList[GlobalState.currentList[1]].Neighbourhood;
                PriceNum1.Content = "$" + GlobalState.totalList[GlobalState.currentList[1]].Price;
                BedNumber1.Content = GlobalState.totalList[GlobalState.currentList[1]].BedNum;
                BathNumber1.Content = GlobalState.totalList[GlobalState.currentList[1]].BathNum;
                SizeNumber1.Content = GlobalState.totalList[GlobalState.currentList[1]].Size + " sq ft";
                HouseImage1.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[1]].NumOfImg + ".jpg", UriKind.Relative));
                Heart1.Source = (GlobalState.totalList[GlobalState.currentList[1]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood1);
            }
            else
            {
                Listing2.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[2] != -1)
            {
                Neighbourhood2.Content = GlobalState.totalList[GlobalState.currentList[2]].Neighbourhood;
                PriceNum2.Content = "$" + GlobalState.totalList[GlobalState.currentList[2]].Price;
                BedNumber2.Content = GlobalState.totalList[GlobalState.currentList[2]].BedNum;
                BathNumber2.Content = GlobalState.totalList[GlobalState.currentList[2]].BathNum;
                SizeNumber2.Content = GlobalState.totalList[GlobalState.currentList[2]].Size + " sq ft";
                HouseImage2.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[2]].NumOfImg + ".jpg", UriKind.Relative));
                Heart2.Source = (GlobalState.totalList[GlobalState.currentList[2]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood2);
            }
            else
            {
                Listing3.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[3] != -1)
            {
                Neighbourhood3.Content = GlobalState.totalList[GlobalState.currentList[3]].Neighbourhood;
                PriceNum3.Content = "$" + GlobalState.totalList[GlobalState.currentList[3]].Price;
                BedNumber3.Content = GlobalState.totalList[GlobalState.currentList[3]].BedNum;
                BathNumber3.Content = GlobalState.totalList[GlobalState.currentList[3]].BathNum;
                SizeNumber3.Content = GlobalState.totalList[GlobalState.currentList[3]].Size + " sq ft";
                HouseImage3.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[3]].NumOfImg + ".jpg", UriKind.Relative));
                Heart3.Source = (GlobalState.totalList[GlobalState.currentList[3]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood3);
            }
            else
            {
                Listing4.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[4] != -1)
            {
                Neighbourhood4.Content = GlobalState.totalList[GlobalState.currentList[4]].Neighbourhood;
                PriceNum4.Content = "$" + GlobalState.totalList[GlobalState.currentList[4]].Price;
                BedNumber4.Content = GlobalState.totalList[GlobalState.currentList[4]].BedNum;
                BathNumber4.Content = GlobalState.totalList[GlobalState.currentList[4]].BathNum;
                SizeNumber4.Content = GlobalState.totalList[GlobalState.currentList[4]].Size + " sq ft";
                HouseImage4.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[4]].NumOfImg + ".jpg", UriKind.Relative));
                Heart4.Source = (GlobalState.totalList[GlobalState.currentList[4]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood4);
            }
            else
            {
                Listing5.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[5] != -1)
            {
                Neighbourhood5.Content = GlobalState.totalList[GlobalState.currentList[5]].Neighbourhood;
                PriceNum5.Content = "$" + GlobalState.totalList[GlobalState.currentList[5]].Price;
                BedNumber5.Content = GlobalState.totalList[GlobalState.currentList[5]].BedNum;
                BathNumber5.Content = GlobalState.totalList[GlobalState.currentList[5]].BathNum;
                SizeNumber5.Content = GlobalState.totalList[GlobalState.currentList[5]].Size + " sq ft";
                HouseImage5.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[5]].NumOfImg + ".jpg", UriKind.Relative));
                Heart5.Source = (GlobalState.totalList[GlobalState.currentList[5]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood5);
            }
            else
            {
                Listing6.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[6] != -1)
            {
                Neighbourhood6.Content = GlobalState.totalList[GlobalState.currentList[3]].Neighbourhood;
                PriceNum6.Content = "$" + GlobalState.totalList[GlobalState.currentList[6]].Price;
                BedNumber6.Content = GlobalState.totalList[GlobalState.currentList[6]].BedNum;
                BathNumber6.Content = GlobalState.totalList[GlobalState.currentList[6]].BathNum;
                SizeNumber6.Content = GlobalState.totalList[GlobalState.currentList[6]].Size + " sq ft";
                HouseImage6.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[6]].NumOfImg + ".jpg", UriKind.Relative));
                Heart6.Source = (GlobalState.totalList[GlobalState.currentList[6]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood6);
            }
            else
            {
                Listing7.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[7] != -1)
            {
                Neighbourhood7.Content = GlobalState.totalList[GlobalState.currentList[7]].Neighbourhood;
                PriceNum7.Content = "$" + GlobalState.totalList[GlobalState.currentList[7]].Price;
                BedNumber7.Content = GlobalState.totalList[GlobalState.currentList[7]].BedNum;
                BathNumber7.Content = GlobalState.totalList[GlobalState.currentList[7]].BathNum;
                SizeNumber7.Content = GlobalState.totalList[GlobalState.currentList[7]].Size + " sq ft";
                HouseImage7.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[7]].NumOfImg + ".jpg", UriKind.Relative));
                Heart7.Source = (GlobalState.totalList[GlobalState.currentList[7]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood7);
            }
            else
            {
                Listing8.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[8] != -1)
            {
                Neighbourhood8.Content = GlobalState.totalList[GlobalState.currentList[8]].Neighbourhood;
                PriceNum8.Content = "$" + GlobalState.totalList[GlobalState.currentList[8]].Price;
                BedNumber8.Content = GlobalState.totalList[GlobalState.currentList[8]].BedNum;
                BathNumber8.Content = GlobalState.totalList[GlobalState.currentList[8]].BathNum;
                SizeNumber8.Content = GlobalState.totalList[GlobalState.currentList[8]].Size + " sq ft";
                HouseImage8.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[8]].NumOfImg + ".jpg", UriKind.Relative));
                Heart8.Source = (GlobalState.totalList[GlobalState.currentList[8]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood8);
            }
            else
            {
                Listing9.Visibility = Visibility.Collapsed;
            }


        }

        public void GenerateFaveListings()
        {
            GlobalState.FindNineFaves();

            if (GlobalState.currentList[0] != -1)
            {
                Neighbourhood0.Content = GlobalState.totalList[GlobalState.currentList[0]].Neighbourhood;
                PriceNum0.Content = "$" + GlobalState.totalList[GlobalState.currentList[0]].Price;
                BedNumber0.Content = GlobalState.totalList[GlobalState.currentList[0]].BedNum;
                BathNumber0.Content = GlobalState.totalList[GlobalState.currentList[0]].BathNum;
                SizeNumber0.Content = GlobalState.totalList[GlobalState.currentList[0]].Size + " sq ft";
                HouseImage0.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[0]].NumOfImg + ".jpg", UriKind.Relative));
                Heart0.Source = (GlobalState.totalList[GlobalState.currentList[0]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
            }
            else
            {
                Listing1.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[1] != -1)
            {
                Neighbourhood1.Content = GlobalState.totalList[GlobalState.currentList[1]].Neighbourhood;
                PriceNum1.Content = "$" + GlobalState.totalList[GlobalState.currentList[1]].Price;
                BedNumber1.Content = GlobalState.totalList[GlobalState.currentList[1]].BedNum;
                BathNumber1.Content = GlobalState.totalList[GlobalState.currentList[1]].BathNum;
                SizeNumber1.Content = GlobalState.totalList[GlobalState.currentList[1]].Size + " sq ft";
                HouseImage1.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[1]].NumOfImg + ".jpg", UriKind.Relative));
                Heart1.Source = (GlobalState.totalList[GlobalState.currentList[1]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood1);
            }
            else
            {
                Listing2.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[2] != -1)
            {
                Neighbourhood2.Content = GlobalState.totalList[GlobalState.currentList[2]].Neighbourhood;
                PriceNum2.Content = "$" + GlobalState.totalList[GlobalState.currentList[2]].Price;
                BedNumber2.Content = GlobalState.totalList[GlobalState.currentList[2]].BedNum;
                BathNumber2.Content = GlobalState.totalList[GlobalState.currentList[2]].BathNum;
                SizeNumber2.Content = GlobalState.totalList[GlobalState.currentList[2]].Size + " sq ft";
                HouseImage2.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[2]].NumOfImg + ".jpg", UriKind.Relative));
                Heart2.Source = (GlobalState.totalList[GlobalState.currentList[2]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood2);
            }
            else
            {
                Listing3.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[3] != -1)
            {
                Neighbourhood3.Content = GlobalState.totalList[GlobalState.currentList[3]].Neighbourhood;
                PriceNum3.Content = "$" + GlobalState.totalList[GlobalState.currentList[3]].Price;
                BedNumber3.Content = GlobalState.totalList[GlobalState.currentList[3]].BedNum;
                BathNumber3.Content = GlobalState.totalList[GlobalState.currentList[3]].BathNum;
                SizeNumber3.Content = GlobalState.totalList[GlobalState.currentList[3]].Size + " sq ft";
                HouseImage3.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[3]].NumOfImg + ".jpg", UriKind.Relative));
                Heart3.Source = (GlobalState.totalList[GlobalState.currentList[3]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood3);
            }
            else
            {
                Listing4.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[4] != -1)
            {
                Neighbourhood4.Content = GlobalState.totalList[GlobalState.currentList[4]].Neighbourhood;
                PriceNum4.Content = "$" + GlobalState.totalList[GlobalState.currentList[4]].Price;
                BedNumber4.Content = GlobalState.totalList[GlobalState.currentList[4]].BedNum;
                BathNumber4.Content = GlobalState.totalList[GlobalState.currentList[4]].BathNum;
                SizeNumber4.Content = GlobalState.totalList[GlobalState.currentList[4]].Size + " sq ft";
                HouseImage4.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[4]].NumOfImg + ".jpg", UriKind.Relative));
                Heart4.Source = (GlobalState.totalList[GlobalState.currentList[4]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood4);
            }
            else
            {
                Listing5.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[5] != -1)
            {
                Neighbourhood5.Content = GlobalState.totalList[GlobalState.currentList[5]].Neighbourhood;
                PriceNum5.Content = "$" + GlobalState.totalList[GlobalState.currentList[5]].Price;
                BedNumber5.Content = GlobalState.totalList[GlobalState.currentList[5]].BedNum;
                BathNumber5.Content = GlobalState.totalList[GlobalState.currentList[5]].BathNum;
                SizeNumber5.Content = GlobalState.totalList[GlobalState.currentList[5]].Size + " sq ft";
                HouseImage5.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[5]].NumOfImg + ".jpg", UriKind.Relative));
                Heart5.Source = (GlobalState.totalList[GlobalState.currentList[5]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood5);
            }
            else
            {
                Listing6.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[6] != -1)
            {
                Neighbourhood6.Content = GlobalState.totalList[GlobalState.currentList[3]].Neighbourhood;
                PriceNum6.Content = "$" + GlobalState.totalList[GlobalState.currentList[6]].Price;
                BedNumber6.Content = GlobalState.totalList[GlobalState.currentList[6]].BedNum;
                BathNumber6.Content = GlobalState.totalList[GlobalState.currentList[6]].BathNum;
                SizeNumber6.Content = GlobalState.totalList[GlobalState.currentList[6]].Size + " sq ft";
                HouseImage6.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[6]].NumOfImg + ".jpg", UriKind.Relative));
                Heart6.Source = (GlobalState.totalList[GlobalState.currentList[6]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood6);
            }
            else
            {
                Listing7.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[7] != -1)
            {
                Neighbourhood7.Content = GlobalState.totalList[GlobalState.currentList[7]].Neighbourhood;
                PriceNum7.Content = "$" + GlobalState.totalList[GlobalState.currentList[7]].Price;
                BedNumber7.Content = GlobalState.totalList[GlobalState.currentList[7]].BedNum;
                BathNumber7.Content = GlobalState.totalList[GlobalState.currentList[7]].BathNum;
                SizeNumber7.Content = GlobalState.totalList[GlobalState.currentList[7]].Size + " sq ft";
                HouseImage7.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[7]].NumOfImg + ".jpg", UriKind.Relative));
                Heart7.Source = (GlobalState.totalList[GlobalState.currentList[7]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood7);
            }
            else
            {
                Listing8.Visibility = Visibility.Collapsed;
            }

            if (GlobalState.currentList[8] != -1)
            {
                Neighbourhood8.Content = GlobalState.totalList[GlobalState.currentList[8]].Neighbourhood;
                PriceNum8.Content = "$" + GlobalState.totalList[GlobalState.currentList[8]].Price;
                BedNumber8.Content = GlobalState.totalList[GlobalState.currentList[8]].BedNum;
                BathNumber8.Content = GlobalState.totalList[GlobalState.currentList[8]].BathNum;
                SizeNumber8.Content = GlobalState.totalList[GlobalState.currentList[8]].Size + " sq ft";
                HouseImage8.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[8]].NumOfImg + ".jpg", UriKind.Relative));
                Heart8.Source = (GlobalState.totalList[GlobalState.currentList[8]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                ShrinkNeighbourhoodText(Neighbourhood8);
            }
            else
            {
                Listing9.Visibility = Visibility.Collapsed;
            }
        }

        /*
        public void GenerateFaveListings()
        {
            int listing_count = 0;

            List<Listing> faves = GlobalState.FindNineFaves();

            ListTitle.Content = "Favorite Listings: " + faves.Count;
            
            for (int i = 0; i < faves.Count; i++)
            {
                if(faves != null)
                {
                    if (faves[i] != null && i == 0)
                    {
                        Neighbourhood0.Content = faves[i].Neighbourhood;
                        PriceNum0.Content = "$" + faves[i].Price;
                        BedNumber0.Content = faves[i].BedNum;
                        BathNumber0.Content = faves[i].BathNum;
                        SizeNumber0.Content = faves[i].Size + " sq ft";
                        HouseImage0.Source = new BitmapImage(new Uri(@"/houseImg" + faves[i].NumOfImg + ".jpg", UriKind.Relative));
                        Heart0.Source = (faves[i].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                        Listing1.Visibility = Visibility.Visible;
                        
                        continue;
                    }
                    else if (i == 0)
                    {
                        Listing1.Visibility = Visibility.Collapsed;
                    }

                    if (faves[i] != null && i == 1)
                    {
                        Neighbourhood1.Content = faves[i].Neighbourhood;
                        PriceNum1.Content = "$" + faves[i].Price;
                        BedNumber1.Content = faves[i].BedNum;
                        BathNumber1.Content = faves[i].BathNum;
                        SizeNumber1.Content = faves[i].Size + " sq ft";
                        HouseImage1.Source = new BitmapImage(new Uri(@"/houseImg" + faves[i].NumOfImg + ".jpg", UriKind.Relative));
                        Heart1.Source = (faves[i].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                        Listing2.Visibility = Visibility.Visible;
                        
                        continue;
                    }
                    else if (i == 1)
                    {
                        Listing2.Visibility = Visibility.Collapsed;
                    }

                    if (faves[i] != null && i == 2)
                    {
                        Neighbourhood2.Content = faves[i].Neighbourhood;
                        PriceNum2.Content = "$" + faves[i].Price;
                        BedNumber2.Content = faves[i].BedNum;
                        BathNumber2.Content = faves[i].BathNum;
                        SizeNumber2.Content = faves[i].Size + " sq ft";
                        HouseImage2.Source = new BitmapImage(new Uri(@"/houseImg" + faves[i].NumOfImg + ".jpg", UriKind.Relative));
                        Heart2.Source = (faves[i].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                        Listing3.Visibility = Visibility.Visible;
                        
                        continue;
                    }
                    else if (i == 2)
                    {
                        Listing3.Visibility = Visibility.Collapsed;
                    }

                    if (faves[i] != null && listing_count == 3)
                    {
                        Neighbourhood3.Content = faves[i].Neighbourhood;
                        PriceNum3.Content = "$" + faves[i].Price;
                        BedNumber3.Content = faves[i].BedNum;
                        BathNumber3.Content = faves[i].BathNum;
                        SizeNumber3.Content = faves[i].Size + " sq ft";
                        HouseImage3.Source = new BitmapImage(new Uri(@"/houseImg" + faves[i].NumOfImg + ".jpg", UriKind.Relative));
                        Heart3.Source = (faves[i].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                        Listing4.Visibility = Visibility.Visible;
                        
                        continue;
                    }
                    else if (i == 3)
                    {
                        Listing4.Visibility = Visibility.Collapsed;
                    }

                    if (faves[i] != null && i == 4)
                    {
                        Neighbourhood4.Content = faves[i].Neighbourhood;
                        PriceNum4.Content = "$" + faves[i].Price;
                        BedNumber4.Content = faves[i].BedNum;
                        BathNumber4.Content = faves[i].BathNum;
                        SizeNumber4.Content = faves[i].Size + " sq ft";
                        HouseImage4.Source = new BitmapImage(new Uri(@"/houseImg" + faves[i].NumOfImg + ".jpg", UriKind.Relative));
                        Heart4.Source = (faves[i].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                        Listing5.Visibility = Visibility.Visible;
                        
                        continue;
                    }
                    else if (i == 4)
                    {
                        Listing5.Visibility = Visibility.Collapsed;
                    }

                    if (faves[i] != null && i == 5)
                    {
                        Neighbourhood5.Content = faves[i].Neighbourhood;
                        PriceNum5.Content = "$" + faves[i].Price;
                        BedNumber5.Content = faves[i].BedNum;
                        BathNumber5.Content = faves[i].BathNum;
                        SizeNumber5.Content = faves[i].Size + " sq ft";
                        HouseImage5.Source = new BitmapImage(new Uri(@"/houseImg" + faves[i].NumOfImg + ".jpg", UriKind.Relative));
                        Heart5.Source = (faves[i].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                        Listing6.Visibility = Visibility.Visible;
                        
                        continue;
                    }
                    else if (i == 5)
                    {
                        Listing6.Visibility = Visibility.Collapsed;
                    }

                    if (faves[i] != null && i == 6)
                    {
                        Neighbourhood6.Content = faves[i].Neighbourhood;
                        PriceNum6.Content = "$" + faves[i].Price;
                        BedNumber6.Content = faves[i].BedNum;
                        BathNumber6.Content = faves[i].BathNum;
                        SizeNumber6.Content = faves[i].Size + " sq ft";
                        HouseImage6.Source = new BitmapImage(new Uri(@"/houseImg" + faves[i].NumOfImg + ".jpg", UriKind.Relative));
                        Heart6.Source = (faves[i].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                        Listing7.Visibility = Visibility.Visible;
                        
                        continue;
                    }
                    else if (i == 6)
                    {
                        Listing7.Visibility = Visibility.Collapsed;
                    }

                    if (faves[i] != null && i == 7)
                    {
                        Neighbourhood7.Content = faves[i].Neighbourhood;
                        PriceNum7.Content = "$" + faves[i].Price;
                        BedNumber7.Content = faves[i].BedNum;
                        BathNumber7.Content = faves[i].BathNum;
                        SizeNumber7.Content = faves[i].Size + " sq ft";
                        HouseImage7.Source = new BitmapImage(new Uri(@"/houseImg" + faves[i].NumOfImg + ".jpg", UriKind.Relative));
                        Heart7.Source = (faves[i].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                        Listing8.Visibility = Visibility.Visible;
                        
                        continue;
                    }
                    else if (i == 7)
                    {
                        Listing8.Visibility = Visibility.Collapsed;
                    }

                    if (faves[i] != null && i == 8)
                    {
                        Neighbourhood8.Content = faves[i].Neighbourhood;
                        PriceNum8.Content = "$" + faves[i].Price;
                        BedNumber8.Content = faves[i].BedNum;
                        BathNumber8.Content = faves[i].BathNum;
                        SizeNumber8.Content = faves[i].Size + " sq ft";
                        HouseImage8.Source = new BitmapImage(new Uri(@"/houseImg" + faves[i].NumOfImg + ".jpg", UriKind.Relative));
                        Heart8.Source = (faves[i].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative)));
                        Listing9.Visibility = Visibility.Visible;
                        
                        continue;
                    }
                    else if (i == 8)
                    {
                        Listing9.Visibility = Visibility.Collapsed;
                    }
                } 
                else
                {
                    Listing1.Visibility = Visibility.Collapsed;
                    Listing2.Visibility = Visibility.Collapsed;
                    Listing3.Visibility = Visibility.Collapsed;
                    Listing4.Visibility = Visibility.Collapsed;
                    Listing5.Visibility = Visibility.Collapsed;
                    Listing6.Visibility = Visibility.Collapsed;
                    Listing7.Visibility = Visibility.Collapsed;
                    Listing8.Visibility = Visibility.Collapsed;
                    Listing9.Visibility = Visibility.Collapsed;
                }
            }
        }
        */
        private void expandListing(object sender, MouseButtonEventArgs e)
        {
            var currentListing = (sender as Rectangle).Parent;
            int numOfListing = Int16.Parse(currentListing.GetType().GetProperty("Name").GetValue(currentListing).ToString().Substring(7)) - 1;
            GlobalState.currentIndex = numOfListing;
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
        }

        private void expandListingImg(object sender, MouseButtonEventArgs e)
        {
            var currentListing = (sender as Image).Parent;
            int numOfListing = Int16.Parse(currentListing.GetType().GetProperty("Name").GetValue(currentListing).ToString().Substring(7)) - 1;
            GlobalState.currentIndex = numOfListing;
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
        }

        private void ChangeFavorite(object sender, MouseButtonEventArgs e)
        {
            int numOfListing = Int16.Parse(sender.GetType().GetProperty("Name").GetValue(sender).ToString().Substring(5));
            GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited = !GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited;

            var heartImg = (sender as Image);
            heartImg.Source = GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative));

            GenerateFaveListings();
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
    }
}
