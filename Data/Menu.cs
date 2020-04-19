//Grant Clothier 4.19.2020
//allows for enumeration through the menu items 
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// yeilds a list of all the entrees Ienumberable<IoderItem>
        /// </summary>
        /// <returns>list of all the entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            var temp = new List<IOrderItem>();
            temp.Add(new AngryChicken());
            temp.Add(new PecosPulledPork());
            temp.Add(new TrailBurger());
            temp.Add(new DakotaDoubleBurger());
            temp.Add(new TexasTripleBurger());
            temp.Add(new RustlersRibs());
            temp.Add(new CowpokeChili());
            return temp.ToArray();
        }

        /// <summary>
        /// yeilds Ienumerable<IorderItem>for the sides
        /// </summary>
        /// <returns>returns list of all sides</returns>
        public static IEnumerable<IOrderItem> side()
        { 
            var temp = new List<IOrderItem>();
            temp.Add(new BakedBeans());
            temp.Add(new PanDeCampo());
            temp.Add(new ChiliCheeseFries());
            temp.Add(new CornDodgers());
            return temp.ToArray();
        }

        /// <summary>
        /// yeilds Ienumerable<IorderItemL> for drinks
        /// </summary>
        /// <returns>list of all drinks</returns>
        public static IEnumerable<IOrderItem> Drink()
        {
            var temp = new List<IOrderItem>();
            temp.Add(new TexasTea());
            temp.Add(new JerkedSoda());
            temp.Add(new Water());
            temp.Add(new CowboyCoffee());
            return temp.ToArray();
        }

        /// <summary>
        /// yeilds Ienumerable list for the whole menu
        /// </summary>
        /// <returns>ienumerable<IorderItem>for the whole menu</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            var temp = new List<IOrderItem>();
            //entrees:
            temp.Add(new AngryChicken());
            temp.Add(new PecosPulledPork());
            temp.Add(new TrailBurger());
            temp.Add(new DakotaDoubleBurger());
            temp.Add(new TexasTripleBurger());
            temp.Add(new RustlersRibs());
            temp.Add(new CowpokeChili());
            //sides:
            var MedBaked = new BakedBeans();
            MedBaked.Size = Size.Medium;
            var LargeBaked = new BakedBeans();
            LargeBaked.Size = Size.Large;
            temp.Add(new BakedBeans());
            temp.Add(MedBaked);
            temp.Add(LargeBaked);
            var MedPan = new PanDeCampo();
            MedPan.Size = Size.Medium;
            var LargePan = new PanDeCampo();
            LargePan.Size = Size.Large;
            temp.Add(new PanDeCampo());
            temp.Add(MedPan);
            temp.Add(LargePan);
            var MedFries = new ChiliCheeseFries();
            MedFries.Size = Size.Medium;
            var LargeFries = new ChiliCheeseFries();
            LargeFries.Size = Size.Large;
            temp.Add(new ChiliCheeseFries());
            temp.Add(MedFries);
            temp.Add(LargeFries);
            var MedCorn = new CornDodgers();
            MedCorn.Size = Size.Medium;
            var LargeCorn = new CornDodgers();
            LargeCorn.Size = Size.Large;
            temp.Add(new CornDodgers());
            temp.Add(MedCorn);
            temp.Add(LargeCorn);
            //drinks:
            var MedTea = new TexasTea();
            MedTea.Size = Size.Medium;
            var LargeTea = new TexasTea();
            LargeTea.Size = Size.Large;
            temp.Add(new TexasTea());
            temp.Add(MedTea);
            temp.Add(LargeTea);
            var MedSoda = new JerkedSoda();
            MedSoda.Size = Size.Medium;
            var LargeSoda = new JerkedSoda();
            LargeSoda.Size = Size.Large;
            temp.Add(new JerkedSoda());
            temp.Add(MedSoda);
            temp.Add(LargeSoda);
            var MedWater = new Water();
            MedWater.Size = Size.Medium;
            var LargeWater = new Water();
            LargeWater.Size = Size.Large;
            temp.Add(new Water());
            temp.Add(MedWater);
            temp.Add(LargeWater);
            var MedCoffee = new CowboyCoffee();
            MedCoffee.Size = Size.Medium;
            var LargeCoffee = new CowboyCoffee();
            LargeCoffee.Size = Size.Large;
            temp.Add(new CowboyCoffee());
            temp.Add(MedCoffee);
            temp.Add(LargeCoffee);

            return temp.ToArray();
        }
    }
}
