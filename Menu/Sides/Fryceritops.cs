using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Fryceritops
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        /// <summary>
        /// This ingredients item adds all the ingredients to the list, none can be removed.
        /// </summary>
        public List<string> Ingredients
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
        
        public Size Size
        {
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
                if(value == Size.Medium)
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
        
        
    }
}
