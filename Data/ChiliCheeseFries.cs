/* 
 * Author: Grant Clothier
 * Class: ChiliCheeseFries.cs
 * Purpose: Information about the menu item Chili Cheese Fries
 * 2.03.2020
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the chili cheese fries side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// returns string name of Chili Cheese Fries
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Chili Cheese Fries";
        }

        /// <summary>
        /// calories of the chili cheese fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 433;//the calories
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Price of the chili cheese fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.99;//the calories
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
