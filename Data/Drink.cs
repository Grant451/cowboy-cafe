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
    public abstract class Drink
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
        public abstract uint Calories { get; }

        /// <summary>
        /// gets weather the drink has ice or not
        /// </summary>
        public virtual bool Ice { get; }

        /// <summary>
        /// gets the special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
