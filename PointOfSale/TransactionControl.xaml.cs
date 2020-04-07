/* 
 * Author: Grant Clothier
 * Class: TransactionControl.xaml.cs
 * Purpose: provide payment control
 * 4.07.2020
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
using CowboyCafe.ExtensionMethods;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl(Order temp)
        {
            InitializeComponent();
            //set the necessary order properties 
            FinalPrice = Math.Round((temp.Subtotal += temp.Subtotal * .16), 2);
            items = temp.Items;
            OrderNumber = temp.OrderNumber;
            Subtotal = temp.Subtotal;

            //GetSubtotal();
            FinalPriceDisp.Text = FinalPrice.ToString();
            //the buttons on the form:
            CancelTransaction.Click += OnCancelTransaction;
            PayByCash.Click += OnPayByCash;
            PayByCredit.Click += OnPayByCredit;
        }

        private double Subtotal;

        public double FinalPrice;

        private uint OrderNumber;

        private IEnumerable<IOrderItem> items;


        /*
        public void setFinalPrice()
        {
            
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var temp = order.Subtotal;
                FinalPrice = temp += temp * .16;
                FinalPriceDisp.Text = FinalPrice.ToString();
            }
            


        }
        */


        void OnPayByCredit(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var Card = new CardTerminal();
            var result = Card.ProcessTransaction(FinalPrice).ToString();
            if(result == "Success")
            {
                //print receipt
                CreateReciept(true, 0, 0);
                //start a new order:
                orderControl.ChangeMode(new OrderSummaryControl());
                orderControl.SwapScreen(new MenuItemSelectionControl());
            }
            else
            {
                FinalPriceDisp.Text = result;
            }
        }

        void OnPayByCash(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            //show the cash drawer and handle those operations:
            orderControl.SwapScreen(new CashRegisterControl());


            //print the receipt
            //CreateReciept();

            //start a new order:
            orderControl.ChangeMode(new OrderSummaryControl());
            orderControl.SwapScreen(new MenuItemSelectionControl());
        }

        void OnCancelTransaction(object sender, RoutedEventArgs e)
        {
            //FinalizationArea.Child = new OrderSummaryControl();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.ChangeMode(new OrderSummaryControl());
            orderControl.SwapScreen(new MenuItemSelectionControl());
        }

        private void CreateReciept(bool credit, double total, double change)
        {
            //print the receipt
            var receipt = new ReceiptPrinter();
            receipt.Print("OrderNumber:");
            receipt.Print(OrderNumber.ToString());

            receipt.Print(DateTime.Now.ToString());

            foreach (IOrderItem x in items)
            {
                receipt.Print(x.ToString());
                foreach (string a in x.SpecialInstructions)
                {
                    receipt.Print(a);
                }
                receipt.Print(x.Price.ToString());
            }
            receipt.Print("Subtotal:");
            receipt.Print(Subtotal.ToString());
            receipt.Print("Total with Tax:");
            receipt.Print(FinalPrice.ToString());
            if(credit)
            {
                receipt.Print("Credit");
            }
            else
            {
                receipt.Print("Total paid:");
                receipt.Print(total.ToString());
                receipt.Print("Change:");
                receipt.Print(change.ToString());
            }
        }

    }
}
