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

namespace CowboyCafe.Data
{
    public class Order
    {

        public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);

        /// <summary>
        /// keeps track of the last order number
        /// </summary>
        private uint lastOrderNumber;

        /// <summary>
        /// a backing list that holds the items in the order
        /// </summary>
        private List<IOrderItem> items;

        /// <summary>
        /// IEnumberable of IOrderItem used to access the information in items
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; }//=> throw new NotImplementedException();

        /// <summary>
        /// the price of the total order
        /// </summary>
        public double Subtotal { get; }//=> 0;

        /// <summary>
        /// a unique number for each order
        /// </summary>
        public static uint OrderNumber { get; }

        /// <summary>
        /// adds an item to itmes
        /// </summary>
        /// <param name="item">the backing variable for the order</param>
        public void Add(IOrderItem item) 
        {
            items.Add(item);
        }

        /// <summary>
        /// removes an item from items
        /// </summary>
        /// <param name="item">the backing variable for the order</param>
        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
        }
    }
}
