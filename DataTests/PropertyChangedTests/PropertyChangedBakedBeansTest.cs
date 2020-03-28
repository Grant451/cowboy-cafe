using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PropertyChangedBakedBeansTest
    {
        //test1 make sure it implements the inotifypropertyInterface
        [Fact]
        public void BakedBeansShouldImplementInotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }

        [Fact]
        public void ChangingSmallShouldInvokePropertyChangedForSmall()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () => { beans.Size = Size.Small; });
            Assert.Equal(1.59, beans.Price);
            uint a = 312;
            Assert.Equal(a, beans.Calories);
        }

        [Fact]
        public void ChangingMediumShouldInvokePropertyChangedForMedium()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>{beans.Size = Size.Medium;});
            Assert.Equal(1.79, beans.Price);
            uint a = 378;
            Assert.Equal(a, beans.Calories);
        }

        [Fact]
        public void ChangingLargeShouldInvokePropertyChangedForLarge()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () => { beans.Size = Size.Large; });
            Assert.Equal(1.99, beans.Price);
            uint a = 410;
            Assert.Equal(a, beans.Calories);
        }


    }
}
