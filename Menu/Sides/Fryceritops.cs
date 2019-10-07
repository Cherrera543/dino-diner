using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Fryceritops
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    public class Fryceritops : Side
    {
        /// <summary>
        /// This ingredients item adds all the ingredients to the list, none can be removed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string>Ingredients = new List<string>();
                Ingredients.Add("Potato");
                Ingredients.Add("Salt");
                Ingredients.Add("Vegetable Oil");
                return Ingredients;
            }
        }
        /// <summary>
        /// Override of Size property, as size changes so does price and calories.
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 480;
                        break;
                }
                if (value == Size.Medium)
                {
                    this.Price = 1.45;
                    this.Calories = 365;
                }else if(value == Size.Large)
                {
                    this.Price = 1.95;
                    this.Calories = 480;
                }
            }
        }

        /// <summary>
        /// This constructor sets the default size to small and sets the price and calories.
        /// </summary> 
        public Fryceritops()
        {
            this.Size = Size.Small;
            Price = .99;
            Calories = 222;                                                         
        }
        /// <summary>
        /// Creates a string that has the size of the item.
        /// </summary>
        /// <returns> Returns a string with the size and name of the side.</returns>
        public override string ToString()
        {
            return $"{Size} Friceritops";
        }
    }
}
