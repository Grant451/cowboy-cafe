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
            //ListOne.SelectionChanged += OnRemoveItem;
            //ListOne.SelectionChanged += EditItem;
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
                //CowboyCafe.Data.IOrderItem temp = (CowboyCafe.Data.IOrderItem)ListOne.SelectedItem;//stoped working
                CowboyCafe.Data.CustomizeCowpokeCili temp = (CowboyCafe.Data.CustomizeCowpokeCili)ListOne.SelectedItem;
                order.Remove(temp);
            }
        }

        
        /// <summary>
        /// brings up the same instance that was first used to create the item.
        /// (thus an item can be edited)
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">the event args</param>
        public void EditItem(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                help.Text = ListOne.SelectedItem.ToString();


                
                switch(ListOne.SelectedItem.ToString())
                {
                    case "Cowpoke Chili":
                        var cow = (CustomizeCowpokeCili)ListOne.SelectedItem;//was (CowboyCafe.Data.CustomizeCowpokeCili)ListOne.SelectedItem;
                        var cowCust = new CustomizeCowpokeChili();
                        cowCust.DataContext = cow;
                        orderControl.SwapScreen(cowCust);
                        break;
                    case "Angry Chicken":
                        var chicken = (CustomizeCowpokeCili)ListOne.SelectedItem;
                        var chickenCust = new CustomizeAngryChicken();
                        chickenCust.DataContext = chicken;
                        orderControl.SwapScreen(chickenCust);
                        break;
                }
                
            }
            
        }
        
    }
}
