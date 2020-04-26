using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.Linq;

namespace CowboyCafe.DataTests.Filters_tests
{
    public class FiltersTests
    {
        /*
        [Fact]
        public void MenuSidesShouldContainExpectedStuff()
        {
            //var side = new List<IOrderItem>(Menu.side);
            var side = Menu.side();
            Assert.Contains(side, new CowpokeChili());
            //side.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                Menu.side,
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                    );
                    
        }
        */

        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        public void SidesShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach(IOrderItem item in Menu.side())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void SidesShouldHaveOnlyFourItems()
        {
            Assert.Equal(4, Menu.side().Count());
        }

        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(CowpokeChili))]
        public void EntreesShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Entrees())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void EntreesShouldHaveOnlySevenItems()
        {
            Assert.Equal(7, Menu.Entrees().Count());
        }

        [Theory]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(Water))]
        [InlineData(typeof(CowboyCoffee))]
        public void DrinksShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Drink())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void DrinksShouldHaveOnlyFourItems()
        {
            Assert.Equal(4, Menu.Drink().Count());
        }

        [Theory]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(Water))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        public void AllShouldContainAllItems(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.All)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Theory]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(CowpokeChili))]
        public void FilterBySearchShouldFilterProperly(Type type)
        {
            var end = Menu.Search("Cow");
            var types = new List<Type>();
            foreach (IOrderItem item in end)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);

        }



        [Theory]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(Water))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        public void FilterbyCategoryFiltersProperly(Type type)
        {
            //because of the way I set up my algorithm this should work
            var temp = Menu.CompleteMenu();
            var itemtypes = Menu.MenuItemTypes;
            var end = Menu.FilterByCategory(temp, itemtypes );
            var types = new List<Type>();
            foreach (IOrderItem item in end)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }


        [Theory]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        public void FilterbyCaloriesFiltersProperly(Type type)
        {
            var All = Menu.CompleteMenu();
            var end = Menu.FilterByCalories(All, 50, 500);
            var types = new List<Type>();
            foreach (IOrderItem item in end)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(CowpokeChili))]
        public void FilterbyPrice(Type type)
        {
            var All = Menu.CompleteMenu();
            var end = Menu.FilterByPrice(All, 5, 10);
            var types = new List<Type>();
            foreach (IOrderItem item in end)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
    }
}
