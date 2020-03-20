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
        Order first; //moved to menu selection control
        public OrderControl()
        {
            InitializeComponent();
            first = new Order();//moved to menu selection control
            //set data context
            DataContext = first;//moved to menu selection control

            //order creation/deletion buttions:
            ItemSelection.Click += ItemSelection_Click;
            CancelOrder.Click += CancelOrder_Click;
            CompleteOrder.Click += CompleteOrder_Click;
            //AddCowpokeChili.Click += AddCowpokeChili_Click;

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



        //taken out 3.13.2020
        /*
        public void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)//***
                    {
                        case "CowpokeChili":
                            order.Add(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;

                    }
                }
            }
        }*/


            /*
            private void ItemSelection_Click(object sender, RoutedEventArgs e)
            {
                //first.Add(new CowpokeChili());
                var orderControl = this.FindAncestor<OrderControl>();
                if (DataContext is Order order)
                {
                    if (sender is Button button)
                    {
                        switch (button.Tag)
                        {
                            case "CowpokeChili":
                                var entree = new CowpokeChili();
                                var screen = new CustomizeCowpokeChili();
                                screen.DataContext = entree;
                                order.Add(entree);
                                orderControl.SwapScreen(new CustomizeCowpokeChili());
                                break;

                        }
                    }
                }

            }*/

            //these go to order control.cs
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }


        public void NotifySpecialInstructions()
        {
            if (DataContext is Order order) order.NotifyChange();

        }



    }
}
