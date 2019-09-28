using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        public bool Lemon = false;
        public bool Sweet = false;
        public List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Water");
                Ingredients.Add("Tea");
                if (Lemon) Ingredients.Add("Lemon");
                if (Sweet) Ingredients.Add("Cane Sugar");
                return Ingredients;
            }
        }

        public void AddLemon()
        {
            Lemon = true;
        }

        public void MakeSweet()
        {
            Sweet = true;
        }

        public Tyrannotea()
        {
            Size = Size.Small;
            Price = .99;
            Calories = 8;
        }

    }
}
