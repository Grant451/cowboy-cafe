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
            temp.Add(new BakedBeans());
            temp.Add(new PanDeCampo());
            temp.Add(new ChiliCheeseFries());
            temp.Add(new CornDodgers());
            //drinks:
            temp.Add(new BakedBeans());
            temp.Add(new PanDeCampo());
            temp.Add(new ChiliCheeseFries());
            temp.Add(new CornDodgers());
            return temp.ToArray();
        }
    }
}
