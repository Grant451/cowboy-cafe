//Grant Clothier 4.19.2020
//allows for enumeration through the menu items 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {

        static Menu()
        {
            All = CompleteMenu();
        }

        public static IEnumerable<IOrderItem> All;

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



        /// <summary>
        /// this function will search the entire menue for a specific item.
        /// </summary>
        /// <param name="terms"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            //I decided to follow the given uml rather than try to populate a list of all items from the constructor.
            var temp = CompleteMenu();//all the items.
            List<IOrderItem> complete = new List<IOrderItem>();//the finished list

            if (terms == null) return temp;//null check

            foreach (IOrderItem item in temp)
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    complete.Add(item);
                }
            }

            //I am concerned complete could be null
            if (complete == null) return temp;
            else return complete;
        }

        /// <summary>
        /// Gets the possible menu item types
        /// </summary>
        public static string[] MenuItemTypes
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink"
            };
        }

        /// <summary>
        /// Filter by the menu item type
        /// </summary>
        /// <param name="terms">terms representing the menu item types</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> menuList, IEnumerable<string> terms)
        {
            List<IOrderItem> complete = new List<IOrderItem>();//the finished list

            //null check:
            if (terms == null || terms.Count() == 0) return menuList;
            

            foreach(string x in terms)
            {
                foreach (IOrderItem item in menuList)
                {
                    if(x == "Entree")
                    {
                        if(item is Entree)
                        {
                            complete.Add(item);
                        }
                    }
                    else if(x == "Side")
                    {
                        if(item is Side)
                        {
                            complete.Add(item);
                        }
                    }
                    else if(x == "Drink")
                    {
                        if(item is Drink)
                        {
                            complete.Add(item);
                        }
                    }
                }

            }
            
            return complete;
        }


        /// <summary>
        /// filters the items by calories
        /// </summary>
        /// <param name="menuList">the original list</param>
        /// <param name="min">the minimum number of calories</param>
        /// <param name="max">the maximum number of calories</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menuList, int? min, int? max)
        {
            if (min == null && max == null) return menuList;

            //if (min < 0 || max > 10000) return menuList;

            List<IOrderItem> complete = new List<IOrderItem>();//the finished list

            foreach(IOrderItem x in menuList)
            {
                if(x.Calories<max && x.Calories>min)
                {
                    complete.Add(x);
                }
            }
            return complete;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menuList, double? min, double? max)
        {
            if (min == null && max == null) return menuList;

            //if (min < 0 || max > 10000) return menuList;

            List<IOrderItem> complete = new List<IOrderItem>();//the finished list

            foreach (IOrderItem x in menuList)
            {
                if (x.Price < max && x.Price > min)
                {
                    complete.Add(x);
                }
            }
            return complete;
        }
    }
}
