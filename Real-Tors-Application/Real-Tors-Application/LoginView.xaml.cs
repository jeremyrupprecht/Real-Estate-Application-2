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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void navLogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (logInGrid.Visibility == Visibility.Hidden)
            {

            }
            this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        private void comboItem1Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ListView.xaml", UriKind.Relative));
        }

        private void comboItem2Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ListView.xaml", UriKind.Relative));
        }

        private void comboItem3Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ListView.xaml", UriKind.Relative));
        }

        private void comboItem4Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ListView.xaml", UriKind.Relative));
        }

        private void comboItem5Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ListView.xaml", UriKind.Relative));
        }

        private void comboItem6Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ListView.xaml", UriKind.Relative));
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("SignupView.xaml", UriKind.Relative));
        }

        private void logInButton_Click(object sender, RoutedEventArgs e)
        {
            logInGrid.Visibility = Visibility.Hidden;

            //  824,515,315,0
            Thickness margin = homeTypeGrid.Margin;
            margin.Left = 824;
            homeTypeGrid.Margin = margin;

            navLogInButton.Content = "Profile";
        }
    }
}
