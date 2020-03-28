using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;


namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PropertyChangedWaterTest
    {
        //test1 make sure it implements the inotifypropertyInterface
        [Fact]
        public void WaterShouldImplementInotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        //tests for price and colorie changes:
        [Fact]
        public void ChangingSmallShouldInvokePropertyChangedForSmall()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () => { water.Size = Size.Small; });
            Assert.Equal(.12, water.Price);
            uint a = 0;
            Assert.Equal(a, water.Calories);
        }

        [Fact]
        public void ChangingMediumShouldInvokePropertyChangedForMedium()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () => { water.Size = Size.Medium; });
            Assert.Equal(.12, water.Price);
            uint a = 0;
            Assert.Equal(a, water.Calories);
        }

        [Fact]
        public void ChangingLargeShouldInvokePropertyChangedForLarge()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () => { water.Size = Size.Large; });
            Assert.Equal(.12, water.Price);
            uint a = 0;
            Assert.Equal(a, water.Calories);
        }

        //tests for Ice change
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = true;
            });

        }


        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = true;
            });
        }


    }
}
