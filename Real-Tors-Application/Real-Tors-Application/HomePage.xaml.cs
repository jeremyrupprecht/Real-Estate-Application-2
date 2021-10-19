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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("TestPage.xaml", UriKind.Relative));
        }

        private void btn_ListView_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ListView.xaml", UriKind.Relative));
        }

        private void btn_TestView_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("TestPage.xaml", UriKind.Relative));
        }

        private void btn_FilterView_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("FilterView.xaml", UriKind.Relative)); 
        }
    }
}
