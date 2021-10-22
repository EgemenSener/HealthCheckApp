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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            FirstWindow objFirstWindow = new FirstWindow(); 
            this.Visibility = Visibility.Hidden;            //It provides hidden main window
            objFirstWindow.Show();                          //It provides open first window 
        }

        private void OpenWindow1(object sender, RoutedEventArgs e)
        {
            SecondWindow objSecondWindow = new SecondWindow(); 
            this.Visibility = Visibility.Hidden;               //It provides hidden main window
            objSecondWindow.Show();                            //It provides open second window
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();                     //It provides close application
        }
    }
}
