﻿using System;
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
using System.Windows.Threading;             //Needed for animation
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
            //InitFilter();
            GlobalState.lastPage = "List";          //Set last page for easy jumping in between
            GlobalState.Generate();
            GenerateListings();
        }

        private void btn_MapView_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MapViewUnZoomed.xaml", UriKind.Relative));
        }

        public void GenerateListings()
        {
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

        private void contactButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ContactUsView.xaml", UriKind.Relative));
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

        //DispatcherTimer timer;

        //int panelWidth;
        //bool hidden;

        //private void InitFilter()
        //{
        //    Console.WriteLine("Initializing Filter");
        //    timer = new DispatcherTimer(DispatcherPriority.Background, Application.Current.Dispatcher);
        //    timer.Interval = new TimeSpan(0, 0, 0, 10);
        //    timer.Tick += Timer_Tick;

        //    panelWidth = (int)FilterPanel.Width;
        //}

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Timer ticking: "+ FilterPanel.Width);
        //    if (hidden)
        //    {
        //        FilterPanel.Width += 1;
        //        if (FilterPanel.Width >= panelWidth)
        //        {
        //            timer.Stop();
        //            hidden = false;
        //        }
        //    }
        //    else
        //    {
        //        FilterPanel.Width -= 1;
        //        if (FilterPanel.Width <= 30)
        //        {
        //            timer.Stop();
        //            hidden = true;
        //        }
        //    }
        //}


        private void ToggleFilter(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine("Toggle Pressed");
            //timer.Start();
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
            }
        }

        private void DeleteAmenity(object sender, MouseButtonEventArgs e)
        {
            var lbl = sender as Label;
            
            GlobalState.paramAmenities.Remove(lbl.Content.ToString().Substring(2));
            Print_Amenity();
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
            }
        }

        private void DeleteNeighbour(object sender, MouseButtonEventArgs e)
        {
            var lbl = sender as Label;
            GlobalState.paramNeighbourhood.Remove(lbl.Content.ToString().Substring(2));
            Print_Neighbourhood();
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
            int numOfListing = Int16.Parse(sender.GetType().GetProperty("Name").GetValue(sender).ToString().Substring(5));
            GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited = !GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited;
            
            var heartImg = (sender as Image);
            heartImg.Source = GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited ? new BitmapImage(new Uri(@"HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"HeartIconEmpty.png", UriKind.Relative));
        }

        private void enterPriceLow(object sender, KeyEventArgs e)
        {
            var box = sender as TextBlock;
            if(int.TryParse(box.Text, out _))
            {
                int high = 25000000;
                if(GlobalState.paramPrice!=null)
                {
                    high = GlobalState.paramPrice.Item2;
                }
                GlobalState.paramPrice = new Tuple<int, int>(int.Parse(box.Text), high);
            }
        }
    }
}

