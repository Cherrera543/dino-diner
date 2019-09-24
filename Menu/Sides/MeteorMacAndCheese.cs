using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// MeteorMacAndCheese
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// This ingredients item adds all the ingredients to the list, none can be removed.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Cheese Product");
                Ingredients.Add("Macaroni Noodles");
                Ingredients.Add("Pork Sausage");
                return Ingredients;
            }
        }

        public Size Size
        {
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
                if (value == Size.Medium)
                {
                    this.Price = 1.45;
                    this.Calories = 490;
                }
                else if (value == Size.Large)
                {
                    this.Price = 1.99;
                    this.Calories = 520;
                }
            }
        }
        /// <summary>
        /// This constructor sets the default size to small and sets the price and calories.
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Size = Size.Small;
            this.Price = .99;
            this.Calories = 420;
        }
    }
}
