﻿/* 
 * Author: Grant Clothier
 * Class: PecosPulledPork.cs
 * Purpose: Information about the menu item Pecos Pulled Pork
 * extra: BBQ pulled pork sandwich
 * 1.29.2020
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the Pecos Pulled Pork
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// returns string name of Pecos Pulled Pork
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }

        private bool bread = true;
        /// <summary>
        /// If the Pecos Pulled Pork has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set
            {
                bread = value;
                NotifyOfPropertyChange("Bread"); 
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the Pecos Pulled Pork has pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        /// <summary>
        /// The price of the Pecos Pulled Pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the Pecos Pulled Pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the Pecos Pulled Pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}
