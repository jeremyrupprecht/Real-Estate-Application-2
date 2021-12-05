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
    /// Interaction logic for MapViewSimonsValley.xaml
    /// </summary>
    public partial class MapViewSimonsValley : Page
    {
        public String nameOfCurrentNeighbourhood = "Simons Valley";
        public MapViewSimonsValley()
        {
            InitializeComponent();
            GetListings();

            FillList();
            profileButtonVisibility();
        }

        private Tuple<int, int> offsetFrom100(double x, double y)
        {
            int xmin = GlobalState.neighbourhoodBounds[nameOfCurrentNeighbourhood].Item1, xmax = GlobalState.neighbourhoodBounds[nameOfCurrentNeighbourhood].Item2,
                ymin = GlobalState.neighbourhoodBounds[nameOfCurrentNeighbourhood].Item3, ymax = GlobalState.neighbourhoodBounds[nameOfCurrentNeighbourhood].Item4;

            return new Tuple<int, int>((int)((xmax - xmin) * x + xmin), (int)((ymax - ymin) * y + ymin));

        }

        private void GetListings()
        {
            GlobalState.paramNeighbourhood.Clear();
            GlobalState.paramNeighbourhood.Add(nameOfCurrentNeighbourhood);
            GlobalState.Generate();
            Tuple<int, int> offset;
            Listing curr;

            if (GlobalState.currentList[0] != -1)
            {
                btn_Pin1.Visibility = Visibility.Visible;
                curr = GlobalState.totalList[GlobalState.currentList[0]];
                Neighbourhood1.Content = curr.Neighbourhood;
                PriceNum1.Content = "$" + curr.Price;
                SizeNumber1.Content = curr.Size + " sqft";
                BedNumber1.Content = curr.BedNum;
                BathNumber1.Content = curr.BathNum;
                HouseImage1.Source = new BitmapImage(new Uri(@"../houseImg" + curr.NumOfImg + ".jpg", UriKind.Relative));
                Heart1.Source = curr.Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));

                TranslateTransform translateT = new TranslateTransform();
                offset = offsetFrom100(curr.Coordinates.Item1, curr.Coordinates.Item2);
                translateT.X = offset.Item1;
                translateT.Y = offset.Item2;
                TransformGroup tg = new TransformGroup();
                tg.Children.Add(translateT);
                Listing1Grid.RenderTransform = tg;
            }

            if (GlobalState.currentList[1] != -1)
            {
                btn_Pin2.Visibility = Visibility.Visible;
                curr = GlobalState.totalList[GlobalState.currentList[1]];
                Neighbourhood2.Content = curr.Neighbourhood;
                PriceNum2.Content = "$" + curr.Price;
                SizeNumber2.Content = curr.Size + " sqft";
                BedNumber2.Content = curr.BedNum;
                BathNumber2.Content = curr.BathNum;
                HouseImage2.Source = new BitmapImage(new Uri(@"../houseImg" + curr.NumOfImg + ".jpg", UriKind.Relative));
                Heart2.Source = curr.Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));

                TranslateTransform translateT = new TranslateTransform();
                offset = offsetFrom100(curr.Coordinates.Item1, curr.Coordinates.Item2);
                translateT.X = offset.Item1;
                translateT.Y = offset.Item2;
                TransformGroup tg = new TransformGroup();
                tg.Children.Add(translateT);
                Listing2Grid.RenderTransform = tg;
            }

            if (GlobalState.currentList[2] != -1)
            {
                btn_Pin3.Visibility = Visibility.Visible;
                curr = GlobalState.totalList[GlobalState.currentList[2]];
                Neighbourhood3.Content = curr.Neighbourhood;
                PriceNum3.Content = "$" + curr.Price;
                SizeNumber3.Content = curr.Size + " sqft";
                BedNumber3.Content = curr.BedNum;
                BathNumber3.Content = curr.BathNum;
                HouseImage3.Source = new BitmapImage(new Uri(@"../houseImg" + curr.NumOfImg + ".jpg", UriKind.Relative));
                Heart3.Source = curr.Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));

                TranslateTransform translateT = new TranslateTransform();
                offset = offsetFrom100(curr.Coordinates.Item1, curr.Coordinates.Item2);
                translateT.X = offset.Item1;
                translateT.Y = offset.Item2;
                TransformGroup tg = new TransformGroup();
                tg.Children.Add(translateT);
                Listing3Grid.RenderTransform = tg;
            }

            if (GlobalState.currentList[3] != -1)
            {
                btn_Pin4.Visibility = Visibility.Visible;
                curr = GlobalState.totalList[GlobalState.currentList[3]];
                Neighbourhood4.Content = curr.Neighbourhood;
                PriceNum4.Content = "$" + curr.Price;
                SizeNumber4.Content = curr.Size + " sqft";
                BedNumber4.Content = curr.BedNum;
                BathNumber4.Content = curr.BathNum;
                HouseImage4.Source = new BitmapImage(new Uri(@"../houseImg" + curr.NumOfImg + ".jpg", UriKind.Relative));
                Heart4.Source = curr.Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));

                TranslateTransform translateT = new TranslateTransform();
                offset = offsetFrom100(curr.Coordinates.Item1, curr.Coordinates.Item2);
                translateT.X = offset.Item1;
                translateT.Y = offset.Item2;
                TransformGroup tg = new TransformGroup();
                tg.Children.Add(translateT);
                Listing4Grid.RenderTransform = tg;
            }

            if (GlobalState.currentList[4] != -1)
            {
                btn_Pin5.Visibility = Visibility.Visible;
                curr = GlobalState.totalList[GlobalState.currentList[4]];
                Neighbourhood5.Content = curr.Neighbourhood;
                PriceNum5.Content = "$" + curr.Price;
                SizeNumber5.Content = curr.Size + " sqft";
                BedNumber5.Content = curr.BedNum;
                BathNumber5.Content = curr.BathNum;
                HouseImage5.Source = new BitmapImage(new Uri(@"../houseImg" + curr.NumOfImg + ".jpg", UriKind.Relative));
                Heart5.Source = curr.Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));

                TranslateTransform translateT = new TranslateTransform();
                offset = offsetFrom100(curr.Coordinates.Item1, curr.Coordinates.Item2);
                translateT.X = offset.Item1;
                translateT.Y = offset.Item2;
                TransformGroup tg = new TransformGroup();
                tg.Children.Add(translateT);
                Listing5Grid.RenderTransform = tg;
            }

            if (GlobalState.currentList[5] != -1)
            {
                btn_Pin6.Visibility = Visibility.Visible;
                curr = GlobalState.totalList[GlobalState.currentList[5]];
                Neighbourhood6.Content = curr.Neighbourhood;
                PriceNum6.Content = "$" + curr.Price;
                SizeNumber6.Content = curr.Size + " sqft";
                BedNumber6.Content = curr.BedNum;
                BathNumber6.Content = curr.BathNum;
                HouseImage6.Source = new BitmapImage(new Uri(@"../houseImg" + curr.NumOfImg + ".jpg", UriKind.Relative));
                Heart6.Source = curr.Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));

                TranslateTransform translateT = new TranslateTransform();
                offset = offsetFrom100(curr.Coordinates.Item1, curr.Coordinates.Item2);
                translateT.X = offset.Item1;
                translateT.Y = offset.Item2;
                TransformGroup tg = new TransformGroup();
                tg.Children.Add(translateT);
                Listing6Grid.RenderTransform = tg;
            }

            if (GlobalState.currentList[6] != -1)
            {
                btn_Pin7.Visibility = Visibility.Visible;
                curr = GlobalState.totalList[GlobalState.currentList[6]];
                Neighbourhood7.Content = curr.Neighbourhood;
                PriceNum7.Content = "$" + curr.Price;
                SizeNumber7.Content = curr.Size + " sqft";
                BedNumber7.Content = curr.BedNum;
                BathNumber7.Content = curr.BathNum;
                HouseImage7.Source = new BitmapImage(new Uri(@"../houseImg" + curr.NumOfImg + ".jpg", UriKind.Relative));
                Heart7.Source = curr.Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));

                TranslateTransform translateT = new TranslateTransform();
                offset = offsetFrom100(curr.Coordinates.Item1, curr.Coordinates.Item2);
                translateT.X = offset.Item1;
                translateT.Y = offset.Item2;
                TransformGroup tg = new TransformGroup();
                tg.Children.Add(translateT);
                Listing7Grid.RenderTransform = tg;
            }

            if (GlobalState.currentList[7] != -1)
            {
                btn_Pin8.Visibility = Visibility.Visible;
                curr = GlobalState.totalList[GlobalState.currentList[7]];
                Neighbourhood8.Content = curr.Neighbourhood;
                PriceNum8.Content = "$" + curr.Price;
                SizeNumber8.Content = curr.Size + " sqft";
                BedNumber8.Content = curr.BedNum;
                BathNumber8.Content = curr.BathNum;
                HouseImage8.Source = new BitmapImage(new Uri(@"../houseImg" + curr.NumOfImg + ".jpg", UriKind.Relative));
                Heart8.Source = curr.Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));

                TranslateTransform translateT = new TranslateTransform();
                offset = offsetFrom100(curr.Coordinates.Item1, curr.Coordinates.Item2);
                translateT.X = offset.Item1;
                translateT.Y = offset.Item2;
                TransformGroup tg = new TransformGroup();
                tg.Children.Add(translateT);
                Listing8Grid.RenderTransform = tg;
            }

            if (GlobalState.currentList[8] != -1)
            {
                btn_Pin9.Visibility = Visibility.Visible;
                curr = GlobalState.totalList[GlobalState.currentList[8]];
                Neighbourhood9.Content = curr.Neighbourhood;
                PriceNum9.Content = "$" + curr.Price;
                SizeNumber9.Content = curr.Size + " sqft";
                BedNumber9.Content = curr.BedNum;
                BathNumber9.Content = curr.BathNum;
                HouseImage9.Source = new BitmapImage(new Uri(@"../houseImg" + curr.NumOfImg + ".jpg", UriKind.Relative));
                Heart9.Source = curr.Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));

                TranslateTransform translateT = new TranslateTransform();
                offset = offsetFrom100(curr.Coordinates.Item1, curr.Coordinates.Item2);
                translateT.X = offset.Item1;
                translateT.Y = offset.Item2;
                TransformGroup tg = new TransformGroup();
                tg.Children.Add(translateT);
                Listing9Grid.RenderTransform = tg;
            }

        }

        private void Btn_Map_Click(object sender, RoutedEventArgs e)
        {
            //this.NavigationService.Navigate(new Uri("MapViewZoomed2Hovered.xaml", UriKind.Relative));
        }

        private void Btn_Zoomout_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MapViewNorthWest.xaml", UriKind.Relative));
        }

        private void Btn_ListView_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ListView.xaml", UriKind.Relative));
        }

/*        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }*/

        private void navLogInButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("SignupView.xaml", UriKind.Relative));
        }

/*        private void toggleTypes(object sender, RoutedEventArgs e)
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

        }*/

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

        private void ReimplementTop(object sender)
        {
            Grid g = (sender as Button).Parent as Grid;
            Grid gUpper = g.Parent as Grid;
            gUpper.Children.Remove(g);
            gUpper.Children.Add(g);
        }

        private void MouseOverPin1(object sender, MouseEventArgs e)
        {
            Listing1.Visibility = Visibility.Visible;
            ReimplementTop(sender);
        }

        private void MouseOut1(object sender, MouseEventArgs e)
        {
            Listing1.Visibility = Visibility.Hidden;
        }

        private void MouseOverPin2(object sender, MouseEventArgs e)
        {
            Listing2.Visibility = Visibility.Visible;
            ReimplementTop(sender);
        }

        private void MouseOut2(object sender, MouseEventArgs e)
        {
            Listing2.Visibility = Visibility.Hidden;
        }

        private void MouseOverPin3(object sender, MouseEventArgs e)
        {
            Listing3.Visibility = Visibility.Visible;
            ReimplementTop(sender);
        }

        private void MouseOut3(object sender, MouseEventArgs e)
        {
            Listing3.Visibility = Visibility.Hidden;
        }

        private void MouseOverPin4(object sender, MouseEventArgs e)
        {
            Listing4.Visibility = Visibility.Visible;
            ReimplementTop(sender);
        }

        private void MouseOut4(object sender, MouseEventArgs e)
        {
            Listing4.Visibility = Visibility.Hidden;
        }

        private void MouseOverPin5(object sender, MouseEventArgs e)
        {
            Listing5.Visibility = Visibility.Visible;
            ReimplementTop(sender);
        }

        private void MouseOut5(object sender, MouseEventArgs e)
        {
            Listing5.Visibility = Visibility.Hidden;
        }

        private void MouseOverPin6(object sender, MouseEventArgs e)
        {
            Listing6.Visibility = Visibility.Visible;
            ReimplementTop(sender);
        }

        private void MouseOut6(object sender, MouseEventArgs e)
        {
            Listing6.Visibility = Visibility.Hidden;
        }

        private void MouseOverPin7(object sender, MouseEventArgs e)
        {
            Listing7.Visibility = Visibility.Visible;
            ReimplementTop(sender);
        }

        private void MouseOut7(object sender, MouseEventArgs e)
        {
            Listing7.Visibility = Visibility.Hidden;
        }

        private void MouseOverPin8(object sender, MouseEventArgs e)
        {
            Listing8.Visibility = Visibility.Visible;
            ReimplementTop(sender);
        }

        private void MouseOut8(object sender, MouseEventArgs e)
        {
            Listing8.Visibility = Visibility.Hidden;
        }

        private void MouseOverPin9(object sender, MouseEventArgs e)
        {
            Listing9.Visibility = Visibility.Visible;
            ReimplementTop(sender);
        }

        private void MouseOut9(object sender, MouseEventArgs e)
        {
            Listing9.Visibility = Visibility.Hidden;
        }

        private void expandListing(object sender, MouseButtonEventArgs e)
        {
            var currentListing = (sender as Rectangle).Parent;
            Console.WriteLine(currentListing);
            int numOfListing = Int16.Parse(currentListing.GetType().GetProperty("Name").GetValue(currentListing).ToString().Substring(7)) - 1;
            GlobalState.currentIndex = numOfListing;
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
        }

        private void expandListingBorder(object sender, MouseButtonEventArgs e)
        {
            var currentListing = (sender as Border).Parent;
            int numOfListing = Int16.Parse(currentListing.GetType().GetProperty("Name").GetValue(currentListing).ToString().Substring(7)) - 1;
            GlobalState.currentIndex = numOfListing;
            JeremyWindow3 pNext = new JeremyWindow3();
            this.NavigationService.Navigate(pNext);
        }

        /*private void ChangeFavorite(object sender, MouseButtonEventArgs e)
        {
            int numOfListing = Int16.Parse(sender.GetType().GetProperty("Name").GetValue(sender).ToString().Substring(5)) - 1;
            GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited = !GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited;

            var heartImg = (sender as Image);
            heartImg.Source = GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));
        }*/

        private void ChangeFavorite(object sender, MouseButtonEventArgs e)
        {
            if (GlobalState.isLoggedIn)
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

        private void Btn_Hamptons(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/MapView-FullyZoomed/MapViewHamptons.xaml", UriKind.Relative));
        }

        private void MouseOverHamptons(object sender, MouseEventArgs e)
        {
            Hamptons.Opacity = 1;
        }

        private void MouseOutHamptons(object sender, MouseEventArgs e)
        {
            Hamptons.Opacity = 0;
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
        /*
                private void navLogInButton_Click(object sender, RoutedEventArgs e)
                {
                    this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
                }

                private void signUpButton_Click(object sender, RoutedEventArgs e)
                {
                    this.NavigationService.Navigate(new Uri("SignupView.xaml", UriKind.Relative));
                }
        */
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

                GlobalState.isOpen = true;

            }
            else
            {

                FilterPanel.Visibility = Visibility.Collapsed;

                GlobalState.isOpen = false;
            }
        }

        private void FillList()
        {
            if (GlobalState.isOpen)
            {
                FilterPanel.Visibility = Visibility.Visible;

            }
            else
            {
                FilterPanel.Visibility = Visibility.Collapsed;

            }

            if (GlobalState.isLoggedIn)
            {
                profileButton.Visibility = Visibility.Visible;
            }

            if (!GlobalState.isTypeExpanded)
            {
                dropdown_btn_image.Source = new BitmapImage(new Uri("sortdown_icon.png", UriKind.RelativeOrAbsolute));
                HomeTypesSelect.Visibility = Visibility.Collapsed;
            }
            else
            {
                dropdown_btn_image.Source = new BitmapImage(new Uri("sortup_icon.png", UriKind.RelativeOrAbsolute));
                HomeTypesSelect.Visibility = Visibility.Visible;
            }

            switch (GlobalState.paramType)
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
            if (AmenitiesInput.Text != null && !GlobalState.paramAmenities.Contains(AmenitiesInput.Text) && GlobalState.paramAmenities.Count() < 5 && AmenitiesInput.Text.Count() > 0)
            {
                GlobalState.paramAmenities.Add(AmenitiesInput.Text);
                AmenitiesInput.Text = "";
                Print_Amenity();
                GlobalState.Generate(9);

            }
        }

        private void DeleteAmenity(object sender, MouseButtonEventArgs e)
        {
            var lbl = sender as Label;

            GlobalState.paramAmenities.Remove(lbl.Content.ToString().Substring(2));
            Print_Amenity();
            GlobalState.Generate(9);

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
                GlobalState.Generate(9);

            }
        }

        private void DeleteNeighbour(object sender, MouseButtonEventArgs e)
        {
            var lbl = sender as Label;
            GlobalState.paramNeighbourhood.Remove(lbl.Content.ToString().Substring(2));
            Print_Neighbourhood();
            GlobalState.Generate(9);

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
                    GlobalState.Generate(9);

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
            if (!isOnAccount)
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
    }
}
