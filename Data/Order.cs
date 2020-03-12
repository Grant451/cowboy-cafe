/* 
 * Author: Grant Clothier
 * Class: Order.cs
 * Purpose: Represents the data within a given order
 * 2.27.2020
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {

        //Subtotal += items.Price;

        /// <summary>
        /// keeps track of the last order number
        /// </summary>
        private static uint lastOrderNumber = 0;

        
        /// <summary>
        /// a backing list that holds the items in the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();


        public Order()
        {
            lastOrderNumber += 1;
        }


        /// <summary>
        /// enables the INotifyPropertyChanged to be used
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /*
        /// <summary>
        /// IEnumberable of IOrderItem used to access the information in items
        /// </summary>
        public IEnumerable<IOrderItem> Items => items;//PropertyChangedEventHandler();//{ get; }//=> throw new NotImplementedException();
        */

        public IEnumerable<IOrderItem> Items
        {
            get
            { 
                return items.ToArray();
            }
            set { } 
        }

        /// <summary>
        /// the price of the total order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double total = 0;
                foreach (IOrderItem x in items)
                {
                    total += x.Price;
                }
                return total;
            }
            set { }
        }

        /// <summary>
        /// a unique number for each order
        /// </summary>
        public uint OrderNumber { get; set; }

        /// <summary>
        /// adds an item to itmes
        /// </summary>
        /// <param name="item">the backing variable for the order</param>
        public void Add(IOrderItem item) 
        {
            if(item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));//was Items
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderNumber"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));//added 3.11
        }

        /// <summary>
        /// removes an item from items
        /// </summary>
        /// <param name="item">the backing variable for the order</param>
        public void Remove(IOrderItem item) 
        {
            if(item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));//was Items
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderNumber"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

            }
        }
    }
}
