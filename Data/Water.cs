/* 
 * Author: Grant Clothier
 * Class: Water.cs
 * Purpose: class representing the water
 * 2.12.2020
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// returns string name of Water
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Water"; //the calories
                case Size.Medium:
                    return "Medium Water";
                case Size.Large:
                    return "Large Water";
                default:
                    throw new NotImplementedException();
            }

        }

        private bool lemon = false;
        /// <summary>
        /// if the Water has Lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /// <summary>
        /// the price for the Water
        /// </summary>
        public override double Price
        {
            get
            {
                return .12;
            }
        }

        /// <summary>
        /// the calories for the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// the special instructions for the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
    }
}
