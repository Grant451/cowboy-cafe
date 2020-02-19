/* 
 * Author: Grant Clothier
 * Class: CornDodgers.cs
 * Purpose: Information about the menu item Corn Dodgers
 * 2.04.2020
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{

    /// <summary>
    /// a class representing the corn dodgers side
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// returns string name of Corn Dodgers
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Corn Dodgers"; ;//the calories
                case Size.Medium:
                    return "Medium Corn Dodgers"; ;
                case Size.Large:
                    return "Large Corn Dodgers"; ;
                default:
                    throw new NotImplementedException();
            }

        }

        /// <summary>
        /// calories of the corn dodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Price of the corn dodgers
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
