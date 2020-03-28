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
using CowboyCafe.Data;//added 3.25
using CowboyCafe.ExtensionMethods;//added 3.27
//using CowboyCafe.Data;//added 3.11
//using CowboyCafe.ExtensionMethods;//added 3.11



namespace PointOfSale//was PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// removes the specified item from the list when clicked
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">the event args</param>
        public void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CowboyCafe.Data.IOrderItem temp = (CowboyCafe.Data.IOrderItem)ListOne.SelectedItem;
                order.Remove(temp);
            }
                
        }

        /// <summary>
        /// brings up the same instance that was first used to create the item.
        /// (thus an item can be edited)
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">the event args</param>
        public void Test(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            var cow = new CowpokeChili();
                            var cowCust = new CustomizeCowpokeChili();
                            cowCust.DataContext = cow;
                            order.Remove(cow);
                            orderControl.SwapScreen(cowCust);
                            break;
                    }
                }
            }
            
        }
    }
}
