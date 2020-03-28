using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;


namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PropertyChangedPanDeCampoTest
    {
        //test1 make sure it implements the inotifypropertyInterface
        [Fact]
        public void PanDeCampoFriesShouldImplementInotifyPropertyChanged()
        {
            var pan = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pan);
        }

        [Fact]
        public void ChangingSmallShouldInvokePropertyChangedForSmall()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Size", () => { pan.Size = Size.Small; });
            Assert.Equal(1.59, pan.Price);
            uint a = 227;
            Assert.Equal(a, pan.Calories);
        }

        [Fact]
        public void ChangingMediumShouldInvokePropertyChangedForMedium()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Size", () => { pan.Size = Size.Medium; });
            Assert.Equal(1.79, pan.Price);
            uint a = 269;
            Assert.Equal(a, pan.Calories);
        }

        [Fact]
        public void ChangingLargeShouldInvokePropertyChangedForLarge()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Size", () => { pan.Size = Size.Large; });
            Assert.Equal(1.99, pan.Price);
            uint a = 367;
            Assert.Equal(a, pan.Calories);
        }
    }
}
