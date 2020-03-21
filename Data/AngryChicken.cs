/* 
 * Author: Grant Clothier
 * Class: AngryChicken.cs
 * Purpose: Information about the menu item Angry Chicken
 * 1.28.2020
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the Angry Chicken
    /// </summary>
    public class AngryChicken : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// returns string name of Angry Chicken
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }

        private bool bread = true;
        /// <summary>
        /// If the Chicken has bread
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
        //public bool Bread {get; set;} = true;

        private bool pickle = true;
        /// <summary>
        /// If the Chicken has pickle
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
        /// The price of the AngryChicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the AngryChicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the AngryChicken
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

        /*
        private new void NotifyOfPropertyChange(string propertyName)//protected only this class or a derived class can use this method
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));//the ? is a null check
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }*/

    }
}
