/* 
 * Author: Grant Clothier
 * Class: PanDeCampo.cs
 * Purpose: Information about the menu item Pan De Campo
 * 2.04.2020
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the Pan De Campo side
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// returns string name of Pan De Campo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Pan de Campo"; ;//the calories
                case Size.Medium:
                    return "Medium Pan de Campo"; ;
                case Size.Large:
                    return "Large Pan de Campo"; ;
                default:
                    throw new NotImplementedException();
            }

        }

        /// <summary>
        /// calories of the Pan de Campo
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
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
