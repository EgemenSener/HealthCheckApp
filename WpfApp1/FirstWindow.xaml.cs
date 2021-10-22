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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

       

        private void Back_Menu1_Click(object sender, RoutedEventArgs e) 
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Show();                           //It provides open main window

        }

        private void Visit_Healthy_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow objSecondWindow = new SecondWindow();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();
        }

      
        int count=1;
        private void List_Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Jogging_Checked(object sender, RoutedEventArgs e)  // Count for selected items
        {
            ++count;
        }

        private void Running_Checked(object sender, RoutedEventArgs e)
        {
            ++count;
        }

        private void Swimming_Checked(object sender, RoutedEventArgs e)
        {
            ++count;
        }

        private void Play_Tennis_Checked(object sender, RoutedEventArgs e)
        {
            ++count;
        }

        private void Play_Basketball_Checked(object sender, RoutedEventArgs e)
        {
            ++count;
        }

        private void Jogging_Unchecked(object sender, RoutedEventArgs e) // Delete from count when unselect item
        {
            if(count > 1)
            {
                count--;
            }
            
        }

        private void Running_Unchecked(object sender, RoutedEventArgs e)
        {
            if (count > 1)
            {
                count--;
            }

        }

        private void Swimming_Unchecked(object sender, RoutedEventArgs e)
        {
            if (count > 1)
            {
                count--;
            }

        }

        private void Play_Tennis_Unchecked(object sender, RoutedEventArgs e)
        {
            if (count > 1)
            {
                count--;
            }

        }

        private void Play_Basketball_Unchecked(object sender, RoutedEventArgs e)
        {
            if (count > 1)
            {
                count--;
            }

        }
        private void Result_Click(object sender, RoutedEventArgs e)  // Showing message for Result Button
        {
            if (count > 1)
            {
                ThirdWindow objThirdWindow = new ThirdWindow();
                objThirdWindow.Show();
               

            }
            else
            {
                Fourth objFourthWindow = new Fourth();
                objFourthWindow.Show();

            }

        }
    }
}
