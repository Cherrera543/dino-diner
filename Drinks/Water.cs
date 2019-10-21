using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/// <summary>
/// Water
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    public class Water: Drink, INotifyPropertyChanged
    {
        public override string Description { get { return this.ToString(); } }
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
        public Size size;
        /// <summary>
        /// Boolean states whether to add lemon. Default is false.
        /// </summary>
        public bool Lemon = false;
        /// <summary>
        /// Override of Ingredients list, includes base ingredients and lemon if added.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Water");
                if (Lemon) Ingredients.Add("Lemon");
                return Ingredients;
            }
        }
        /// <summary>
        /// Override of size property, no need to change price or calories. 
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set 
            { 
                size = value;
                NotifyofPropertyChanged("Size");
            }
        }
        /// <summary>
        /// Method adds lemon to the water.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyofPropertyChanged("Special");
        }
        /// <summary>
        /// Constructor, sets default size to small and ice to true.
        /// </summary>
        public Water()
        {
            Size = Size.Small;
            Price = .10;
            Calories = 0;
            Ice = true;
        }

        /// <summary>
        /// Creates a string that includes the size of the drink.
        /// </summary>
        /// <returns>Returns a string with size and name of drink.</returns>
        public override string ToString()
        {
            return $"{Size} Water";
        }
    }
}
