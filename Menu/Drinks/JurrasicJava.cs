using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Jurassic Java
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    public class JurassicJava : Drink
    {
        private Size size;
        /// <summary>
        /// Boolean for whether the coffee should have room for cream.
        /// </summary>
        public bool RoomForCream = false;
        /// <summary>
        /// Boolean for whether the coffee is decaf or not.
        /// </summary>
        public bool Decaf = false;
        /// <summary>
        /// Override of list of ingredients. Always has base ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Water");
                Ingredients.Add("Coffee");
                return Ingredients;
            }
        }

        /// <summary>
        /// Override of size property, allows for size change while changing price and calories.
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
                        Price = .59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
        }

        /// <summary>
        /// Sets boolean to true to allow for room.
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        /// <summary>
        /// Sets boolean to true to make Iced Coffee.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
        /// <summary>
        /// Sets boolean to true to make a decaf coffee.
        /// </summary>
        public void MakeDecaf()
        {
            Decaf = true;
        }
        /// <summary>
        /// Constructor, sets default size to small and ice to false.
        /// </summary>
        public JurassicJava()
        {
            Size = Size.Small;
            Price = .59;
            Calories = 2;
            Ice = false;
        }
        /// <summary>
        /// Returns the name of the drink with Size and whether it is decaf or not.
        /// </summary>
        /// <returns> String of size with/without decaf and name of drink</returns>
        public override string ToString()
        {
            if (Decaf) return $"{Size} Decaf Jurassic Java";
            else return $"{Size} Jurassic Java";
        }
    }
}
