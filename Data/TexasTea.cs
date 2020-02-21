/* 
 * Author: Grant Clothier
 * Class: TexasTea.cs
 * Purpose: class representing the Texas Tea
 * 2.12.2020
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        /// <summary>
        /// returns string name of Texas Tea
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    if (sweet) return "Small Texas Sweet Tea";
                    return "Small Texas Plain Tea"; //the calories
                case Size.Medium:
                    if (sweet) return "Medium Texas Sweet Tea";
                    return "Medium Texas Plain Tea";
                case Size.Large:
                    if (sweet) return "Large Texas Sweet Tea";
                    return "Large Texas Plain Tea";
                default:
                    throw new NotImplementedException();
            }

        }

        private bool sweet = true;
        /// <summary>
        /// if the TexasTea has sweet
        /// </summary>
        public bool Sweet 
        {
            get { return sweet; }
            set { sweet = value; }
        }

        private bool lemon = false;
        /// <summary>
        /// if the TexasTea has Lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /// <summary>
        /// the price for the Texas Tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
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
                        if (!Sweet) return 5;
                        return 10;
                    case Size.Medium:
                        if (!Sweet) return 11;
                        return 22;
                    case Size.Large:
                        if (!Sweet) return 18;
                        return 36;
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
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
    }
}
