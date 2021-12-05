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
            GlobalState.lastPage = "List";          //Set last page for easy jumping in between
            GlobalState.Generate();
            GenerateListings();
            FillList();

            SetMapValues();

            profileButtonVisibility();
        }

        private void SetMapValues()
        {
            GlobalState.setPerNeighbourhood("Citadel");
            GlobalState.setPerNeighbourhood("Edgemont");
            GlobalState.setPerNeighbourhood("Hamptons");
            GlobalState.setPerNeighbourhood("Hawkwood");
            GlobalState.setPerNeighbourhood("Simons Valley");

            GlobalState.setPerNeighbourhood("Arbour Lake");
            GlobalState.setPerNeighbourhood("Dalhousie");
            GlobalState.setPerNeighbourhood("Nolan Hill");
            GlobalState.setPerNeighbourhood("Ranchlands");
            GlobalState.setPerNeighbourhood("Rockey Ridge");
            GlobalState.setPerNeighbourhood("Royal Oak");
            GlobalState.setPerNeighbourhood("Royal Vista");
            GlobalState.setPerNeighbourhood("Sage Hill");
            GlobalState.setPerNeighbourhood("Scenic Acres");
            GlobalState.setPerNeighbourhood("Silver Springs");
            GlobalState.setPerNeighbourhood("Tuscany");

            NorthWest.Content = GlobalState.perNeighbourhood["Citadel"] + GlobalState.perNeighbourhood["Edgemont"] + GlobalState.perNeighbourhood["Hamptons"] + GlobalState.perNeighbourhood["Hawkwood"] +
                GlobalState.perNeighbourhood["Simons Valley"] + GlobalState.perNeighbourhood["Arbour Lake"] + GlobalState.perNeighbourhood["Dalhousie"] + GlobalState.perNeighbourhood["Nolan Hill"] +
                GlobalState.perNeighbourhood["Ranchlands"] + GlobalState.perNeighbourhood["Rockey Ridge"] + GlobalState.perNeighbourhood["Royal Oak"] + GlobalState.perNeighbourhood["Royal Vista"] +
                GlobalState.perNeighbourhood["Sage Hill"] + GlobalState.perNeighbourhood["Scenic Acres"] + GlobalState.perNeighbourhood["Silver Springs"] + GlobalState.perNeighbourhood["Tuscany"];


            SetLabelColor(NorthWest);
            SetLabelColor(North);
            SetLabelColor(NorthEast);
            SetLabelColor(West);
            SetLabelColor(Center);
            SetLabelColor(East);
            SetLabelColor(South);
            SetLabelColor(SouthEast);
        }

        private void SetLabelColor(Label label)
        {
            if (Convert.ToInt32(label.Content) <= 600)
            {
                label.Foreground = Brushes.DeepSkyBlue;
            }
            else if (Convert.ToInt32(label.Content) <= 700)
            {
                label.Foreground = Brushes.DodgerBlue;
            }
            else if (Convert.ToInt32(label.Content) <= 800)
            {
                label.Foreground = Brushes.Blue;
            }
            else
            {
                label.Foreground = Brushes.Navy;
            }
        }

        private void btn_MapView_Click(object sender, RoutedEventArgs e)
        {
            if(GlobalState.paramNeighbourhood.Count==1)
            {
                if(GlobalState.paramNeighbourhood.Contains("Hamptons"))
                {
                    this.NavigationService.Navigate(new Uri("MapView-FullyZoomed/MapViewHamptons.xaml", UriKind.Relative));
                }
                else if (GlobalState.paramNeighbourhood.Contains("Edgemont"))
                {
                    this.NavigationService.Navigate(new Uri("MapView-FullyZoomed/MapViewEdgemont.xaml", UriKind.Relative));
                }
                else if (GlobalState.paramNeighbourhood.Contains("Hawkwood"))
                {
                    this.NavigationService.Navigate(new Uri("MapView-FullyZoomed/MapViewHawkwood.xaml", UriKind.Relative));
                }
                else if (GlobalState.paramNeighbourhood.Contains("Citadel"))
                {
                    this.NavigationService.Navigate(new Uri("MapView-FullyZoomed/MapViewCitadel.xaml", UriKind.Relative));
                }
                else if (GlobalState.paramNeighbourhood.Contains("Simons Valley"))
                {
                    this.NavigationService.Navigate(new Uri("MapView-FullyZoomed/MapViewSimonsValley.xaml", UriKind.Relative));
                }
            }
            return;

            if (GlobalState.paramNeighbourhood.Contains("Hamptons") &&
                    GlobalState.paramNeighbourhood.Contains("Edgemont") &&
                    GlobalState.paramNeighbourhood.Contains("Citadel") &&
                    GlobalState.paramNeighbourhood.Contains("Hawkwood") &&
                    GlobalState.paramNeighbourhood.Contains("Simons Valley"))
            {
                this.NavigationService.Navigate(new Uri("MapViewNorthWest.xaml", UriKind.Relative));
            }
            else
            {
                this.NavigationService.Navigate(new Uri("MapViewUnZoomed.xaml", UriKind.Relative));
            }
            
        }

        public void GenerateListings()
        {
            Listing1.Visibility = Visibility.Visible;
            Listing2.Visibility = Visibility.Visible;
            Listing3.Visibility = Visibility.Visible;
            Listing4.Visibility = Visibility.Visible;
            Listing5.Visibility = Visibility.Visible;
            Listing6.Visibility = Visibility.Visible;
            Listing7.Visibility = Visibility.Visible;
            Listing8.Visibility = Visibility.Visible;
            Listing9.Visibility = Visibility.Visible;
            ZerosLabel.Visibility = Visibility.Collapsed;

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
                ZerosLabel.Visibility = Visibility.Visible;
                Listing1.Visibility = Visibility.Collapsed;
            }

            if(GlobalState.currentList[1]!=-1)
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

            if (GlobalState.currentList[2]!=-1)
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

        public void ShrinkNeighbourhoodText(Label nText)
        {
            int smallerFontSize = 20;
            int neighbourhoodLengthLimit = 15;
            if (nText.Content.ToString().Length > neighbourhoodLengthLimit)
            {
                nText.FontSize = smallerFontSize;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Filters and Header Stuff

        public bool isOnAccount;
        private void profileButtonVisibility()
        {
            if (GlobalState.isLoggedIn)
            {
                profileButton.Visibility = Visibility.Visible;
            }
            else
            {
                profileButton.Visibility = Visibility.Collapsed;
            }
        }

        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AboutView.xaml", UriKind.Relative));
        }

        private void teamButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("OurTeamView.xaml", UriKind.Relative));
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
        }

        private void navLogInButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("SignupView.xaml", UriKind.Relative));
        }

        private void contactButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ContactUsView.xaml", UriKind.Relative));
        }

        private void profileButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ProfileView.xaml", UriKind.Relative));
        }




        private void toggleTypes(object sender, RoutedEventArgs e)
        {
            if (!GlobalState.isTypeExpanded)
            {
                dropdown_btn_image.Source = new BitmapImage(new Uri("sortup_icon.png", UriKind.RelativeOrAbsolute));
                HomeTypesSelect.Visibility = Visibility.Visible;
                
            }
            else
            {
                dropdown_btn_image.Source = new BitmapImage(new Uri("sortdown_icon.png", UriKind.RelativeOrAbsolute));
                HomeTypesSelect.Visibility = Visibility.Collapsed;
            }
            GlobalState.isTypeExpanded = !GlobalState.isTypeExpanded;
        }

       
        private void ToggleFilter(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine("Toggle Pressed");
            //timer.Start();
            if (FilterPanel.Visibility == Visibility.Collapsed)
            {
                
                FilterPanel.Visibility = Visibility.Visible;
                listResultsGrid.Width = 1420;
                GlobalState.isOpen = true;

            }
            else
            {
                
                FilterPanel.Visibility = Visibility.Collapsed;
                listResultsGrid.Width = 1850;
                GlobalState.isOpen = false;
            }
        }

        private void FillList()
        {
            if(GlobalState.isOpen)
            {
                FilterPanel.Visibility = Visibility.Visible;
                listResultsGrid.Width = 1420;
            }
            else
            {
                FilterPanel.Visibility = Visibility.Collapsed;
                listResultsGrid.Width = 1850;
            }

            if(GlobalState.isLoggedIn)
            {
                profileButton.Visibility = Visibility.Visible;
            }

            if(!GlobalState.isTypeExpanded)
            {
                dropdown_btn_image.Source = new BitmapImage(new Uri("sortdown_icon.png", UriKind.RelativeOrAbsolute));
                HomeTypesSelect.Visibility = Visibility.Collapsed;
            }
            else
            {
                dropdown_btn_image.Source = new BitmapImage(new Uri("sortup_icon.png", UriKind.RelativeOrAbsolute));
                HomeTypesSelect.Visibility = Visibility.Visible;
            }

            switch(GlobalState.paramType)
            {
                case ListingType.SingleFamily:
                    SingleButt.IsChecked = true;
                    break;
                case ListingType.Duplex:
                    DuplexButt.IsChecked = true;
                    break;
                case ListingType.Triplex:
                    TriplexButt.IsChecked = true;
                    break;
                case ListingType.Apartment:
                    ApartButt.IsChecked = true;
                    break;
                case ListingType.Townhome:
                    TownhomeButt.IsChecked = true;
                    break;
                case ListingType.Loft:
                    LoftButt.IsChecked = true;
                    break;
            }
            

            if (GlobalState.paramPrice != null)
            {
                if (GlobalState.paramPrice.Item1 != 0)
                {
                    lowPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    lowPrice.Text = GlobalState.paramPrice.Item1.ToString();
                }
                if (GlobalState.paramPrice.Item2 != 25000000)
                {
                    highPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    highPrice.Text = GlobalState.paramPrice.Item2.ToString();
                }
            }

            if (GlobalState.paramSize != null)
            {
                if (GlobalState.paramSize.Item1 != 0)
                {
                    lowSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    lowSize.Text = GlobalState.paramSize.Item1.ToString();
                }
                if (GlobalState.paramPrice.Item2 != 20000)
                {
                    highSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    highSize.Text = GlobalState.paramSize.Item2.ToString();
                }
            }

            if (GlobalState.paramBed != null)
            {
                if (GlobalState.paramBed.Item1 != 0)
                {
                    lowBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    lowBed.Text = GlobalState.paramBed.Item1.ToString();
                }
                if (GlobalState.paramBed.Item2 != 6)
                {
                    highBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    highBed.Text = GlobalState.paramBed.Item2.ToString();
                }
            }

            if (GlobalState.paramBath != null)
            {
                if (GlobalState.paramBath.Item1 != 0)
                {
                    lowBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    lowBath.Text = GlobalState.paramBath.Item1.ToString();
                }
                if (GlobalState.paramBath.Item2 != 6)
                {
                    highBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    highBath.Text = GlobalState.paramBath.Item2.ToString();
                }
            }

            if (GlobalState.paramYear != null)
            {
                if (GlobalState.paramYear.Item1 != 0)
                {
                    lowYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    lowYear.Text = GlobalState.paramYear.Item1.ToString();
                }
                if (GlobalState.paramPrice.Item2 != 2021)
                {
                    highYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    highYear.Text = GlobalState.paramYear.Item2.ToString();
                }
            }

            Print_Amenity();
            Print_Neighbourhood();
        }

        
        private void Add_Amenity_Click(object sender, RoutedEventArgs e)
        {
            AddAmenity();
        }

        private void EnterAmenity(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {
                AddAmenity();
            }
        }

        private void AddAmenity()
        {
            if (AmenitiesInput.Text!= null && !GlobalState.paramAmenities.Contains(AmenitiesInput.Text) && GlobalState.paramAmenities.Count()<5 && AmenitiesInput.Text.Count() > 0)
            {
                GlobalState.paramAmenities.Add(AmenitiesInput.Text);
                AmenitiesInput.Text = "";
                Print_Amenity();
                GlobalState.Generate(9);
                GenerateListings();
                SetMapValues();
            }
        }

        private void DeleteAmenity(object sender, MouseButtonEventArgs e)
        {
            var lbl = sender as Label;
            
            GlobalState.paramAmenities.Remove(lbl.Content.ToString().Substring(2));
            Print_Amenity();
            GlobalState.Generate(9);
            GenerateListings();
            SetMapValues();
        }

        private void Print_Amenity()
        {
            Amenity1.Visibility = Visibility.Collapsed;
            Amenity2.Visibility = Visibility.Collapsed;
            Amenity3.Visibility = Visibility.Collapsed;
            Amenity4.Visibility = Visibility.Collapsed;
            Amenity5.Visibility = Visibility.Collapsed;
            int count = GlobalState.paramAmenities.Count;
            AddAmenities.IsEnabled = true;
            if(count>=1)
            {
                Amenity1.Content = "x " + GlobalState.paramAmenities[0];
                Amenity1.Visibility = Visibility.Visible;

                if (count>=2)
                {
                    Amenity2.Content = "x " + GlobalState.paramAmenities[1];
                    Amenity2.Visibility = Visibility.Visible;

                    if (count >= 3)
                    {
                        Amenity3.Content = "x " + GlobalState.paramAmenities[2];
                        Amenity3.Visibility = Visibility.Visible;

                        if (count >= 4)
                        {
                            Amenity4.Content = "x " + GlobalState.paramAmenities[3];
                            Amenity4.Visibility = Visibility.Visible;

                            if (count >= 5)
                            {
                                Amenity5.Content = "x " + GlobalState.paramAmenities[4];
                                Amenity5.Visibility = Visibility.Visible;
                                AddAmenities.IsEnabled = false;

                            }
                        }
                    }
                }
            }
        }



        private void Add_Neighbourhood_Click(object sender, RoutedEventArgs e)
        {
            AddNeighbour();
        }

        private void EnterNeighbour(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {
                AddNeighbour();
            }
        }

        private void AddNeighbour()
        {
            if (NeighbourhoodInput.Text != null && !GlobalState.paramNeighbourhood.Contains(NeighbourhoodInput.Text) && GlobalState.paramNeighbourhood.Count() < 6 && NeighbourhoodInput.Text.Count()>0)
            {
                GlobalState.paramNeighbourhood.Add(NeighbourhoodInput.Text);
                NeighbourhoodInput.Text = "";
                Print_Neighbourhood();
                GlobalState.Generate(9);
                GenerateListings();
                SetMapValues();
            }
        }

        private void DeleteNeighbour(object sender, MouseButtonEventArgs e)
        {
            var lbl = sender as Label;
            GlobalState.paramNeighbourhood.Remove(lbl.Content.ToString().Substring(2));
            Print_Neighbourhood();
            GlobalState.Generate(9);
            GenerateListings();
            SetMapValues();
        }

        private void Print_Neighbourhood()
        {
            Neighbour1.Visibility = Visibility.Collapsed;
            Neighbour2.Visibility = Visibility.Collapsed;
            Neighbour3.Visibility = Visibility.Collapsed;
            Neighbour4.Visibility = Visibility.Collapsed;
            Neighbour5.Visibility = Visibility.Collapsed;
            int count = GlobalState.paramNeighbourhood.Count;
            AddNeighbourhood.IsEnabled = true;
            if (count >= 1)
            {
                Neighbour1.Content = "x " + GlobalState.paramNeighbourhood[0];
                Neighbour1.Visibility = Visibility.Visible;

                if (count >= 2)
                {
                    Neighbour2.Content = "x " + GlobalState.paramNeighbourhood[1];
                    Neighbour2.Visibility = Visibility.Visible;

                    if (count >= 3)
                    {
                        Neighbour3.Content = "x " + GlobalState.paramNeighbourhood[2];
                        Neighbour3.Visibility = Visibility.Visible;

                        if (count >= 4)
                        {
                            Neighbour4.Content = "x " + GlobalState.paramNeighbourhood[3];
                            Neighbour4.Visibility = Visibility.Visible;

                            if (count >= 5)
                            {
                                Neighbour5.Content = "x " + GlobalState.paramNeighbourhood[4];
                                Neighbour5.Visibility = Visibility.Visible;

                                if(count>=6)
                                {
                                    Neighbour6.Content = "x " + GlobalState.paramNeighbourhood[5];
                                    Neighbour6.Visibility = Visibility.Visible;
                                    AddNeighbourhood.IsEnabled = false;
                                }
                            
                            }
                        }
                    }
                }
            }
        }


        private void enterPriceLow(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                lowPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }
            if (e.Key == Key.Return)
            {

                if (int.TryParse(lowPrice.Text, out _))
                {
                    int high = 25000000;
                    if (GlobalState.paramPrice != null)
                    {
                        high = GlobalState.paramPrice.Item2;
                    }
                    GlobalState.paramPrice = new Tuple<int, int>(int.Parse(lowPrice.Text), high);
                    lowPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    GenerateListings();
                    SetMapValues();
                }
            }
            else
            {
                lowPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void enterPriceHigh(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                highPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }

            if (e.Key == Key.Return)
            {

                if (int.TryParse(highPrice.Text, out _))
                {
                    int low = 0;
                    if (GlobalState.paramPrice != null)
                    {
                        low = GlobalState.paramPrice.Item1;
                    }
                    GlobalState.paramPrice = new Tuple<int, int>(low, int.Parse(highPrice.Text));
                    highPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    GenerateListings();
                    SetMapValues();
                }
            }
            else
            {
                highPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void enterSizeLow(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                lowSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }
            if (e.Key == Key.Return)
            {

                if (int.TryParse(lowSize.Text, out _))
                {
                    int high = 20000;
                    if (GlobalState.paramSize != null)
                    {
                        high = GlobalState.paramSize.Item2;
                    }
                    GlobalState.paramSize = new Tuple<int, int>(int.Parse(lowSize.Text), high);
                    lowSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    GenerateListings();
                    SetMapValues();
                }
            }
            else
            {
                lowSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void enterSizeHigh(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                highSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }

            if (e.Key == Key.Return)
            {

                if (int.TryParse(highSize.Text, out _))
                {
                    int low = 0;
                    if (GlobalState.paramSize != null)
                    {
                        low = GlobalState.paramSize.Item1;
                    }
                    GlobalState.paramSize = new Tuple<int, int>(low, int.Parse(highSize.Text));
                    highSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    GenerateListings();
                    SetMapValues();
                }
            }
            else
            {
                highSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }


        private void enterBedLow(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                lowBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }
            if (e.Key == Key.Return)
            {

                if (int.TryParse(lowBed.Text, out _))
                {
                    int high = 6;
                    if (GlobalState.paramBed != null)
                    {
                        high = GlobalState.paramBed.Item2;
                    }
                    GlobalState.paramBed = new Tuple<int, int>(int.Parse(lowBed.Text), high);
                    lowBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    GenerateListings();
                    SetMapValues();
                }
            }
            else
            {
                lowBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void enterBedHigh(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                highBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }

            if (e.Key == Key.Return)
            {

                if (int.TryParse(highBed.Text, out _))
                {
                    int low = 0;
                    if (GlobalState.paramBed != null)
                    {
                        low = GlobalState.paramBed.Item1;
                    }
                    GlobalState.paramBed = new Tuple<int, int>(low, int.Parse(highBed.Text));
                    highBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    GenerateListings();
                    SetMapValues();
                }
            }
            else
            {
                highBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }


        private void enterBathLow(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                lowBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }
            if (e.Key == Key.Return)
            {

                if (int.TryParse(lowBath.Text, out _))
                {
                    int high = 6;
                    if (GlobalState.paramBath != null)
                    {
                        high = GlobalState.paramBath.Item2;
                    }
                    GlobalState.paramBath = new Tuple<int, int>(int.Parse(lowBath.Text), high);
                    lowBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    GenerateListings();
                    SetMapValues();
                }
            }
            else
            {
                lowBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void enterBathHigh(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                highBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }

            if (e.Key == Key.Return)
            {

                if (int.TryParse(highBath.Text, out _))
                {
                    int low = 0;
                    if (GlobalState.paramBath != null)
                    {
                        low = GlobalState.paramBath.Item1;
                    }
                    GlobalState.paramBath = new Tuple<int, int>(low, int.Parse(highBath.Text));
                    highBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    GenerateListings();
                    SetMapValues();
                }
            }
            else
            {
                highBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }


        private void enterYearLow(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                lowYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }
            if (e.Key == Key.Return)
            {

                if (int.TryParse(lowYear.Text, out _))
                {
                    int high = 2021;
                    if (GlobalState.paramYear != null)
                    {
                        high = GlobalState.paramYear.Item2;
                    }
                    GlobalState.paramYear = new Tuple<int, int>(int.Parse(lowYear.Text), high);
                    lowYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    GenerateListings();
                    SetMapValues();
                }
            }
            else
            {
                lowYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void enterYearHigh(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                highYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }

            if (e.Key == Key.Return)
            {

                if (int.TryParse(highYear.Text, out _))
                {
                    int low = 0;
                    if (GlobalState.paramYear != null)
                    {
                        low = GlobalState.paramYear.Item1;
                    }
                    GlobalState.paramYear = new Tuple<int, int>(low, int.Parse(highYear.Text));
                    highYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    GenerateListings();
                    SetMapValues();
                }
            }
            else
            {
                highYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void SingleFamily_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.paramType = ListingType.SingleFamily;
        }

        private void Duplex_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.paramType = ListingType.Duplex;
        }

        private void Triplex_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.paramType = ListingType.Triplex;
        }

        private void Townhome_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.paramType = ListingType.Townhome;
        }

        private void Apartment_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.paramType = ListingType.Apartment;
        }

        private void Loft_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.paramType = ListingType.Loft;
        }

        private void MouseOnLogin(object sender, MouseEventArgs e)
        {
            isOnAccount = true;
        }
        private void MouseOutLogin(object sender, MouseEventArgs e)
        {
            isOnAccount = false;
        }

        private void createAccountButtonAC_Click(object sender, RoutedEventArgs e)
        {
            if (inputValidation()) 
            {
                signupGrid.Visibility = Visibility.Hidden;
                successSignupGrid.Visibility = Visibility.Visible;
            }
        }

        private bool inputValidation()
        {
            var bc = new BrushConverter();
            bool valid = true;
            // Error Background = "#FFFFB7B7"
            String username = userNameTextBoxAC.Text;
            String password = passwordTextBoxAC.Password;
            String email = emailTextBoxAC.Text;
            // Check username 
            if (username.Equals(""))
            {
                userNameTextBoxAC.Background = (Brush)bc.ConvertFrom("#FFFFB7B7");
                valid = false;
            }
            else
            {
                userNameTextBoxAC.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            }
            // Check password
            if (password.Equals(""))
            {
                passwordTextBoxAC.Background = (Brush)bc.ConvertFrom("#FFFFB7B7");
                valid = false;
            }
            else
            {
                passwordTextBoxAC.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            }
            // Check email
            if (email.Equals(""))
            {
                emailTextBoxAC.Background = (Brush)bc.ConvertFrom("#FFFFB7B7");
                valid = false;
            }
            else
            {
                emailTextBoxAC.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            }

            return valid;
        }

        private void logInButton_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.isLoggedIn = true;
            AccountPopUp.Visibility = Visibility.Hidden;
            profileButtonVisibility();
        }

        private void loginButtonSUCC_Click(object sender, RoutedEventArgs e)
        {
            successSignupGrid.Visibility = Visibility.Hidden;
            logInGrid.Visibility = Visibility.Visible;
        }

        private void createAcccountTextButton_Click(object sender, RoutedEventArgs e)
        {
            logInGrid.Visibility = Visibility.Hidden;
            signupGrid.Visibility = Visibility.Visible;
        }

        private void RemoveAccountPopUp(object sender, MouseButtonEventArgs e)
        {
            if(!isOnAccount)
            {
                AccountPopUp.Visibility = Visibility.Collapsed;
            }
            
        }

        //Make it so, if a favorite is attempted to be changed, and the user is not logged in, then fun this
        private void AccountPopsUp()
        {
            AccountPopUp.Visibility = Visibility.Visible;
            logInGrid.Visibility = Visibility.Visible;
            signupGrid.Visibility = Visibility.Collapsed;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void expandListing(object sender, MouseButtonEventArgs e)
        {
            var currentListing = (sender as Rectangle).Parent;
            int numOfListing = Int16.Parse(currentListing.GetType().GetProperty("Name").GetValue(currentListing).ToString().Substring(7))-1;
            GlobalState.currentIndex = numOfListing;
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
        }

        private void expandListingImg(object sender, MouseButtonEventArgs e)
        {
            var currentListing = (sender as Image).Parent;
            int numOfListing = Int16.Parse(currentListing.GetType().GetProperty("Name").GetValue(currentListing).ToString().Substring(7))-1;
            GlobalState.currentIndex = numOfListing;
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
        }

        private void ChangeFavorite(object sender, MouseButtonEventArgs e)
        {
            if(GlobalState.isLoggedIn)
            {
                int numOfListing = Int16.Parse(sender.GetType().GetProperty("Name").GetValue(sender).ToString().Substring(5));
                GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited = !GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited;

                var heartImg = (sender as Image);
                heartImg.Source = GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative));

            }
            else
            {
                AccountPopsUp();
            }
        }

        
    }
}

