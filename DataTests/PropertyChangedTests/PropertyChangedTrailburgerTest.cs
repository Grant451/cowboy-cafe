using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PropertyChangedTrailburgerTest
    {
        //test1 make sure it implements the inotifypropertyInterface
        [Fact]
        public void TrailburgerShouldImplementInotifyPropertyChanged()
        {
            var trail = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(trail);
        }

        //test2 changing bool should invoke propertychanged for the bool

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Bun", () =>
            {
                trail.Bun = false;
            });

        }

        //test3 changing bool should invoke propertychanged for the SpecialInsturctions
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Ketchup", () =>
            {
                trail.Ketchup = false;
            });

        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Mustard", () =>
            {
                trail.Mustard = false;
            });

        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Pickle", () =>
            {
                trail.Pickle = false;
            });

        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Cheese", () =>
            {
                trail.Cheese = false;
            });

        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Cheese = false;
            });
        }
    }
}
