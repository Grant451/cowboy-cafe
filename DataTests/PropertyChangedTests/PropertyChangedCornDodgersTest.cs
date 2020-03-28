using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;


namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PropertyChangedCornDodgersTest
    {
        //test1 make sure it implements the inotifypropertyInterface
        [Fact]
        public void CornDodgersFriesShouldImplementInotifyPropertyChanged()
        {
            var dodger = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dodger);
        }

        [Fact]
        public void ChangingSmallShouldInvokePropertyChangedForSmall()
        {
            var dodger = new CornDodgers();
            Assert.PropertyChanged(dodger, "Size", () => { dodger.Size = Size.Small; });
            Assert.Equal(1.59, dodger.Price);
            uint a = 512;
            Assert.Equal(a, dodger.Calories);
        }

        [Fact]
        public void ChangingMediumShouldInvokePropertyChangedForMedium()
        {
            var dodger = new CornDodgers();
            Assert.PropertyChanged(dodger, "Size", () => { dodger.Size = Size.Medium; });
            Assert.Equal(1.79, dodger.Price);
            uint a = 685;
            Assert.Equal(a, dodger.Calories);
        }

        [Fact]
        public void ChangingLargeShouldInvokePropertyChangedForLarge()
        {
            var dodger = new CornDodgers();
            Assert.PropertyChanged(dodger, "Size", () => { dodger.Size = Size.Large; });
            Assert.Equal(1.99, dodger.Price);
            uint a = 717;
            Assert.Equal(a, dodger.Calories);
        }
    }
}
