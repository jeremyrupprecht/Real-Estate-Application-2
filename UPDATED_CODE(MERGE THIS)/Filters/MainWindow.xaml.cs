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
                if(sidePanel.Width >= panelWidth)
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
       

        
        private void Add_Click(object sender, RoutedEventArgs e)
        {

            List<string> inputList = new List<string>();
            
                

                for (int i = 0; i < 5; i++)
                {
                    string addedinput = AmenitiesInput.Text; //saves the user's input as a string

                    inputList.Add(addedinput); //adds the amenity the user wants into inputList


                    //Process:

                    //User enters a string input: Works
                    //Input is saved as a variable: Works
                    //Variable is added to list: Works
                    //The variable is displayed: Works
                    //The process saves the previous input and displays another one next to it: Does not work

                    if (inputList != null)
                {
                    amenity.Content = inputList[i]; //displays 
                }
                    
                }

            

            // Console.WriteLine(amenity.Content = inputList[i]); //print out all the inputs entered 


            //      AmenitiesInput -> User input from TextBox
            //      amenity        -> Label (the empty row underneath the "Add" button)




        }
    }
}
