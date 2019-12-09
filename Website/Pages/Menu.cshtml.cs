using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu menu
        {
            get { return new Menu(); }
        }
        public IEnumerable<MenuItem> AvailableEntrees;
        public IEnumerable<MenuItem> AvailableCombos;
        public IEnumerable<MenuItem> AvailableSides;
        public IEnumerable<MenuItem> AvailableDrinks;

        [BindProperty]
        public List<String> type { get; set; } = new List<String>();
        [BindProperty]
        public String search { get; set; }
        [BindProperty]
        public List<String> ingred { get; set; } = new List<String>();
       [BindProperty]
        public double mini { get; set; } = 0.0;
        [BindProperty]
        public double maxi { get; set; } = 10.0;
        public void OnGet()
        {
            AvailableCombos = menu.AvailableCombos;
            AvailableEntrees = menu.AvailableEntrees;
            AvailableSides = menu.AvailableSide;
            AvailableDrinks = menu.AvailableDrinks;
        }
        public void OnPost()
        {
            AvailableCombos = menu.AvailableCombos;
            AvailableEntrees = menu.AvailableEntrees;
            AvailableSides = menu.AvailableSide;
            AvailableDrinks = menu.AvailableDrinks;
            if(search != null)
            {
                AvailableCombos = AvailableCombos.Where(combo => combo.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                AvailableEntrees = AvailableEntrees.Where(entree => entree.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                AvailableSides = AvailableSides.Where(side => side.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                AvailableDrinks = AvailableDrinks.Where(drink => drink.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            if (type.Count != 0)
            {
                if (!type.Contains("Entrees")) { AvailableEntrees = new List<MenuItem>(); }
                if (!type.Contains("Combos")) { AvailableCombos = new List<MenuItem>(); }
                if (!type.Contains("Sides")) { AvailableSides = new List<MenuItem>(); }
                if (!type.Contains("Drinks")) { AvailableDrinks = new List<MenuItem>(); }
            }
            if (mini != 0.0)
            {
                AvailableCombos = AvailableCombos.Where(combo => combo.Price > mini);
                AvailableEntrees = AvailableEntrees.Where(entree => entree.Price > mini);
                AvailableSides = AvailableSides.Where(side => side.Price > mini);
                AvailableDrinks = AvailableDrinks.Where(drink => drink.Price > mini);
            }
            if(maxi != 10.0)
            {
                AvailableCombos = AvailableCombos.Where(combo => combo.Price < maxi);
                AvailableEntrees = AvailableEntrees.Where(entree => entree.Price < maxi);
                AvailableSides = AvailableSides.Where(side => side.Price < maxi);
                AvailableDrinks = AvailableDrinks.Where(drink => drink.Price < maxi);
            }
            if(ingred.Count != 0)
            {
                foreach(String s in ingred)
                {
                    AvailableCombos = AvailableCombos.Where(combo => !combo.Ingredients.Contains(s));
                    AvailableEntrees = AvailableEntrees.Where(entree => !entree.Ingredients.Contains(s));
                    AvailableSides = AvailableSides.Where(side => !side.Ingredients.Contains(s));
                    AvailableDrinks = AvailableDrinks.Where(drink => !drink.Ingredients.Contains(s));
                }
            }
           
        }

        public double ChangePrice(MenuItem m, Size s)
        {
            m.Size = s;
            return m.Price;
        }
        public uint ChangeCalories(MenuItem m, Size s)
        {
            m.Size = s;
            return m.Calories;
        }
    }
}