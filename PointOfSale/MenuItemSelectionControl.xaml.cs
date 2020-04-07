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
                            var trailBurger = new TrailBurger();
                            var trailBurgerCust = new CustomizeTrailburger();
                            trailBurgerCust.DataContext = trailBurger;
                            order.Add(trailBurger);
                            orderControl.SwapScreen(trailBurgerCust);
                            break;
                        //RustlersRibs does not take a customization
                        case "RustlersRibs":
                            order.Add(new RustlersRibs());
                            break;
                        case "PecosPulledPork":
                            var pecosPulledPork = new PecosPulledPork();
                            var pecosPulledPorkCust = new CustomizePecosPulledPork();
                            pecosPulledPorkCust.DataContext = pecosPulledPork;
                            order.Add(pecosPulledPork);
                            orderControl.SwapScreen(pecosPulledPorkCust);
                            break;
                        case "DakotaDoubleBurger":
                            var dakotaDoubleBurger = new DakotaDoubleBurger();
                            var dakotaDoubleBurgerCust = new CustomizeDakotaDoubleBurger();
                            dakotaDoubleBurgerCust.DataContext = dakotaDoubleBurger;
                            order.Add(dakotaDoubleBurger);
                            orderControl.SwapScreen(dakotaDoubleBurgerCust);
                            break;
                        case "TexasTripleBurger":
                            var texasTripleBurger = new TexasTripleBurger();
                            var texasTripleBurgerCust = new CustomizeTexasTripleBurger();
                            texasTripleBurgerCust.DataContext = texasTripleBurger;
                            order.Add(texasTripleBurger);
                            orderControl.SwapScreen(texasTripleBurgerCust);
                            break;
                        //sides:
                        case "ChiliCheeseFries":
                            var chiliCheeseFries = new ChiliCheeseFries();
                            var chiliCheeseFriesCust = new CustomizeChiliCheeseFries();
                            chiliCheeseFriesCust.DataContext = chiliCheeseFries;
                            order.Add(chiliCheeseFries);
                            orderControl.SwapScreen(chiliCheeseFriesCust);
                            break;
                        case "CornDodgers":
                            var cornDodgers = new CornDodgers();
                            var cornDodgersCust = new CustomizeCornDodgers();
                            cornDodgersCust.DataContext = cornDodgers;
                            order.Add(cornDodgers);
                            orderControl.SwapScreen(cornDodgersCust);
                            break;
                        case "PanDeCampo":
                            var panDeCampo = new PanDeCampo();
                            var panDeCampoCust = new CustomizePanDeCampo();
                            panDeCampoCust.DataContext = panDeCampo;
                            order.Add(panDeCampo);
                            orderControl.SwapScreen(panDeCampoCust);
                            break;
                        case "BakedBeans":
                            var bakedBeans = new BakedBeans();
                            var bakedBeansCust = new CustomizeBakedBeans();
                            bakedBeansCust.DataContext = bakedBeans;
                            order.Add(bakedBeans);
                            orderControl.SwapScreen(bakedBeansCust);
                            break;
                        //drinks:
                        case "JerkedSoda":
                            var jerkedSoda = new JerkedSoda();
                            var jerkedSodaCust = new CustomizeJerkedSoda();
                            jerkedSodaCust.DataContext = jerkedSoda;
                            order.Add(jerkedSoda);
                            orderControl.SwapScreen(jerkedSodaCust);
                            break;
                        case "TexasTea":
                            var texasTea = new TexasTea();
                            var texasTeaCust = new CustomizeTexasTea();
                            texasTeaCust.DataContext = texasTea;
                            order.Add(texasTea);
                            orderControl.SwapScreen(texasTeaCust);
                            break;
                        case "CowboyCoffee":
                            var cowboyCoffee = new CowboyCoffee();
                            var cowboyCoffeeCust = new CustomizeCowboyCoffee();
                            cowboyCoffeeCust.DataContext = cowboyCoffee;
                            order.Add(cowboyCoffee);
                            orderControl.SwapScreen(cowboyCoffeeCust);
                            break;
                        case "Water":
                            var water = new Water();
                            var waterCust = new CustomizeWater();
                            waterCust.DataContext = water;
                            order.Add(water);
                            orderControl.SwapScreen(waterCust);
                            break;
                    }
                }
            }
        }

        //used to debug:
        /*
        public void AutoFillItems(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var cow = new CowpokeChili();
                var cowCust = new CustomizeCowpokeChili();
                cowCust.DataContext = cow;
                order.Add(cow);
                orderControl.SwapScreen(cowCust);

                var pecosPulledPork = new PecosPulledPork();
                var pecosPulledPorkCust = new CustomizePecosPulledPork();
                pecosPulledPorkCust.DataContext = pecosPulledPork;
                order.Add(pecosPulledPork);
                orderControl.SwapScreen(pecosPulledPorkCust);

                var jerkedSoda = new JerkedSoda();
                var jerkedSodaCust = new CustomizeJerkedSoda();
                jerkedSodaCust.DataContext = jerkedSoda;
                order.Add(jerkedSoda);
                orderControl.SwapScreen(jerkedSodaCust);

                var second = new CowpokeChili();
                var secondCust = new CustomizeCowpokeChili();
                secondCust.DataContext = second;
                order.Add(second);
                orderControl.SwapScreen(secondCust);
            }

        }
        */


        
    }
}
