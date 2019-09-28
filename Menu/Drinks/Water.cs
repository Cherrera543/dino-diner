using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water: Drink
    {
        public bool Lemon = false;

        public List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Water");
                if (Lemon) Ingredients.Add("Lemon");
                return Ingredients;
            }
        }
        public void AddLemon()
        {
            Lemon = true;
        }

        public Water()
        {
            Size = Size.Small;
            Price = .10;
            Calories = 0;
            Ice = true;
        }
    }
}
