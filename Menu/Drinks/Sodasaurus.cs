﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/// <summary>
/// Sodasaurus
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    /// <summary>
    /// Enum of all the flavors available.
    /// </summary>
    public enum SodasaurusFlavor
    {
        Cola,
        RootBeer,
        Cherry,
        Vanilla,
        Chocolate,
        Orange,
        Grape,
        Lime

    }

    public class Sodasaurus : Drink, INotifyPropertyChanged
    {
        public override string Description { get { return this.ToString(); } }
        public override string[] Special { get { return new string[0]; } }

        private SodasaurusFlavor flavor;
        private Size size;
        /// <summary>
        /// Getter and Setter for flavor of the Sodasaurus.
        /// </summary>
        public SodasaurusFlavor Flavor {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyofPropertyChanged("Description");
            } 
        }
        /// <summary>
        /// Override of ingredients list, includes all base ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Water");
                Ingredients.Add("Natural Flavors");
                Ingredients.Add("Cane Sugar");
                return Ingredients;
            }
        }
        /// <summary>
        /// Override of Size property.
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = 1.5;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.5;
                        Calories = 208;
                        break;
                }
                NotifyofPropertyChanged("Description");
                NotifyofPropertyChanged("Size");
                NotifyofPropertyChanged("Price");
                NotifyofPropertyChanged("Calories");
            }
        }


        /// <summary>
        /// Constructor, sets default size to small and ice to true.
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
            Price = 1.50;
            Calories = 112;
            Ice = true;
        }
        /// <summary>
        /// Creates a string with the size and flavor of the soda.
        /// </summary>
        /// <returns>Returns a string with size, flavor, and name of drink.</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }
    }
}
