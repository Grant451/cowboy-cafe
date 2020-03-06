/* 
 * Author: Grant Clothier
 * Class: Entree.cs
 * Purpose: abstract base class for the entrees
 * 2.04.2020
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// an abstract base class for all the entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged//InotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the Entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the Entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets the special instructions for the Entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        protected void NotifyOfPropertyChange(string propertyName)//protected only this class or a derived class can use this method
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));//the ? is a null check
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

    }
}
