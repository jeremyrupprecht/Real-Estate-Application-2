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
    /// Interaction logic for MapViewUnZoomed.xaml
    /// </summary>
    public partial class MapViewUnZoomed : Page
    {

        public MapViewUnZoomed()
        {
            InitializeComponent();
            SetMapValues();
        }

        private void SetMapValues()
        {
            GlobalState.setPerNeighbourhood("Citadel");
            GlobalState.setPerNeighbourhood("Edgemont");
            GlobalState.setPerNeighbourhood("Hamptons");
            GlobalState.setPerNeighbourhood("Hawkwood");
            GlobalState.setPerNeighbourhood("Simons Valley");

            NorthWest.Content = GlobalState.perNeighbourhood["Citadel"] + GlobalState.perNeighbourhood["Edgemont"] + GlobalState.perNeighbourhood["Hamptons"] + GlobalState.perNeighbourhood["Hawkwood"] +
                GlobalState.perNeighbourhood["Simons Valley"] + 500;
        
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

        private void Btn_Map_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MapViewHovered.xaml", UriKind.Relative));
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

        private void clickNorthWest(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MapViewNorthWest.xaml", UriKind.Relative));
        }
    }
}
