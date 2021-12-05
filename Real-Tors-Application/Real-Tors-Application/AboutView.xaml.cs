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
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class AboutView : Page
    {
        public AboutView()
        {
            InitializeComponent();
            profileButtonVisibility();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
        }

        private void teamButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("OurTeamView.xaml", UriKind.Relative));
        }

        private void contactButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ContactUsView.xaml", UriKind.Relative));
        }

        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void profileButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ProfileView.xaml", UriKind.Relative));
        }

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
    }
}
