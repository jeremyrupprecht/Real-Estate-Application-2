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
    /// Interaction logic for FilterPage.xaml
    /// </summary>
    public partial class FilterPage : Page
    {
        private bool homeOpen = true;
        private bool amenOpen = false;
        private bool neighOpen = false;
        private bool filterOpen = true;

        public FilterPage()
        {
            InitializeComponent();
        }


        private void btn_HomePage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        private void toggleTypes(object sender, RoutedEventArgs e)
        {
            if(homeOpen)
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
                FilterPanel.Visibility = Visibility.Collapsed;
            else
                FilterPanel.Visibility = Visibility.Visible;
            filterOpen = !filterOpen;
        }
    }
}
