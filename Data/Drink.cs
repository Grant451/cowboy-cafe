/* 
 * Author: Grant Clothier
 * Class: Drink.cs
 * Purpose: abstract base class for drinks
 * 2.12.2020
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }//abstract has to be overriden for each instance.

        /// <summary>
        /// gets weather the drink has ice or not
        /// </summary>
        public virtual bool Ice { get; set; } = true;//makes the default true and virtual can 
        //have a different default value that can be implemented as needed.

        /// <summary>
        /// gets the special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
