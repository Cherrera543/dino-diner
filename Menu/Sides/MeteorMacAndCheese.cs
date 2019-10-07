using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// MeteorMacAndCheese
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// This ingredients item adds all the ingredients to the list, none can be removed.
        /// </summary>
        public override List<string> Ingredients
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
        /// <summary>
        /// Override of the Size property, as size changes so does the price and calories.
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 520;
                        break;
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
        /// <summary>
        /// Creates a string with the size of the item.
        /// </summary>
        /// <returns>Returns a string with the size and name of the Side.</returns>
        public override string ToString()
        {
            return $"{Size} Meteor Mac and Cheese";
        }
    }
}
