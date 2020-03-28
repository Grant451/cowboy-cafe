using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;


namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PropertyChangedTexasTeaTest
    {
        //test1 make sure it implements the inotifypropertyInterface
        [Fact]
        public void ChiliCheeseFriesShouldImplementInotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }

        [Fact]
        public void ChangingSmallShouldInvokePropertyChangedForSmall()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () => { tea.Size = Size.Small; });
            Assert.Equal(1, tea.Price);
            uint a = 10;
            Assert.Equal(a, tea.Calories);
        }

        [Fact]
        public void ChangingMediumShouldInvokePropertyChangedForMedium()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () => { tea.Size = Size.Medium; });
            Assert.Equal(1.5, tea.Price);
            uint a = 22;
            Assert.Equal(a, tea.Calories);
        }

        [Fact]
        public void ChangingLargeShouldInvokePropertyChangedForLarge()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () => { tea.Size = Size.Large; });
            Assert.Equal(2, tea.Price);
            uint a = 36;
            Assert.Equal(a, tea.Calories);
        }

        //tests for !sweet size change
        [Fact]
        public void ChangingSmallShouldInvokePropertyChangedForSmallandSweet()
        {
            var tea = new TexasTea();
            tea.Sweet = false;
            Assert.PropertyChanged(tea, "Size", () => { tea.Size = Size.Small; });
            Assert.Equal(1, tea.Price);
            uint a = 5;
            Assert.Equal(a, tea.Calories);
        }

        [Fact]
        public void ChangingMediumShouldInvokePropertyChangedForMediumandSweet()
        {
            var tea = new TexasTea();
            tea.Sweet = false;
            Assert.PropertyChanged(tea, "Size", () => { tea.Size = Size.Medium; });
            Assert.Equal(1.5, tea.Price);
            uint a = 11;
            Assert.Equal(a, tea.Calories);
        }

        [Fact]
        public void ChangingLargeShouldInvokePropertyChangedForLargeandSweet()
        {
            var tea = new TexasTea();
            tea.Sweet = false;
            Assert.PropertyChanged(tea, "Size", () => { tea.Size = Size.Large; });
            Assert.Equal(2, tea.Price);
            uint a = 18;
            Assert.Equal(a, tea.Calories);
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = false;
            });

        }


        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = true;//lemon is default false
            });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = false;
            });

        }


        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Sweet = false;
            });
        }
    }
}
