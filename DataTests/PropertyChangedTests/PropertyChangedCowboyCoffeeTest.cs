using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PropertyChangedCowboyCoffeeTest
    {
        //test1 make sure it implements the inotifypropertyInterface
        [Fact]
        public void CowboyCoffeeShouldImplementInotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }

        [Fact]
        public void ChangingSmallShouldInvokePropertyChangedForSmall()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Size", () => { coffee.Size = Size.Small; });
            Assert.Equal(.6, coffee.Price);
            uint a = 3;
            Assert.Equal(a, coffee.Calories);
        }

        [Fact]
        public void ChangingMediumShouldInvokePropertyChangedForMedium()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Size", () => { coffee.Size = Size.Medium; });
            Assert.Equal(1.1, coffee.Price);
            uint a = 5;
            Assert.Equal(a, coffee.Calories);
        }

        [Fact]
        public void ChangingLargeShouldInvokePropertyChangedForLarge()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Size", () => { coffee.Size = Size.Large; });
            Assert.Equal(1.6, coffee.Price);
            uint a = 7;
            Assert.Equal(a, coffee.Calories);
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = true;
            });

        }


        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Decaf = true;
            });
        }
        
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForRoomForCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = true;
            });

        }


        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.RoomForCream = true;
            });
        }
        
    }
}
