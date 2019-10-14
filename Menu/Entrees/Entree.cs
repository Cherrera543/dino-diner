using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Entree
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    public abstract class Entree : MenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }
    }
}
