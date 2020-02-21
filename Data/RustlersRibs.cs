/* 
 * Author: Grant Clothier
 * Class: RustlersRibs.cs
 * Purpose: Information about the menu item Rustlers Ribs
 * 1.28.2020
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the rustlers ribs
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// returns string name of Rustlers Ribs
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }

        /// <summary>
        /// The price of the RustlersRibs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the RustlersRibs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// no special instructions are needed for the RustlersRibs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }
    }
}
