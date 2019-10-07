using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Drink
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
   
    public abstract class Drink : MenuItem
    {
        /// <summary>
        /// Property getter and setter for drink size.
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// Getter for list of ingredients in the drink.
        /// </summary>
        public abstract List<string> Ingredients { get; }
        /// <summary>
        /// Getter and setter for price of drink.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Getter and Setter for calories of a drink.
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Getter and Setter for whether a drink has ice.
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// Method allows for a drink to not have ice.
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
