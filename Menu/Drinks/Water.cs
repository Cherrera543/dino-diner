using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Water
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    public class Water: Drink
    {
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
            get { return Size; }
            set { Size = value; }
        }
        /// <summary>
        /// Method adds lemon to the water.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
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
