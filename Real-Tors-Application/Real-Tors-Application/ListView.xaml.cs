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

        private bool homeOpen = true;
        private bool amenOpen = false;
        private bool neighOpen = false;
        private bool filterOpen = true;

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
            for(int i = 0; i<9; i++)
            {
                ListOfListings.Add(new Listing(rand));
            }

            for(int i = 0; i<9; i++)
            {
                Console.WriteLine(ListOfListings[i].toString());
            }
            //for(int i = 0; i<2; i++)
            //{
            Neighbourhood0.Content = ListOfListings[0].Neighbourhood;
            PriceNum0.Content = "$" + ListOfListings[0].Price;
            BedNumber0.Content = ListOfListings[0].BedNum;
            BathNumber0.Content = ListOfListings[0].BathNum;
            SizeNumber0.Content = ListOfListings[0].Size + " sq ft";
            HouseImage0.Source = new BitmapImage(new Uri(@"/houseImg" + rand.Next(25) + ".jpg", UriKind.Relative)); 

            Neighbourhood1.Content = ListOfListings[1].Neighbourhood;
            PriceNum1.Content = "$" + ListOfListings[1].Price;
            BedNumber1.Content = ListOfListings[1].BedNum;
            BathNumber1.Content = ListOfListings[1].BathNum;
            SizeNumber1.Content = ListOfListings[1].Size + " sq ft";
            HouseImage1.Source = new BitmapImage(new Uri(@"/houseImg" + rand.Next(25) + ".jpg", UriKind.Relative));

            Neighbourhood2.Content = ListOfListings[2].Neighbourhood;
            PriceNum2.Content = "$" + ListOfListings[2].Price;
            BedNumber2.Content = ListOfListings[2].BedNum;
            BathNumber2.Content = ListOfListings[2].BathNum;
            SizeNumber2.Content = ListOfListings[2].Size + " sq ft";
            HouseImage2.Source = new BitmapImage(new Uri(@"/houseImg" + rand.Next(25) + ".jpg", UriKind.Relative));

            Neighbourhood3.Content = ListOfListings[3].Neighbourhood;
            PriceNum3.Content = "$" + ListOfListings[3].Price;
            BedNumber3.Content = ListOfListings[3].BedNum;
            BathNumber3.Content = ListOfListings[3].BathNum;
            SizeNumber3.Content = ListOfListings[3].Size + " sq ft";
            HouseImage3.Source = new BitmapImage(new Uri(@"/houseImg" + rand.Next(25) + ".jpg", UriKind.Relative));

            Neighbourhood4.Content = ListOfListings[4].Neighbourhood;
            PriceNum4.Content = "$" + ListOfListings[4].Price;
            BedNumber4.Content = ListOfListings[4].BedNum;
            BathNumber4.Content = ListOfListings[4].BathNum;
            SizeNumber4.Content = ListOfListings[4].Size + " sq ft";
            HouseImage4.Source = new BitmapImage(new Uri(@"/houseImg" + rand.Next(25) + ".jpg", UriKind.Relative));

            Neighbourhood5.Content = ListOfListings[5].Neighbourhood;
            PriceNum5.Content = "$" + ListOfListings[5].Price;
            BedNumber5.Content = ListOfListings[5].BedNum;
            BathNumber5.Content = ListOfListings[5].BathNum;
            SizeNumber5.Content = ListOfListings[5].Size + " sq ft";
            HouseImage5.Source = new BitmapImage(new Uri(@"/houseImg" + rand.Next(25) + ".jpg", UriKind.Relative));

            Neighbourhood6.Content = ListOfListings[6].Neighbourhood;
            PriceNum6.Content = "$" + ListOfListings[6].Price;
            BedNumber6.Content = ListOfListings[6].BedNum;
            BathNumber6.Content = ListOfListings[6].BathNum;
            SizeNumber6.Content = ListOfListings[6].Size + " sq ft";
            HouseImage6.Source = new BitmapImage(new Uri(@"/houseImg" + rand.Next(25) + ".jpg", UriKind.Relative));

            Neighbourhood7.Content = ListOfListings[7].Neighbourhood;
            PriceNum7.Content = "$" + ListOfListings[7].Price;
            BedNumber7.Content = ListOfListings[7].BedNum;
            BathNumber7.Content = ListOfListings[7].BathNum;
            SizeNumber7.Content = ListOfListings[7].Size + " sq ft";
            HouseImage7.Source = new BitmapImage(new Uri(@"/houseImg" + rand.Next(25) + ".jpg", UriKind.Relative));

            Neighbourhood8.Content = ListOfListings[8].Neighbourhood;
            PriceNum8.Content = "$" + ListOfListings[8].Price;
            BedNumber8.Content = ListOfListings[8].BedNum;
            BathNumber8.Content = ListOfListings[8].BathNum;
            SizeNumber8.Content = ListOfListings[8].Size + " sq ft";
            HouseImage8.Source = new BitmapImage(new Uri(@"/houseImg" + rand.Next(25) + ".jpg", UriKind.Relative));

            //}

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
            if (homeOpen)
            {
                HomeTypesSelect.Visibility = Visibility.Collapsed;
            }
            else
            {
                HomeTypesSelect.Visibility = Visibility.Visible;
            }
            homeOpen = !homeOpen;
        }

        private void OpenAmenities_Click(object sender, RoutedEventArgs e)
        {
            if (amenOpen)
            {
                AmenTypesSelect.Visibility = Visibility.Collapsed;
            }
            else
            {
                AmenTypesSelect.Visibility = Visibility.Visible;
            }
            amenOpen = !amenOpen;
        }

        private void toggleNeigh(object sender, RoutedEventArgs e)
        {
            if (neighOpen)
            {
                NeighTypesSelect.Visibility = Visibility.Collapsed;
            }
            else
            {
                NeighTypesSelect.Visibility = Visibility.Visible;
            }
            neighOpen = !neighOpen;
        }

        private void ToggleFilter(object sender, RoutedEventArgs e)
        {
            if (filterOpen)
            {
                FilterPanel.Visibility = Visibility.Collapsed;
                listResultsGrid.Width = 1850;
            }
            else
            {
                FilterPanel.Visibility = Visibility.Visible;
                listResultsGrid.Width = 1420;
            }
            filterOpen = !filterOpen;
        }
    }
}

