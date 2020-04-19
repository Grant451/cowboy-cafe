using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem
    {
       /// <summary>
       /// the price of an order item
       /// </summary>
        double Price { get; }

        /// <summary>
        /// the calories of the order item
        /// </summary>
        uint Calories { get; }
        //     Calories

        /// <summary>
        /// The special instructions for this order item
        /// </summary>
        List<string> SpecialInstructions { get; }

        
    }
}
