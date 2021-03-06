﻿//assumed Nathan Bean (approved by Grant Clothier 1.29.2020)
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili : Entree, INotifyPropertyChanged
    {

        //public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// returns string name of Cowpokechili
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Cowpoke Chili";
        }

        private bool cheese = true;
        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set 
            { 
                cheese = value;
                NotifyOfPropertyChange("Cheese");
            }

        }

        private bool sourCream = true;
        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream
        {
            get { return sourCream; }
            set 
            {
                sourCream = value;
                NotifyOfPropertyChange("SourCream");
                //sourCream = value; 
            }
        }

        private bool greenOnions = true;
        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions
        {
            get { return greenOnions; }
            set 
            {
                greenOnions = value;
                //greenOnions = value;
                NotifyOfPropertyChange("GreenOnions");
            }
        }

        private bool tortillaStrips = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips
        {
            get { return tortillaStrips; }
            set 
            {
                tortillaStrips = value;
                NotifyOfPropertyChange("TortillaStrips");
                //tortillaStrips = value; 
            }
        }

        /// <summary>
        /// The price of the chili
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!sourCream) instructions.Add("hold sour cream");
                if (!greenOnions) instructions.Add("hold green onions");
                if (!tortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }

        /*
        private new void NotifyOfPropertyChange(string propertyName)//protected only this class or a derived class can use this method
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));//the ? is a null check
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }*/


    }
}

