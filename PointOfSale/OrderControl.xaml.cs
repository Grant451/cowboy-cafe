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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            //AddTrailBurgerButton.Height = 90;

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

        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new Water());
        }

        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new CowboyCoffee());
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new TexasTea());
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new JerkedSoda());
        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new BakedBeans());
        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new PanDeCampo());
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new CornDodgers());
        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new ChiliCheeseFries());
        }

        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new AngryChicken());
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new TexasTripleBurger());
        }

        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new DakotaDoubleBurger());
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new PecosPulledPork());
        }

        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new RustlersRibs());
        }

        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)//object is where the event came from, event arg is like the parameter for the obj
        {
            OrderDisplay.Items.Add(new TrailBurger());
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            OrderDisplay.Items.Add(new CowpokeChili());
        }

        
    }
}
