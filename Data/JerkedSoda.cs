/* 
 * Author: Grant Clothier
 * Class: JerkedSoda.cs
 * Purpose: class representing the jerked soda
 * 2.12.2020
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        private SodaFlavor flavor;
        /// <summary>
        /// the flavor of the jerked soda
        /// initially set to null
        /// </summary>
        public SodaFlavor Flavor 
        {
            get { return flavor; }
            set { flavor = value; }
        }

        private bool ice = true;
        /// <summary>
        /// if the soda has ice
        /// </summary>
        public new bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// the price for the jerked soda
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
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the calories for the jerked soda
        /// </summary>
        public override uint Calories 
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the special instructions for the jerked soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }
        
    }
}
