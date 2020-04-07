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
        public TransactionControl()
        {
            InitializeComponent();
            //GetSubtotal();
            FinalPriceDisp.Text = FinalPrice.ToString();
            //the buttons on the form:
            CancelTransaction.Click += OnCancelTransaction;
            PayByCash.Click += OnPayByCash;
            PayByCredit.Click += OnPayByCredit;
        }

        public double FinalPrice = 19.2;

        /*
        public void GetSubtotal(object sender, RoutedEventArgs e)
        {

        }
        */

        void OnPayByCredit(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var Card = new CardTerminal();
            var result = Card.ProcessTransaction(FinalPrice).ToString();
            if(result == "Success")
            {
                //print the receipt
                var receipt = new ReceiptPrinter();
                //receipt.Print();

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
            var receipt = new ReceiptPrinter();
            //receipt.Print(orderControl);

            /*
            //start a new order:
            orderControl.ChangeMode(new OrderSummaryControl());
            orderControl.SwapScreen(new MenuItemSelectionControl());
            */
        }

        void OnCancelTransaction(object sender, RoutedEventArgs e)
        {
            //FinalizationArea.Child = new OrderSummaryControl();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.ChangeMode(new OrderSummaryControl());
            orderControl.SwapScreen(new MenuItemSelectionControl());
        }

        

    }
}
