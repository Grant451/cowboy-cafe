﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCowpokeChili.xaml
    /// </summary>
    public partial class CustomizeCowpokeChili : UserControl
    {
        public CustomizeCowpokeChili()
        {
            InitializeComponent();

        }

        /*
        private void EventChanged(object sender, RoutedEventArgs e)
        {
            var temp = this.FindAncestor<OrderControl>();

            if (temp is OrderControl) temp.NotifySpecialInstructions();

        }*/


    }
}
