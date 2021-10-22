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
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void Show_Page_Button_Click(object sender, RoutedEventArgs e)
        {
           Frame_2.NavigationService.Navigate(new Uri("https://www.google.com/")); //navigate to the page
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Show();


            //SecondWindow main = new SecondWindow();
            //MainWindow.Show();
            //this.Close();

        }
    }
}
