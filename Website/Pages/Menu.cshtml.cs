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
        public List<MenuItem> AvailableEntrees { get; set; } 
        public List<MenuItem> AvailableCombos { get; set; }
        public List<MenuItem> AvailableSides { get; set; }
        public List<MenuItem> AvailableDrinks { get; set; }

       
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
                AvailableCombos = Search(AvailableCombos, search);
                AvailableEntrees = Search(AvailableEntrees, search);
                AvailableSides = Search(AvailableSides, search);
                AvailableDrinks = Search(AvailableDrinks, search);
            }
            if (type.Count != 0)
            {
                if (!type.Contains("Entrees")) { AvailableEntrees.Clear(); }
                if (!type.Contains("Combos")) { AvailableCombos.Clear(); }
                if (!type.Contains("Sides")) { AvailableSides.Clear(); }
                if (!type.Contains("Drinks")) { AvailableDrinks.Clear(); }
            }
            if (mini != 0.0)
            {
                AvailableCombos = Minimum(AvailableCombos, mini);
                AvailableEntrees = Minimum(AvailableEntrees, mini);
                AvailableSides = Minimum(AvailableSides, mini);
                AvailableDrinks = Minimum(AvailableDrinks, mini);
            }
            if(maxi != 10.0)
            {
                AvailableCombos = Maximum(AvailableCombos, maxi);
                AvailableEntrees = Maximum(AvailableEntrees, maxi);
                AvailableSides = Maximum(AvailableSides, maxi);
                AvailableDrinks = Maximum(AvailableDrinks, maxi);
            }
            if(ingred.Count != 0)
            {
                AvailableCombos = Ingredients(AvailableCombos, ingred);
                AvailableEntrees = Ingredients(AvailableEntrees, ingred);
                AvailableSides = Ingredients(AvailableSides, ingred);
                AvailableDrinks = Ingredients(AvailableDrinks, ingred);
            }
           
        }

        private List<MenuItem> Search(List<MenuItem> result, string term)
        {
            List<MenuItem> result2 = new List<MenuItem>();
            foreach(MenuItem m in result)
            {
                if(m.ToString().Contains(term, StringComparison.OrdinalIgnoreCase))
                {
                    result2.Add(m);
                }
            }
            return result2;
        }

        private List<MenuItem> Minimum(List<MenuItem> result, double min)
        {
            List<MenuItem> result2 = new List<MenuItem>();
            foreach(MenuItem m in result)
            {
                if (m.Price > min)
                {
                    result2.Add(m);
                }
            }
            return result2;
        }

        private List<MenuItem> Maximum(List<MenuItem> result, double max)
        {
            List<MenuItem> result2 = new List<MenuItem>();
            foreach (MenuItem m in result)
            {
                if (m.Price < max)
                {
                    result2.Add(m);
                }
            }
            return result2;
        }

        private List<MenuItem> Ingredients(List<MenuItem> result, List<String> ingred)
        {
            List<MenuItem> result2 = new List<MenuItem>();
            foreach(MenuItem m in result)
            {
                bool cont = false;
                foreach(String s in ingred)
                {
                    
                    if (m.Ingredients.Contains(s))
                    {
                        cont = true;
                    }
                }
                if (cont == false) { result2.Add(m); }
            }
            return result2;
        }
    }
}