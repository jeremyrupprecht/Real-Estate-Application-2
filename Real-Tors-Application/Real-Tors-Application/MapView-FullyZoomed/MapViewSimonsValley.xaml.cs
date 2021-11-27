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

        private void ChangeFavorite(object sender, MouseButtonEventArgs e)
        {
            int numOfListing = Int16.Parse(sender.GetType().GetProperty("Name").GetValue(sender).ToString().Substring(5)) - 1;
            GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited = !GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited;

            var heartImg = (sender as Image);
            heartImg.Source = GlobalState.totalList[GlobalState.currentList[numOfListing]].Favorited ? new BitmapImage(new Uri(@"../HeartIconFilled.png", UriKind.Relative)) : new BitmapImage(new Uri(@"../HeartIconEmpty.png", UriKind.Relative));
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
    }
}
