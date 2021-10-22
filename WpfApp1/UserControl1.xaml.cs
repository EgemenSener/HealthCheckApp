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
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        double height;
        double weight;


        public UserControl1()
        {
            InitializeComponent();
        }
        // Please use "," during calculation.Otherwise, it will be a wrong calculation.
        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
            
            double Result = (((weight)) / (height * height) );

            BMI_Text_Box.Text = Result.ToString();

            if ( Result >= 18.5)
            {
                if(Result <= 25)
                {
                    BMI_Text_Box.Background = Brushes.Green;


                }
                else
                {
                    BMI_Text_Box.Background = Brushes.Red;
                }
            }
            else
            {
                BMI_Text_Box.Background = Brushes.Red;
                
            }
            Result = 0;
                

        }

        private void BMI_Text_Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Height_Text_Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            height = Convert.ToDouble(Height_Text_Box.Text);

        }

        private void Weight_Text_Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            weight = Convert.ToDouble(Weight_Text_Box.Text);
        }
             

        private void BMI_Text_Box_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
