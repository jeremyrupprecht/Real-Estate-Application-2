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
            list1 = new Listing(rand);
            ShowMainListing();
            GenerateListings();


        }

        // button listener to go back to home page
        private void btn_HomePage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        private void btn_saveForLater_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_contractRealtor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_amenities_Click(object sender, RoutedEventArgs e)
        {

        }


        public void ShowMainListing()
        {
            Address.Content = list1.Address;
            PriceNumber.Content = "$" + list1.Price;
            Neighbourhood.Content = list1.Neighbourhood;
            DescriptionText.Text = list1.Description;
            BedNumber.Content = list1.BedNum;
            BathNumber.Content = list1.BathNum;

            /*
            Address.Content = list1.Address;
            Description.Content = list1.Description;
            PriceNum.Content = "$" + list1.Price;
            BedNumber.Content = list1.BedNum;
            BathNumber.Content = list1.BathNum;
            Amenities.Conent = list1.Amenities;
            NumOfImg = list1.NumofImg
            */
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

            Neighbourhood1.Content = ListOfListings[1].Neighbourhood;
            PriceNum1.Content = "$" + ListOfListings[1].Price;
            BedNumber1.Content = ListOfListings[1].BedNum;
            BathNumber1.Content = ListOfListings[1].BathNum;

            Neighbourhood2.Content = ListOfListings[2].Neighbourhood;
            PriceNum2.Content = "$" + ListOfListings[2].Price;
            BedNumber2.Content = ListOfListings[2].BedNum;
            BathNumber2.Content = ListOfListings[2].BathNum;

            Neighbourhood3.Content = ListOfListings[3].Neighbourhood;
            PriceNum3.Content = "$" + ListOfListings[3].Price;
            BedNumber3.Content = ListOfListings[3].BedNum;
            BathNumber3.Content = ListOfListings[3].BathNum;

            Neighbourhood4.Content = ListOfListings[4].Neighbourhood;
            PriceNum4.Content = "$" + ListOfListings[4].Price;
            BedNumber4.Content = ListOfListings[4].BedNum;
            BathNumber4.Content = ListOfListings[4].BathNum;

            Neighbourhood5.Content = ListOfListings[5].Neighbourhood;
            PriceNum5.Content = "$" + ListOfListings[5].Price;
            BedNumber5.Content = ListOfListings[5].BedNum;
            BathNumber5.Content = ListOfListings[5].BathNum;


        }

    }
}
