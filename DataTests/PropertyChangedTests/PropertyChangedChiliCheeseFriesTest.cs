using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;



namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PropertyChangedChiliCheeseFriesTest
    {
        //test1 make sure it implements the inotifypropertyInterface
        [Fact]
        public void ChiliCheeseFriesShouldImplementInotifyPropertyChanged()
        {
            var fries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }

        [Fact]
        public void ChangingSmallShouldInvokePropertyChangedForSmall()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Size", () => { fries.Size = Size.Small; });
            Assert.Equal(1.99, fries.Price);
            uint a = 433;
            Assert.Equal(a, fries.Calories);
        }

        [Fact]
        public void ChangingMediumShouldInvokePropertyChangedForMedium()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Size", () => { fries.Size = Size.Medium; });
            Assert.Equal(2.99, fries.Price);
            uint a = 524;
            Assert.Equal(a, fries.Calories);
        }

        [Fact]
        public void ChangingLargeShouldInvokePropertyChangedForLarge()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Size", () => { fries.Size = Size.Large; });
            Assert.Equal(3.99, fries.Price);
            uint a = 610;
            Assert.Equal(a, fries.Calories);
        }
    }
}
