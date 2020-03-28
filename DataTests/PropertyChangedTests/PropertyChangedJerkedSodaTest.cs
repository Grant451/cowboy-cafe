using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;


namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PropertyChangedJerkedSodaTest
    {
        //test1 make sure it implements the inotifypropertyInterface
        [Fact]
        public void ChiliCheeseFriesShouldImplementInotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }

        [Fact]
        public void ChangingSmallShouldInvokePropertyChangedForSmall()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () => { soda.Size = Size.Small; });
            Assert.Equal(1.59, soda.Price);
            uint a = 110;
            Assert.Equal(a, soda.Calories);
        }

        [Fact]
        public void ChangingMediumShouldInvokePropertyChangedForMedium()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () => { soda.Size = Size.Medium; });
            Assert.Equal(2.1, soda.Price);
            uint a = 146;
            Assert.Equal(a, soda.Calories);
        }

        [Fact]
        public void ChangingLargeShouldInvokePropertyChangedForLarge()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () => { soda.Size = Size.Large; });
            Assert.Equal(2.59, soda.Price);
            uint a = 198;
            Assert.Equal(a, soda.Calories);
        }

        //tests for Ice change
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Ice = false;
            });
        }

        //tests for flavor:
        [Fact]
        public void ChangingCreamSodaShouldInvokePropertyChangedForSodaFlovor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () => { soda.Flavor = SodaFlavor.CreamSoda; });
        }

        [Fact]
        public void ChangingOrangeSodaShouldInvokePropertyChangedForSodaFlovor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () => { soda.Flavor = SodaFlavor.OrangeSoda; });
        }

        [Fact]
        public void ChangingSarsparillaShouldInvokePropertyChangedForSodaFlovor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () => { soda.Flavor = SodaFlavor.Sarsparilla; });
        }

        [Fact]
        public void ChangingBirchBeerShouldInvokePropertyChangedForSodaFlovor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () => { soda.Flavor = SodaFlavor.BirchBeer; });
        }

        [Fact]
        public void ChangingRootBeerShouldInvokePropertyChangedForSodaFlovor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () => { soda.Flavor = SodaFlavor.RootBeer; });
        }
    }
}
