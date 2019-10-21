using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
/// <summary>
/// Side
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    /// <summary>
    /// Enum that lists all the possible size for drinks and sides.
    /// </summary>
    public enum Size
    {
        Small,
        Medium, 
        Large
    }

    public abstract class Side: MenuItem
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyofPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
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

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }
        public abstract string Description { get; }
        public abstract string[] Special { get; }

    }
}
