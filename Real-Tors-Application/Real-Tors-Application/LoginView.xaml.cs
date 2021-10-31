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


        private void logInButton_Click(object sender, RoutedEventArgs e)
        {
            logInGrid.Visibility = Visibility.Hidden;

            //  824,515,315,0
            Thickness margin = homeTypeGrid.Margin;
            margin.Left = 824;
            homeTypeGrid.Margin = margin;

            profileButton.Content = "My Profile";
        }

        private void loginButtonSUCC_Click(object sender, RoutedEventArgs e)
        {
            successSignupGrid.Visibility = Visibility.Hidden;
            logInGrid.Visibility = Visibility.Visible;
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

        private void createAcccountTextButton_Click(object sender, RoutedEventArgs e)
        {
            logInGrid.Visibility = Visibility.Hidden;
            signupGrid.Visibility = Visibility.Visible;
        }

        private void profileButton_Click(object sender, RoutedEventArgs e)
        {
            if((string)profileButton.Content == "My Profile")
            {
                this.NavigationService.Navigate(new Uri("ProfileView.xaml", UriKind.Relative));
            }
        }
    }
}
