﻿/* 
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
        //private OrderControl orderControl;//############## might need this
        Order first; //moved to menu selection control
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            first = new Order();
            //set data context
            DataContext = first;


            //entrees:
            AddTrailBurgerButton.Click += AddTrailBurgerButton_Click;
            AddCowpokeChili.Click += AddCowpokeChili_Click;
            AddRustlersRibs.Click += AddRustlersRibs_Click;
            AddPecosPulledPork.Click += AddPecosPulledPork_Click;
            AddDakotaDoubleBurger.Click += AddDakotaDoubleBurger_Click;
            AddTexasTripleBurger.Click += AddTexasTripleBurger_Click;
            AddAngryChickenButton.Click += AddAngryChickenButton_Click;
            //sides:
            AddChiliCheeseFries.Click += AddChiliCheeseFries_Click;
            AddCornDodgers.Click += AddCornDodgers_Click;
            AddPanDeCampo.Click += AddPanDeCampo_Click;
            AddBakedBeans.Click += AddBakedBeans_Click;
            //drinks:
            AddJerkedSoda.Click += AddJerkedSoda_Click;
            AddTexasTea.Click += AddTexasTea_Click;
            AddCowboyCoffee.Click += AddCowboyCoffee_Click;
            AddWater.Click += AddWater_Click;
            //AddCowpokeChili.Click += AddItemAndOpenCustomizationScreen;
        }

        public void SwapScreen(UIElement element)
        {
            //Container.Child = element;
        }

        /*
        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            //first.Add(new CowpokeChili());

        }*/

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
        }



        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new Water());
        }

        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new CowboyCoffee());
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new TexasTea());
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new JerkedSoda());
        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new BakedBeans());
        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new PanDeCampo());
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new CornDodgers());
        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new ChiliCheeseFries());
        }

        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new AngryChicken());
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new TexasTripleBurger());
        }

        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new DakotaDoubleBurger());
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new PecosPulledPork());
        }

        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new RustlersRibs());
        }

        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)//object is where the event came from, event arg is like the parameter for the obj
        {
            first.Add(new TrailBurger());
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            first.Add(new CowpokeChili());

        }
    }
}
