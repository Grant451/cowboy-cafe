using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            //MenuItemTypes = Menu.MenuItemTypes;
            Start = true;
        }

        /// <summary>
        /// keeps track of startup status
        /// </summary>
        [BindProperty(SupportsGet =true)]
        public bool Start { get; set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// used to get the item types to search for
        /// </summary>
        [BindProperty(SupportsGet =true)]
        public string[] Types { get; set; }

        /// <summary>
        /// used to get the flavor types to search for
        /// </summary>
        //[BindProperty(SupportsGet =true)]
        //public string[] flavors { get; set; }

        /// <summary>
        /// the min number of calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CalMin { get; set; }

        /// <summary>
        /// the max number of calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CalMax { get; set; }

        /// <summary>
        /// the minimum price
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// the maximum price
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        /// <summary>
        /// The menu items to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> MenuList { get; protected set; } = Menu.All;

        /// <summary>
        /// The soda flavors to display on th index page
        /// </summary>
        public IEnumerable<SodaFlavor> FlavorList { get; protected set; } = Menu.SodaFlovorItems();

        /// <summary>
        /// runs the search section
        /// </summary>
        public void OnGet(int? CalMin, int? CalMax, double? PriceMin, double? PriceMax)
        {
            /*
            SearchTerms = Request.Query["SearchTerms"];
            MenuList = Menu.Search(SearchTerms);
            
            MenuItemTypes = Request.Query["Types"];
            MenuList = Menu.FilterByCategory(MenuList, MenuItemTypes);

            this.CalMin = CalMin;
            this.CalMax = CalMax;
            MenuList = Menu.FilterByCalories(MenuList, CalMin, CalMax);

            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            MenuList = Menu.FilterByPrice(MenuList, PriceMin, PriceMax);
            */

            //system linq implementation: 
            
            MenuList = MenuList;
            if(SearchTerms != null)
            {
                MenuList = MenuList.Where(Item => Item.ToString() != null && Item.ToString().Contains(SearchTerms, StringComparison.CurrentCultureIgnoreCase));
            }

            if (Types.Count() != 0)
            {
                //menuItemTypes needs to be compared to menulist for matches
                //my menu Item types are not enumarable I am going to keep my original search function
                //MenuList = Menu.FilterByCategory(MenuList, Types);
                
                
                MenuList = MenuList.Where(Item =>
                (
                    Types.Contains("Entree") && Item is Entree) ||
                    Types.Contains("Side")&& Item is Side ||
                    Types.Contains("Drink") && Item is Drink
                );
                
            }
           
            if (CalMin != null && CalMax != null)
            {
                MenuList = MenuList.Where(Item => Item.Calories > CalMin && Item.Calories < CalMax);
            }

            if (PriceMin != null && PriceMax != null)
            {
                MenuList = MenuList.Where(Item => Item.Price > PriceMin && Item.Price < PriceMax);
            }

            //this should cycle through a custom list of the flavors.
            /*
            if (flavors.Count() != 0)
            {
                FlavorList = FlavorList.Where(Item =>
                (
                    flavors.Contains("CreamSoda") && Item == SodaFlavor.CreamSoda ||
                    flavors.Contains("OrangeSoda") && Item == SodaFlavor.OrangeSoda ||
                    flavors.Contains("Sarsparilla") && Item == SodaFlavor.Sarsparilla ||
                    flavors.Contains("BirchBeer") && Item == SodaFlavor.BirchBeer ||
                    flavors.Contains("RootBeer") && Item == SodaFlavor.RootBeer
                ));
                

            }*/
            
            
        }
    }
}
