using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum SodasaurusFlavor
    {
        Cola,
        RootBeer,
        Cherry,
        Vanilla,
        Chocolate,
        Orange,
        Grape

    }
    public class Sodasaurus : Drink
    {
        public bool Ice = true;
        public SodasaurusFlavor Flavor { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Water");
                Ingredients.Add("Natural Flavors");
                Ingredients.Add("Cane Sugar");
                return Ingredients;
            }
        }

        public Sodasaurus()
        {
            Size = Size.Small;
            Price = 1.50;
            Calories = 112;
            Ice = true;
        }
    }
}
