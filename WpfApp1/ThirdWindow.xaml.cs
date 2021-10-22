﻿using System;
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
    /// Interaction logic for ThirdWindow.xaml
    /// </summary>
    public partial class ThirdWindow : Window
    {
        public ThirdWindow()
        {
            InitializeComponent();
        }
        public ThirdWindow(int count): base()
        {
            
            Text_1.Text = "" + count + "activities! Healthy!"; //trying for get data from count and print how many times selected
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            this.Visibility = Visibility.Hidden;
        }

        private void Label_Health_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }
    }
}
