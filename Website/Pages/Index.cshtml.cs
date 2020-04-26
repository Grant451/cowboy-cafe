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
            MenuItemTypes = Menu.MenuItemTypes;
            Start = true;
        }

        /// <summary>
        /// keeps track of startup status
        /// </summary>
        public bool Start { get; set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// the types of menu items used in the search
        /// </summary>
        public string[] MenuItemTypes { get; set; }//= Menu.MenuItemTypes;

        /// <summary>
        /// min number of calories
        /// </summary>
        //public int CalMin { get; set; }

        /// <summary>
        /// max number of calories
        /// </summary>
        //public int CalMax { get; set; }

        /// <summary>
        /// the min number of calories
        /// </summary>
        public int? CalMin { get; set; }
        
        /// <summary>
        /// the max number of calories
        /// </summary>
        public int? CalMax { get; set; }

        /// <summary>
        /// the minimum price
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// the maximum price
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// The menu items to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> MenuList { get; protected set; }


        /// <summary>
        /// runs the search section
        /// </summary>
        public void OnGet(int? CalMin, int? CalMax, double? PriceMin, double? PriceMax)
        {
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

            
        }
    }
}
