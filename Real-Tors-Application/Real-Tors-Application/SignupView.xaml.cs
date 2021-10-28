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
    /// Interaction logic for SignupView.xaml
    /// </summary>
    public partial class SignupView : Page
    {
        public SignupView()
        {
            InitializeComponent();
            //Grid signupGrid = this.FindName("signupGrid") as Grid;
            //Grid successSignupGrid = this.FindName("successSignupGrid") as Grid;
            //signupGrid.Visibility = Visibility.Visible;
            //successSignupGrid.Visibility = Visibility.Hidden;
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

        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
        }

        private void createAccountButton_Click(object sender, RoutedEventArgs e)
        {
            if (inputValidation())
            {
                Grid signupGrid = this.FindName("signupGrid") as Grid;
                Grid successSignupGrid = this.FindName("successSignupGrid") as Grid;
                signupGrid.Visibility = Visibility.Hidden;
                successSignupGrid.Visibility = Visibility.Visible;
            }
        }

        private bool inputValidation()
        {
            var bc = new BrushConverter();
            bool valid = true;
            // Error Background = "#FFFFB7B7"
            String username = userNameTextBox.Text;
            String password = passwordTextBox.Password;
            String email = emailTextBox.Text;
            // Check username 
            if (username.Equals(""))
            {
                userNameTextBox.Background = (Brush)bc.ConvertFrom("#FFFFB7B7");
                valid = false;
            } 
            else
            {
                userNameTextBox.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            }
            // Check password
            if (password.Equals(""))
            {
                passwordTextBox.Background = (Brush)bc.ConvertFrom("#FFFFB7B7");
                valid = false;
            }
            else
            {
                passwordTextBox.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            }
            // Check email
            if (email.Equals(""))
            {
                emailTextBox.Background = (Brush)bc.ConvertFrom("#FFFFB7B7");
                valid = false;
            }
            else
            {
                emailTextBox.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            }

            return valid;
        }
    }
}
