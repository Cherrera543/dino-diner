using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Sodasaurus
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    /// <summary>
    /// Enum of all the flavors available.
    /// </summary>
    public enum SodasaurusFlavor
    {
        Cola,
        RootBeer,
        Cherry,
        Vanilla,
        Chocolate,
        Orange,
        Grape,
        Lime

    }

    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Boolean for ice set to true.
        /// </summary>
        public bool Ice = true;
        /// <summary>
        /// Getter and Setter for flavor of the Sodasaurus.
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }
        /// <summary>
        /// Override of ingredients list, includes all base ingredients.
        /// </summary>
        public override List<string> Ingredients
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
        /// <summary>
        /// Override of Size property.
        /// </summary>
        public override Size Size
        {
            get { return Size; }
            set
            {
                Size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = 1.5;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.5;
                        Calories = 208;
                        break;
                }
            }
        }
        /// <summary>
        /// Constructor, sets default size to small and ice to true.
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
            Price = 1.50;
            Calories = 112;
            Ice = true;
        }
        /// <summary>
        /// Creates a string with the size and flavor of the soda.
        /// </summary>
        /// <returns>Returns a string with size, flavor, and name of drink.</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }
    }
}
