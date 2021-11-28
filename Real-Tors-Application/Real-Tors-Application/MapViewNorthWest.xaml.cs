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
    /// Interaction logic for MapViewNorthWest.xaml
    /// </summary>
    public partial class MapViewNorthWest : Page
    {

        public MapViewNorthWest()
        {
            InitializeComponent();
            SetMapValues();
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

            LBL_Citadel.Content = GlobalState.perNeighbourhood["Citadel"];
            LBL_Edgemont.Content = GlobalState.perNeighbourhood["Edgemont"];
            LBL_Hamptons.Content = GlobalState.perNeighbourhood["Hamptons"];
            LBL_Hawkwood.Content = GlobalState.perNeighbourhood["Hawkwood"];
            LBL_SimonsValley.Content = GlobalState.perNeighbourhood["Simons Valley"];

            LBL_ArbourLake.Content = GlobalState.perNeighbourhood["Arbour Lake"];
            LBL_Dalhousie.Content = GlobalState.perNeighbourhood["Dalhousie"];
            LBL_NolanHill.Content = GlobalState.perNeighbourhood["Nolan Hill"];
            LBL_Ranchlands.Content = GlobalState.perNeighbourhood["Ranchlands"];
            LBL_RockeyRidge.Content = GlobalState.perNeighbourhood["Rockey Ridge"];
            LBL_RoyalOak.Content = GlobalState.perNeighbourhood["Royal Oak"];
            LBL_RoyalVista.Content = GlobalState.perNeighbourhood["Royal Vista"];
            LBL_SageHill.Content = GlobalState.perNeighbourhood["Sage Hill"];
            LBL_ScenicAcres.Content = GlobalState.perNeighbourhood["Scenic Acres"];
            LBL_SilverSprings.Content = GlobalState.perNeighbourhood["Silver Springs"];
            LBL_Tuscany.Content = GlobalState.perNeighbourhood["Tuscany"];

            SetLabelColor(LBL_Citadel);
            SetLabelColor(LBL_Edgemont);
            SetLabelColor(LBL_Hamptons);
            SetLabelColor(LBL_Hawkwood);
            SetLabelColor(LBL_SimonsValley);

            SetLabelColor(LBL_ArbourLake);
            SetLabelColor(LBL_Dalhousie);
            SetLabelColor(LBL_NolanHill);
            SetLabelColor(LBL_Ranchlands);
            SetLabelColor(LBL_RockeyRidge);
            SetLabelColor(LBL_RoyalOak);
            SetLabelColor(LBL_RoyalVista);
            SetLabelColor(LBL_SageHill);
            SetLabelColor(LBL_ScenicAcres);
            SetLabelColor(LBL_SilverSprings);
            SetLabelColor(LBL_Tuscany);
        }

        private void SetLabelColor(Label label)
        {
            if((int) label.Content <= 50)
            {
                label.Foreground = Brushes.Lime;
            }else if ((int)label.Content <= 60)
            {
                label.Foreground = Brushes.YellowGreen;
            }
            else if ((int)label.Content <= 70)
            {
                label.Foreground = Brushes.OliveDrab;
            }
            else
            {
                label.Foreground = Brushes.DarkGreen;
            }
        }

        private void Btn_Citadel(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/MapView-FullyZoomed/MapViewCitadel.xaml", UriKind.Relative));
        }

        private void MouseOverCitadel(object sender, MouseEventArgs e)
        {
            Citadel.Opacity = 1;
        }

        private void MouseOutCitadel(object sender, MouseEventArgs e)
        {
            Citadel.Opacity = 0;
        }

        private void Btn_Edgemont(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/MapView-FullyZoomed/MapViewEdgemont.xaml", UriKind.Relative));
        }

        private void MouseOverEdgemont(object sender, MouseEventArgs e)
        {
            Edgemont.Opacity = 1;
        }

        private void MouseOutEdgemont(object sender, MouseEventArgs e)
        {
            Edgemont.Opacity = 0;
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

        private void Btn_SimonsValley(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/MapView-FullyZoomed/MapViewSimonsValley.xaml", UriKind.Relative));
        }

        private void MouseOverSimonsValley(object sender, MouseEventArgs e)
        {
            SimonsValley.Opacity = 1;
        }

        private void MouseOutSimonsValley(object sender, MouseEventArgs e)
        {
            SimonsValley.Opacity = 0;
        }

        private void Btn_Hawkwood(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/MapView-FullyZoomed/MapViewHawkwood.xaml", UriKind.Relative));
        }

        private void MouseOverHawkwood(object sender, MouseEventArgs e)
        {
            Hawkwood.Opacity = 1;
        }

        private void MouseOutHawkwood(object sender, MouseEventArgs e)
        {
            Hawkwood.Opacity = 0;
        }

        private void MouseOverArbourLake(object sender, MouseEventArgs e)
        {
            ArbourLake.Opacity = 1;
        }

        private void MouseOutArbourLake(object sender, MouseEventArgs e)
        {
            ArbourLake.Opacity = 0;
        }

        private void MouseOverDalhousie(object sender, MouseEventArgs e)
        {
            Dalhousie.Opacity = 1;
        }

        private void MouseOutDalhousie(object sender, MouseEventArgs e)
        {
            Dalhousie.Opacity = 0;
        }

        private void MouseOverNolanHill(object sender, MouseEventArgs e)
        {
            NolanHill.Opacity = 1;
        }

        private void MouseOutNolanHill(object sender, MouseEventArgs e)
        {
            NolanHill.Opacity = 0;
        }

        private void MouseOverRanchlands(object sender, MouseEventArgs e)
        {
            Ranchlands.Opacity = 1;
        }

        private void MouseOutRanchlands(object sender, MouseEventArgs e)
        {
            Ranchlands.Opacity = 0;
        }

        private void MouseOverRockeyRidge(object sender, MouseEventArgs e)
        {
            RockeyRidge.Opacity = 1;
        }

        private void MouseOutRockeyRidge(object sender, MouseEventArgs e)
        {
            RockeyRidge.Opacity = 0;
        }

        private void MouseOverRoyalOak(object sender, MouseEventArgs e)
        {
            RoyalOak.Opacity = 1;
        }

        private void MouseOutRoyalOak(object sender, MouseEventArgs e)
        {
            RoyalOak.Opacity = 0;
        }

        private void MouseOverRoyalVista(object sender, MouseEventArgs e)
        {
            RoyalVista.Opacity = 1;
        }

        private void MouseOutRoyalVista(object sender, MouseEventArgs e)
        {
            RoyalVista.Opacity = 0;
        }

        private void MouseOverSageHill(object sender, MouseEventArgs e)
        {
            SageHill.Opacity = 1;
        }

        private void MouseOutSageHill(object sender, MouseEventArgs e)
        {
            SageHill.Opacity = 0;
        }

        private void MouseOverScenicAcres(object sender, MouseEventArgs e)
        {
            ScenicAcres.Opacity = 1;
        }

        private void MouseOutScenicAcres(object sender, MouseEventArgs e)
        {
            ScenicAcres.Opacity = 0;
        }

        private void MouseOverSilverSprings(object sender, MouseEventArgs e)
        {
            SilverSprings.Opacity = 1;
        }

        private void MouseOutSilverSprings(object sender, MouseEventArgs e)
        {
            SilverSprings.Opacity = 0;
        }

        private void MouseOverTuscany(object sender, MouseEventArgs e)
        {
            Tuscany.Opacity = 1;
        }

        private void MouseOutTuscany(object sender, MouseEventArgs e)
        {
            Tuscany.Opacity = 0;
        }
    }
}
