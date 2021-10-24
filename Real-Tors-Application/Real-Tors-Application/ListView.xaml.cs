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

        public ListView()
        {
            InitializeComponent();
            GenerateListings();
        }

        private void btn_HomePage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
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

            Neighbourhood6.Content = ListOfListings[6].Neighbourhood;
            PriceNum6.Content = "$" + ListOfListings[6].Price;
            BedNumber6.Content = ListOfListings[6].BedNum;
            BathNumber6.Content = ListOfListings[6].BathNum;

            Neighbourhood7.Content = ListOfListings[7].Neighbourhood;
            PriceNum7.Content = "$" + ListOfListings[7].Price;
            BedNumber7.Content = ListOfListings[7].BedNum;
            BathNumber7.Content = ListOfListings[7].BathNum;

            Neighbourhood8.Content = ListOfListings[8].Neighbourhood;
            PriceNum8.Content = "$" + ListOfListings[8].Price;
            BedNumber8.Content = ListOfListings[8].BedNum;
            BathNumber8.Content = ListOfListings[8].BathNum;

            //}

        }

    }
}

