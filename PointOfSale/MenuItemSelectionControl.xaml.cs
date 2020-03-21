/* 
 * Author: Grant Clothier
 * Class: MenuItemSelectionControl.xaml.cs
 * Purpose: used to display options to make, select, and complete an order
 * 2.28.2020
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

//entree and side buttons
namespace PointOfSale//CowboyCafe.PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            //set data context

            //entrees:
            AddCowpokeChili.Click += itemAddTest;
            AddTrailBurgerButton.Click += itemAddTest;
            AddRustlersRibs.Click += itemAddTest;
            AddPecosPulledPork.Click += itemAddTest;
            AddDakotaDoubleBurger.Click += itemAddTest;
            AddTexasTripleBurger.Click += itemAddTest;
            AddAngryChickenButton.Click += itemAddTest;
            //sides:
            AddChiliCheeseFries.Click += itemAddTest;
            AddCornDodgers.Click += itemAddTest;
            AddPanDeCampo.Click += itemAddTest;
            AddBakedBeans.Click += itemAddTest;
            //drinks:
            AddJerkedSoda.Click += itemAddTest;
            AddTexasTea.Click += itemAddTest;
            AddCowboyCoffee.Click += itemAddTest;
            AddWater.Click += itemAddTest;

            
        }

        
        /// <summary>
        /// handles the buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void itemAddTest(object sender, RoutedEventArgs e)
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
                            order.Add(cow);
                            orderControl.SwapScreen(cowCust);
                            break;
                        case "AngryChicken":
                            var chicken = new AngryChicken();
                            var chickenCust = new CustomizeAngryChicken();
                            chickenCust.DataContext = chicken;
                            order.Add(chicken);
                            orderControl.SwapScreen(chickenCust);
                            break;
                        case "TrailBurger":
                            order.Add(new TrailBurger());
                            orderControl.SwapScreen(new CustomizeTrailburger());
                            break;
                        //RustlersRibs does not take a customization
                        case "PecosPulledPork":
                            order.Add(new PecosPulledPork());
                            orderControl.SwapScreen(new CustomizePecosPulledPork());
                            break;
                        case "DakotaDoubleBurger":
                            order.Add(new DakotaDoubleBurger());
                            orderControl.SwapScreen(new CustomizeDakotaDoubleBurger());
                            break;
                        case "TexasTripleBurger":
                            order.Add(new TexasTripleBurger());
                            orderControl.SwapScreen(new CustomizeTexasTripleBurger());
                            break;
                        case "ChiliCheeseFries":
                            order.Add(new ChiliCheeseFries());
                            orderControl.SwapScreen(new CustomizeSide());
                            break;
                        case "CornDodgers":
                            order.Add(new CornDodgers());
                            orderControl.SwapScreen(new CustomizeSide());
                            break;
                        case "PanDeCampo":
                            order.Add(new PanDeCampo());
                            orderControl.SwapScreen(new CustomizeSide());
                            break;
                        case "BakedBeans":
                            order.Add(new BakedBeans());
                            orderControl.SwapScreen(new CustomizeSide());
                            break;
                        case "JerkedSoda":
                            order.Add(new JerkedSoda());
                            orderControl.SwapScreen(new CustomizeJerkedSoda());
                            break;
                        case "TexasTea":
                            order.Add(new TexasTea());
                            orderControl.SwapScreen(new CustomizeTexasTea());
                            break;
                        case "CowboyCoffee":
                            order.Add(new CowboyCoffee());
                            orderControl.SwapScreen(new CustomizeCowboyCoffee());
                            break;
                        case "Water":
                            order.Add(new Water());
                            orderControl.SwapScreen(new CustomizeWater());
                            break;
                    }
                }
            }
        }

        /*
        //this stays
        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if(order == null) throw new Exception("DataContext expected to be an Order instance");

            if(screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor of ordercontrol...");

                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }

            order.Add(item);
        }*/


        
    }
}
