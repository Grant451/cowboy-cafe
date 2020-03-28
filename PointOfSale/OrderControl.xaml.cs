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
using CowboyCafe.ExtensionMethods;

//order selection buttons

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        Order first;
        public OrderControl()
        {
            InitializeComponent();
            first = new Order();
            //set data context
            DataContext = first;

            //order creation/deletion buttions:
            ItemSelection.Click += ItemSelection_Click;
            CancelOrder.Click += CancelOrder_Click;
            CompleteOrder.Click += CompleteOrder_Click;

        }

        
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        /// <summary>
        /// switch the screen back to menuitemselection when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

           
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            Container.Child = new MenuItemSelectionControl();//assuming a new order is going to be created after cancel
        }

        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            Container.Child = new MenuItemSelectionControl();//assuming a new order is going to be created after complete
        }


    }
}
