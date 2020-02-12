/* 
 * Author: Grant Clothier
 * Class: CowboyCoffee.cs
 * Purpose: class representing the Cowboy Coffee
 * 2.12.2020
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {

        private bool roomForCream = false;
        /// <summary>
        /// if there is room for cream in the cowboy coffee
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        private bool decaf = false;
        /// <summary>
        /// if the coffee is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        private bool ice = false;
        /// <summary>
        /// Cowboy coffee has no ice by default
        /// </summary>
        public new bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// the price for the Cowboy Coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return .60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the calories for the CowboyCoffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
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

                if (Ice) instructions.Add("Add Ice");
                if (roomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }
    }
}
