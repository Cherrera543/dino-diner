using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Mezzoralla Sticks
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    public class MezzorellaSticks: Side
    {
        /// <summary>
        /// This ingredients item adds all the ingredients to the list, none can be removed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string>Ingredients = new List<string>();
                Ingredients.Add("Cheese Product");
                Ingredients.Add("Breading");
                Ingredients.Add("Vegetable Oil");
                return Ingredients;
            }
        }
        /// <summary>
        /// Overrides the size property, as size changes so do price and calories.
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = .99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 720;
                        break;
                }
                
            }
        }
        /// <summary>
        /// This constructor sets the default size to small and sets the price and calories.
        /// </summary>
        public MezzorellaSticks()
        {
            this.Size = Size.Small;
            this.Price = .99;
            this.Calories = 540;
        }
        /// <summary>
        /// Creates a string with the size of the item.
        /// </summary>
        /// <returns>Returns a string with the size and name of the side.</returns>
        public override string ToString()
        {
            return $"{Size} Mezzorella Sticks";
        }
    }
}
