/* 
 * Author: Grant Clothier
 * Class: MenuItemSelectionControl.xaml.cs
 * Purpose: used to display options to make, select, and complete an order
 * 2.28.2020
 */
using System;
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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            //buttons:
            ItemSelection.Click += ItemSelection_Click;
            CancelOrder.Click += CancelOrder_Click;
            CompleteOrder.Click += CompleteOrder_Click;
        }

        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            //first.Add(new CowpokeChili());
            
        }

        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
    }
}
