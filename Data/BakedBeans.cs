/* 
 * Author: Grant Clothier
 * Class: BakedBeans.cs
 * Purpose: Information about the menu item Baked beans
 * 2.04.2020
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing the baked beans side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// returns string name of Baked Beans
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Baked Beans";
        }

        /// <summary>
        /// calories of the baked beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// colories of the baked beans
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
