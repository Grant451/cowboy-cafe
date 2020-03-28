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

                var temp = ListOne.SelectedItem.ToString();


                switch (temp)
                {
                    case "Cowpoke Chili":
                        var cow = (CustomizeCowpokeCili)ListOne.SelectedItem;//was (CowboyCafe.Data.CustomizeCowpokeCili)ListOne.SelectedItem;
                        var cowCust = new CustomizeCowpokeChili();
                        cowCust.DataContext = cow;
                        orderControl.SwapScreen(cowCust);
                        break;
                    case "Angry Chicken":
                        var chicken = (AngryChicken)ListOne.SelectedItem;
                        var chickenCust = new CustomizeAngryChicken();
                        chickenCust.DataContext = chicken;
                        orderControl.SwapScreen(chickenCust);
                        break;
                    case "Trail Burger":
                        var trailBurger = (TrailBurger)ListOne.SelectedItem;
                        var trailBurgerCust = new CustomizeTrailburger();
                        trailBurgerCust.DataContext = trailBurger;
                        orderControl.SwapScreen(trailBurgerCust);
                        break;
                    //rustlers ribs does not take customizations
                    case "Pecos Pulled Pork":
                        var pecosPulledPork = (PecosPulledPork)ListOne.SelectedItem;
                        var pecosPulledPorkCust = new CustomizePecosPulledPork();
                        pecosPulledPorkCust.DataContext = pecosPulledPork;
                        orderControl.SwapScreen(pecosPulledPorkCust);
                        break;
                    case "Dakota Double Burger":
                        var dakotaDoubleBurger = (DakotaDoubleBurger)ListOne.SelectedItem;
                        var dakotaDoubleBurgerCust = new CustomizeDakotaDoubleBurger();
                        dakotaDoubleBurgerCust.DataContext = dakotaDoubleBurger;
                        orderControl.SwapScreen(dakotaDoubleBurgerCust);
                        break;
                    case "Texas Triple Burger":
                        var texasTripleBurger = (TexasTripleBurger)ListOne.SelectedItem;
                        var texasTripleBurgerCust = new CustomizeTexasTripleBurger();
                        texasTripleBurgerCust.DataContext = texasTripleBurger;
                        orderControl.SwapScreen(texasTripleBurgerCust);
                        break;
                }
                if(ListOne.SelectedItem.ToString().Contains("Chili Cheese Fries"))
                {
                    var chiliCheeseFries = (ChiliCheeseFries)ListOne.SelectedItem;
                    var chiliCheeseFriesCust = new CustomizeChiliCheeseFries();
                    chiliCheeseFriesCust.DataContext = chiliCheeseFries;
                    orderControl.SwapScreen(chiliCheeseFriesCust);
                }
                if(temp.Contains("Corn Dodgers"))
                {
                    var cornDodgers = (CornDodgers)ListOne.SelectedItem;
                    var cornDodgersCust = new CustomizeCornDodgers();
                    cornDodgersCust.DataContext = cornDodgers;
                    orderControl.SwapScreen(cornDodgersCust);
                }
                else if (temp.Contains("Pan de Campo"))
                {
                    var panDeCampo = (PanDeCampo)ListOne.SelectedItem;
                    var panDeCampoCust = new CustomizePanDeCampo();
                    panDeCampoCust.DataContext = panDeCampo;
                    orderControl.SwapScreen(panDeCampoCust);
                }
                else if (temp.Contains("Baked Beans"))
                {
                    var bakedBeans = (BakedBeans)ListOne.SelectedItem;
                    var bakedBeansCust = new CustomizeBakedBeans();
                    bakedBeansCust.DataContext = bakedBeans;
                    orderControl.SwapScreen(bakedBeansCust);
                }
                //drinks:
                else if (temp.Contains("Jerked Soda"))
                {
                    var jerkedSoda = (JerkedSoda)ListOne.SelectedItem;
                    var jerkedSodaCust = new CustomizeJerkedSoda();
                    jerkedSodaCust.DataContext = jerkedSoda;
                    orderControl.SwapScreen(jerkedSodaCust);
                }
                else if (temp.Contains("Tea"))
                {
                    var tea = (TexasTea)ListOne.SelectedItem;
                    var teaCust = new CustomizeTexasTea();
                    teaCust.DataContext = tea;
                    orderControl.SwapScreen(teaCust);
                }
                else if (temp.Contains("Cowboy Coffee"))
                {
                    var cowboyCoffee = (CowboyCoffee)ListOne.SelectedItem;
                    var cowboyCoffeeCust = new CustomizeCowboyCoffee();
                    cowboyCoffeeCust.DataContext = cowboyCoffee;
                    orderControl.SwapScreen(cowboyCoffeeCust);
                }
                else if (temp.Contains("Water"))
                {
                    var water = (Water)ListOne.SelectedItem;
                    var waterCust = new CustomizeWater();
                    waterCust.DataContext = water;
                    orderControl.SwapScreen(waterCust);
                }
            }
            
        }
        
    }
}
