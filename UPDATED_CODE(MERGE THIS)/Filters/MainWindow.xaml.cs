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
using System.Windows.Threading;

namespace Filters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;

        int panelWidth;
        bool hidden;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 10);
            timer.Tick += Timer_Tick;

            panelWidth = (int)sidePanel.Width;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width += 1;
                if (sidePanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                }
            }
            else
            {
                sidePanel.Width -= 1;
                if (sidePanel.Width <= 30)
                {
                    timer.Stop();
                    hidden = true;
                }
            }
        }

        private void Collapse_Click(object sender, RoutedEventArgs e)
        {

            timer.Start();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        List<string> inputList = new List<string>();

        private void Add_Click(object sender, RoutedEventArgs e)
        {



            string addedinput = AmenitiesInput.Text; //saves the user's input as a string

            inputList.Add(addedinput); //adds the amenity the user wants into inputList



            Print_Amenity(inputList);

            //      AmenitiesInput -> User input from TextBox
            //      amenity        -> Label (the empty row underneath the "Add" button)


        }
        private void Print_Amenity(List<string> inputList)
        {

            string s = "Selected: ";
            for (int i = 0; i < inputList.Count; i++)
            {

                if (i > 0)
                {



                    s += inputList[i];
                    s += ",";

                    amenity.Content = " " + s + " ";
                }
            }
        }


        List<String> NeighbourhoodList = new List<String>();

        private void Neighbourhood_Click(object sender, RoutedEventArgs e)
        {
            string addedInput1 = NeighbourhoodInput.Text;

            NeighbourhoodList.Add(addedInput1);

            Print_Neighbourhood(NeighbourhoodList);
        }

        private void Print_Neighbourhood(List<string> NeighbourhoodList)
        {
            string n = "Selected: ";

            for (int i = 0; i < NeighbourhoodList.Count; i++)
            {
                if (i > 0)
                {

                    n += NeighbourhoodList[i];
                    n += ",";

                    neighbourhood.Content = " " + n + " ";
                }


            }

        }
    }
}
