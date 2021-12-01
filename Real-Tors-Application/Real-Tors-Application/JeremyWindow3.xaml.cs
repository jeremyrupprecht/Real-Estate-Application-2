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
        public List<int> list2 = new List<int> { 1,2,3,4,5 };
        public int mainImageNumber = 0;
        public List<Listing> ListOfListings = new List<Listing>();
        public List<int> similarNum;
        public bool onButton, onPopup;


        public JeremyWindow3()
        {
            InitializeComponent();
            if (GlobalState.similar != -1)
            {
                Console.WriteLine("Similar Listing " + GlobalState.totalList[GlobalState.similar].Address);
                LeftArrow.Visibility = Visibility.Collapsed;
                RightArrow.Visibility = Visibility.Collapsed;
                BackIfSimilar.Visibility = Visibility.Visible;
                //BackIfSimilar.Content = "Back to " + GlobalState.totalList[GlobalState.currentList[GlobalState.currentIndex]].Address;
                list1 = GlobalState.totalList[GlobalState.similar];
                filteredListingsTextBlock.Visibility = Visibility.Collapsed;
                FilteredListingsScroll.Visibility = Visibility.Collapsed;
            }
            else
            {
                if (GlobalState.currentIndex == 0)
                {
                    LeftArrow.Visibility = Visibility.Collapsed;
                }
                if (GlobalState.currentIndex == 8 || GlobalState.currentList[GlobalState.currentIndex+1]==-1)
                {
                    RightArrow.Visibility = Visibility.Collapsed;
                }
                list1 = GlobalState.totalList[GlobalState.currentList[GlobalState.currentIndex]];
            }
            ShowMainListing();
            GenerateListings();
            FillList();
        }

        private void changeMainImageRight(object sender, RoutedEventArgs e)
        {
            if (mainImageNumber == 0)
            {

                mainImageNumber = 1;
                //            replace each of these lines with: @"/houseinterior" + mainImageNumber + ".jpg"
                MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +mainImageNumber + ".jpg", UriKind.Relative));

            } else if (mainImageNumber == 1)
            {

                mainImageNumber = 2;
                MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +mainImageNumber + ".jpg", UriKind.Relative));

            } else if (mainImageNumber == 2)
            {

                mainImageNumber = 3;
                MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +mainImageNumber + ".jpg", UriKind.Relative));

            } else if (mainImageNumber == 3)
            {

                mainImageNumber = 5;
                MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +mainImageNumber + ".jpg", UriKind.Relative));

            } else if (mainImageNumber == 4)
            {

                mainImageNumber = 5;
                MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +mainImageNumber + ".jpg", UriKind.Relative));

            } else if (mainImageNumber == 5)
            {

                mainImageNumber = 0;
                MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +mainImageNumber + ".jpg", UriKind.Relative));

            } 

        }

        private void changeMainImageLeft(object sender, RoutedEventArgs e)
        {

            if (mainImageNumber == 0)
            {

                mainImageNumber = 5;
                MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +mainImageNumber + ".jpg", UriKind.Relative));

            } else if (mainImageNumber == 1)
            {

                mainImageNumber = 0;
                MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +mainImageNumber + ".jpg", UriKind.Relative));

            } else if (mainImageNumber == 2)
            {

                mainImageNumber = 1;
                MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +mainImageNumber + ".jpg", UriKind.Relative));

            } else if (mainImageNumber == 3)
            {

                mainImageNumber = 2;
                MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +mainImageNumber + ".jpg", UriKind.Relative));

            } else if (mainImageNumber == 4)
            {
                
                mainImageNumber = 3;
                MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +mainImageNumber + ".jpg", UriKind.Relative));

            } else if (mainImageNumber == 5)
            {

                mainImageNumber = 4;
                MainHouseImage.Source = new BitmapImage(new Uri(@"/houseImg" +mainImageNumber + ".jpg", UriKind.Relative));

            } 

        }


        private void btn_saveForLater_Click(object sender, RoutedEventArgs e)
        {
            ChangeFavoriteActivate();
        }

        private void btn_contractRealtor_Click(object sender, RoutedEventArgs e)
        {

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Filters and Header Stuff


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
            if (HomeTypesSelect.Visibility == Visibility.Collapsed)
            {
                dropdown_btn_image.Source = new BitmapImage(new Uri("sortup_icon.png", UriKind.RelativeOrAbsolute));
                HomeTypesSelect.Visibility = Visibility.Visible;
            }
            else
            {
                dropdown_btn_image.Source = new BitmapImage(new Uri("sortdown_icon.png", UriKind.RelativeOrAbsolute));
                HomeTypesSelect.Visibility = Visibility.Collapsed;
            }
        }


        private void ToggleFilter(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine("Toggle Pressed");
            //timer.Start();
            if (FilterPanel.Visibility == Visibility.Collapsed)
            {

                FilterPanel.Visibility = Visibility.Visible;

            }
            else
            {

                FilterPanel.Visibility = Visibility.Collapsed;
            }

            ChangeExpansion();
        }

        private void FillList()
        {
            if (GlobalState.isOpen)
            {
                FilterPanel.Visibility = Visibility.Visible;
                ChangeExpansion();
            }
            else
            {
                FilterPanel.Visibility = Visibility.Collapsed;
                ChangeExpansion();
            }

            if (GlobalState.isLoggedIn)
            {
                profileButton.Visibility = Visibility.Visible;
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
            if (AmenitiesInput.Text != null && !GlobalState.paramAmenities.Contains(AmenitiesInput.Text) && GlobalState.paramAmenities.Count() < 5 && AmenitiesInput.Text.Count() > 0)
            {
                GlobalState.paramAmenities.Add(AmenitiesInput.Text);
                AmenitiesInput.Text = "";
                Print_Amenity();
                //GlobalState.Generate(9);
                //GenerateListings();
            }
        }

        private void DeleteAmenity(object sender, MouseButtonEventArgs e)
        {
            var lbl = sender as Label;

            GlobalState.paramAmenities.Remove(lbl.Content.ToString().Substring(2));
            Print_Amenity();
            //GlobalState.Generate(9);
            //GenerateListings();
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
            if (count >= 1)
            {
                Amenity1.Content = "x " + GlobalState.paramAmenities[0];
                Amenity1.Visibility = Visibility.Visible;

                if (count >= 2)
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
            if (NeighbourhoodInput.Text != null && !GlobalState.paramNeighbourhood.Contains(NeighbourhoodInput.Text) && GlobalState.paramNeighbourhood.Count() < 6 && NeighbourhoodInput.Text.Count() > 0)
            {
                GlobalState.paramNeighbourhood.Add(NeighbourhoodInput.Text);
                NeighbourhoodInput.Text = "";
                Print_Neighbourhood();
                //GlobalState.Generate(9);
                //GenerateListings();
            }
        }

        private void DeleteNeighbour(object sender, MouseButtonEventArgs e)
        {
            var lbl = sender as Label;
            GlobalState.paramNeighbourhood.Remove(lbl.Content.ToString().Substring(2));
            Print_Neighbourhood();
            //GlobalState.Generate(9);
            //GenerateListings();
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

                                if (count >= 6)
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
                    //GlobalState.Generate(9);
                    //GenerateListings();
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
                    //GlobalState.Generate(9);
                    //GenerateListings();
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
                    //GlobalState.Generate(9);
                    //GenerateListings();
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
                    //GlobalState.Generate(9);
                    //GenerateListings();
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
                    //GlobalState.Generate(9);
                    //GenerateListings();
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
                    //GlobalState.Generate(9);
                    //GenerateListings();
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
                    //GlobalState.Generate(9);
                    //GenerateListings();
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
                    //GlobalState.Generate(9);
                    //GenerateListings();
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
                    //GlobalState.Generate(9);
                    //GenerateListings();
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
                    //GlobalState.Generate(9);
                    //GenerateListings();
                }
            }
            else
            {
                highYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }



        /////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void ChangeExpansion()
        {
            if(FilterPanel.Visibility == Visibility.Collapsed)
            {
                expandedListingGrid.Width = 1900;
                Column1.Width = new GridLength(700);
                expandedListingScrollViewer.Width = 1700;
                SimilarListingsScroll.Width = 1600;
                FilteredListingsScroll.Width = 1600;
                LeftArrow.Margin = new Thickness(50, 804, 1773, 146);
            }
            
            else
            {
                expandedListingScrollViewer.Width = 1220;
                Column1.Width = new GridLength(500);
                expandedListingGrid.Width = 1480;
                SimilarListingsScroll.Width = 1150;
                FilteredListingsScroll.Width = 1150;
                LeftArrow.Margin = new Thickness(452, 804, 1353, 146);
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
            Print_AmenityF();
        }

        private void Print_AmenityF()
        {
            AmenityF1.Visibility = Visibility.Collapsed;
            AmenityF2.Visibility = Visibility.Collapsed;
            AmenityF3.Visibility = Visibility.Collapsed;
            AmenityF4.Visibility = Visibility.Collapsed;
            AmenityF5.Visibility = Visibility.Collapsed;
            if (list1.Amenities == null)
                return;
            int count = list1.Amenities.Count;
            if (count >= 1)
            {
                AmenityF1.Content = list1.Amenities[0];
                AmenityF1.Visibility = Visibility.Visible;

                if (count >= 2)
                {
                    AmenityF2.Content = list1.Amenities[1];
                    AmenityF2.Visibility = Visibility.Visible;

                    if (count >= 3)
                    {
                        AmenityF3.Content = list1.Amenities[2];
                        AmenityF3.Visibility = Visibility.Visible;

                        if (count >= 4)
                        {
                            AmenityF4.Content = list1.Amenities[3];
                            AmenityF4.Visibility = Visibility.Visible;

                            if (count >= 5)
                            {
                                AmenityF5.Content = list1.Amenities[4];
                                AmenityF5.Visibility = Visibility.Visible;

                            }
                        }
                    }
                }
            }
        }

        public void GenerateListings()
        {
            similarNum = GlobalState.GenerateSimilar((GlobalState.similar!=-1? GlobalState.similar : 50));

            for (int i = 0; i < 6; i++)
            {
                ListOfListings.Add(GlobalState.totalList[similarNum[i]]);
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

            ListingF1.Visibility = Visibility.Collapsed;
            ListingF2.Visibility = Visibility.Collapsed;
            ListingF3.Visibility = Visibility.Collapsed;
            ListingF4.Visibility = Visibility.Collapsed;
            ListingF5.Visibility = Visibility.Collapsed;
            ListingF6.Visibility = Visibility.Collapsed;

            if (GlobalState.currentList[1]!=-1)
            {
                Neighbourhood7.Content = GlobalState.totalList[GlobalState.currentList[1]].Neighbourhood;
                PriceNum7.Content = "$" + GlobalState.totalList[GlobalState.currentList[1]].Price;
                BedNumber7.Content = GlobalState.totalList[GlobalState.currentList[1]].BedNum;
                BathNumber7.Content = GlobalState.totalList[GlobalState.currentList[1]].BathNum;
                SizeNumber7.Content = GlobalState.totalList[GlobalState.currentList[1]].Size + " sq ft";
                HouseImage7.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[1]].NumOfImg + ".jpg", UriKind.Relative));
                ListingF1.Visibility = Visibility.Visible;
                ShrinkNeighbourhoodText(Neighbourhood7);

                if (GlobalState.currentList[2] != -1)
                {
                    Neighbourhood8.Content = GlobalState.totalList[GlobalState.currentList[2]].Neighbourhood;
                    PriceNum8.Content = "$" + GlobalState.totalList[GlobalState.currentList[2]].Price;
                    BedNumber8.Content = GlobalState.totalList[GlobalState.currentList[2]].BedNum;
                    BathNumber8.Content = GlobalState.totalList[GlobalState.currentList[2]].BathNum;
                    SizeNumber8.Content = GlobalState.totalList[GlobalState.currentList[2]].Size + " sq ft";
                    HouseImage8.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[2]].NumOfImg + ".jpg", UriKind.Relative));
                    ListingF2.Visibility = Visibility.Visible;

                    ShrinkNeighbourhoodText(Neighbourhood8);

                    if (GlobalState.currentList[3] != -1) {
                        Neighbourhood9.Content = GlobalState.totalList[GlobalState.currentList[3]].Neighbourhood;
                        PriceNum9.Content = "$" + GlobalState.totalList[GlobalState.currentList[3]].Price;
                        BedNumber9.Content = GlobalState.totalList[GlobalState.currentList[3]].BedNum;
                        BathNumber9.Content = GlobalState.totalList[GlobalState.currentList[3]].BathNum;
                        SizeNumber9.Content = GlobalState.totalList[GlobalState.currentList[3]].Size + " sq ft";
                        HouseImage9.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[3]].NumOfImg + ".jpg", UriKind.Relative));
                        ListingF3.Visibility = Visibility.Visible;


                        ShrinkNeighbourhoodText(Neighbourhood9);

                        if (GlobalState.currentList[4] != -1)
                        {
                            Neighbourhood10.Content = GlobalState.totalList[GlobalState.currentList[4]].Neighbourhood;
                            PriceNum10.Content = "$" + GlobalState.totalList[GlobalState.currentList[4]].Price;
                            BedNumber10.Content = GlobalState.totalList[GlobalState.currentList[4]].BedNum;
                            BathNumber10.Content = GlobalState.totalList[GlobalState.currentList[4]].BathNum;
                            SizeNumber10.Content = GlobalState.totalList[GlobalState.currentList[4]].Size + " sq ft";
                            HouseImage10.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[4]].NumOfImg + ".jpg", UriKind.Relative));
                            ListingF4.Visibility = Visibility.Visible;


                            ShrinkNeighbourhoodText(Neighbourhood10);

                            if (GlobalState.currentList[5] != -1)
                            {
                                Neighbourhood11.Content = GlobalState.totalList[GlobalState.currentList[5]].Neighbourhood;
                                PriceNum11.Content = "$" + GlobalState.totalList[GlobalState.currentList[5]].Price;
                                BedNumber11.Content = GlobalState.totalList[GlobalState.currentList[5]].BedNum;
                                BathNumber11.Content = GlobalState.totalList[GlobalState.currentList[5]].BathNum;
                                SizeNumber11.Content = GlobalState.totalList[GlobalState.currentList[5]].Size + " sq ft";
                                HouseImage11.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[5]].NumOfImg + ".jpg", UriKind.Relative));

                                ListingF5.Visibility = Visibility.Visible;


                                ShrinkNeighbourhoodText(Neighbourhood11);

                                if (GlobalState.currentList[6] != -1)
                                {
                                    Neighbourhood12.Content = GlobalState.totalList[GlobalState.currentList[6]].Neighbourhood;
                                    PriceNum12.Content = "$" + GlobalState.totalList[GlobalState.currentList[6]].Price;
                                    BedNumber12.Content = GlobalState.totalList[GlobalState.currentList[6]].BedNum;
                                    BathNumber12.Content = GlobalState.totalList[GlobalState.currentList[6]].BathNum;
                                    SizeNumber12.Content = GlobalState.totalList[GlobalState.currentList[6]].Size + " sq ft";
                                    HouseImage12.Source = new BitmapImage(new Uri(@"/houseImg" + GlobalState.totalList[GlobalState.currentList[6]].NumOfImg + ".jpg", UriKind.Relative));

                                    ListingF6.Visibility = Visibility.Visible;

                                    ShrinkNeighbourhoodText(Neighbourhood12);


                                }
                            }
                        }
                    }
                }
            }

           
            
            
            
            
            ShrinkNeighbourhoodText(Neighbourhood1);
            ShrinkNeighbourhoodText(Neighbourhood2);
            ShrinkNeighbourhoodText(Neighbourhood3);
            ShrinkNeighbourhoodText(Neighbourhood4);
            ShrinkNeighbourhoodText(Neighbourhood5);
            ShrinkNeighbourhoodText(Neighbourhood6);
            

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
            int numOfListing;
            if (GlobalState.similar != -1)
            {
                numOfListing = GlobalState.similar;
                GlobalState.totalList[GlobalState.similar].Favorited = !GlobalState.totalList[GlobalState.similar].Favorited;

                var heartImg = FavoritedListing;
                heartImg.Source = GlobalState.totalList[GlobalState.similar].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative));
            }
            else
            {
                numOfListing = GlobalState.currentIndex;
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
            GlobalState.similar = similarNum[numOfListing];
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
        }

        
        private void expandListingFiltered(object sender, MouseButtonEventArgs e)
        {
            int numOfListing = Int16.Parse(sender.GetType().GetProperty("Name").GetValue(sender).ToString().Substring(8));
            GlobalState.currentIndex = numOfListing;
            GlobalState.similar = -1;
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
        }

        private void enterPopUp(object sender, MouseEventArgs e)
        {
            onPopup = true;
        }

        private void exitPopUp(object sender, MouseEventArgs e)
        {
            onPopup = false;
        }

        private void onButtons(object sender, MouseEventArgs e)
        {
            onButton = true;
        }

        private void offButtons(object sender, MouseEventArgs e)
        {
            onButton = false;
        }

        private void exitExpanded(object sender, MouseButtonEventArgs e)
        {
            if(!onPopup && !onButton)
            {
                switch(GlobalState.lastPage)
                {
                    case "Favorites":
                        break;
                    case "Hamptons":
                        break;
                    case "Citadel":
                        break;
                    case "Simons Valley":
                        break;
                    case "Edgemont":
                        break;
                    case "Hawkwood":
                        break;
                    default:
                        ListView pNext = new ListView();
                        GlobalState.currentIndex = -1;
                        GlobalState.similar = -1;
                        this.NavigationService.Navigate(pNext);
                        break;
                }
                
            }
        }

        private void BackToSelection(object sender, RoutedEventArgs e)
        {
            GlobalState.similar = -1;
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
        }
    }
}
