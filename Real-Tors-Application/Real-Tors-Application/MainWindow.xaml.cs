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
    /// Do not add any elements here!!!!! Create a new page and add your work there
    /// I added a dock panel frame thingy that acts as a place holder for pages in the xaml file
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {

            InitializeComponent();
            string[] linesOfCSV = System.IO.File.ReadAllLines("../../resources/1000_listings.csv");
            foreach(string line in linesOfCSV) {
                string[] data = line.Split(',');
                GlobalState.totalList.Add(new Listing(data[0], data[1], Convert.ToInt32(data[2]), Convert.ToInt32(data[3]), 
                    Convert.ToInt32(data[4]), Convert.ToInt32(data[5]), Convert.ToInt32(data[6]), Convert.ToInt32(data[7]), 
                    Convert.ToInt32(data[8]), Convert.ToInt32(data[9])));
            }


            _NavigationFrame.Navigate(new HomePage()); // First page thats displayed on program start
        }


    }
}