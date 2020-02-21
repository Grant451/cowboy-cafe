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
        /// <summary>
        /// returns string name of Jerked Soda
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {/*
            switch (Size)
            {
                case Size.Small:
                    return string.Format("Small {0} Jerked Soda", flavor); //the calories
                case Size.Medium:
                    return string.Format("Medium {0} Jerked Soda", flavor);
                case Size.Large:
                    return string.Format("Large {0} Jerked Soda", flavor);
                default:
                    throw new NotImplementedException();
            }
            */
            switch (flavor)
            {
                case SodaFlavor.CreamSoda:
                    if (this.Size == Size.Small) return "Small Cream Soda Jerked Soda";
                    if (this.Size == Size.Medium) return "Medium Cream Soda Jerked Soda";
                    if (this.Size == Size.Large) return "Large Cream Soda Jerked Soda";
                    throw new NotImplementedException();
                case SodaFlavor.OrangeSoda:
                    if (this.Size == Size.Small) return "Small Orange Soda Jerked Soda";
                    if (this.Size == Size.Medium) return "Medium Orange Soda Jerked Soda";
                    if (this.Size == Size.Large) return "Large Orange Soda Jerked Soda";
                    throw new NotImplementedException();
                case SodaFlavor.Sarsparilla:
                    if (this.Size == Size.Small) return "Small Sarsparilla Jerked Soda";
                    if (this.Size == Size.Medium) return "Medium Sarsparilla Jerked Soda";
                    if (this.Size == Size.Large) return "Large Sarsparilla Jerked Soda";
                    throw new NotImplementedException();
                case SodaFlavor.BirchBeer:
                    if (this.Size == Size.Small) return "Small Birch Beer Jerked Soda";
                    if (this.Size == Size.Medium) return "Medium Birch Beer Jerked Soda";
                    if (this.Size == Size.Large) return "Large Birch Beer Jerked Soda";
                    throw new NotImplementedException();
                case SodaFlavor.RootBeer:
                    if (this.Size == Size.Small) return "Small Root Beer Jerked Soda";
                    if (this.Size == Size.Medium) return "Medium Root Beer Jerked Soda";
                    if (this.Size == Size.Large) return "Large Root Beer Jerked Soda";
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();
            }

        }

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
