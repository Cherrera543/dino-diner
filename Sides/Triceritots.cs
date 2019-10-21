using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/// <summary>
/// Triceritops
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    public class Triceritots : Side
    {
        public override string Description { get { return this.ToString(); } }
        public override string[] Special { get { return new string[0]; } }
        private Size size;
        /// <summary>
        /// This ingredients item adds all the ingredients to the list, none can be removed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Potato");
                Ingredients.Add("Salt");
                Ingredients.Add("Vegetable Oil");
                return Ingredients;
            }
        }

        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = .99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
                NotifyofPropertyChanged("Size");
                NotifyofPropertyChanged("Price");
                NotifyofPropertyChanged("Calories");
            }
        }
        /// <summary>
        /// This constructor sets the default size to small and sets the price and calories.
        /// </summary>
        public Triceritots()
        {
            this.Size = Size.Small;
        }
        /// <summary>
        /// Creates a string with the size of the item.
        /// </summary>
        /// <returns>Returns a string with the size and name of the side.</returns>
        public override string ToString()
        {
            return $"{Size} Triceritots";
        }
    }
}
