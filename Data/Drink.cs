/* 
 * Author: Grant Clothier
 * Class: Drink.cs
 * Purpose: abstract base class for drinks
 * 2.12.2020
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        private Size size;//added 3.13
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size 
        { 
            get
            {
                return size;
            }
            set
            {
                size = value;//was Size
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }

        /// <summary>
        /// gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }//abstract has to be overriden for each instance.

        private bool ice = true;
        /// <summary>
        /// gets weather the drink has ice or not
        /// (= true makes the default true and virtual can 
        /// have a different default value that can be implemented as needed.)
        /// was: public virtual bool Ice { get; set;} = true;//and did not have a backing variable 3.21
        /// </summary>
        public virtual bool Ice 
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }

        /// <summary>
        /// gets the special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        protected void NotifyOfPropertyChange(string propertyName)//protected only this class or a derived class can use this method
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));//the ? is a null check
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
