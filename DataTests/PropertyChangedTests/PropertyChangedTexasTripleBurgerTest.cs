using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PropertyChangedTexasTripleBurgerTest
    {
        //test1 make sure it implements the inotifypropertyInterface
        [Fact]
        public void TexasTripleBurgerShouldImplementInotifyPropertyChanged()
        {
            var triple = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(triple);
        }

        //test2 changing bool should invoke propertychanged for the bool

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Bun", () =>
            {
                triple.Bun = false;
            });

        }

        //test3 changing bool should invoke propertychanged for the SpecialInsturctions
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Ketchup", () =>
            {
                triple.Ketchup = false;
            });

        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Mustard", () =>
            {
                triple.Mustard= false;
            });

        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Pickle", () =>
            {
                triple.Pickle = false;
            });

        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Cheese", () =>
            {
                triple.Cheese = false;
            });

        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Cheese = false;
            });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Tomato", () =>
            {
                triple.Tomato = false;
            });

        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Lettuce", () =>
            {
                triple.Lettuce = false;
            });

        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Mayo", () =>
            {
                triple.Mayo = false;
            });

        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Mayo = false;
            });
        }

        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Bacon", () =>
            {
                triple.Bacon = false;
            });

        }

        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Bacon = false;
            });
        }

        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Egg", () =>
            {
                triple.Egg = false;
            });

        }

        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Egg = false;
            });
        }
    }
}
