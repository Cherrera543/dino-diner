using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/// <summary>
/// Tyrannotea
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, INotifyPropertyChanged
    {
        public override string Description { get { return this.ToString(); } }
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Lemon) special.Add("Add Lemon");
                if (sweet) special.Add("Make Sweet");
                return special.ToArray();
            }
        }
        private bool sweet;
        private Size size;
        /// <summary>
        /// Boolean of whether the tea has lemon, default is false.
        /// </summary>
        public bool Lemon = false;
        /// <summary>
        /// Boolean of whether it is sweet tea, default is false.
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                switch (value)
                {
                    case true:
                        Calories = Calories * 2;
                        break;
                    case false:
                        if(Size == Size.Small) { Calories = 8; }
                        else if(Size == Size.Medium) { Calories = 16; }
                        else { Calories = 32; }
                        break;
                }
                
            }
        }
        /// <summary>
        /// Override of list of ingredients, includes base ingredients, lemon and sugar added according to their boolean.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Water");
                Ingredients.Add("Tea");
                if (Lemon) Ingredients.Add("Lemon");
                if (Sweet) Ingredients.Add("Cane Sugar");
                return Ingredients;
            }
        }
        /// <summary>
        /// Override of Size property, as Size changes so does Price and calories.
        /// </summary>
        public override Size Size
        {
            get {return size; }
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = .99;
                        if (Sweet) Calories = 16;
                        else Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (Sweet) Calories = 32;
                        else Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        if (Sweet) Calories = 64;
                        else Calories = 32;
                        break;
                }
                NotifyofPropertyChanged("Size");
                NotifyofPropertyChanged("Price");
                NotifyofPropertyChanged("Calories");
            }
        }
        /// <summary>
        /// Method adds Lemon to drink.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyofPropertyChanged("Special");
        }
        /// <summary>
        /// Method makes boolean true, creates a sweet tea.
        /// </summary>
        public void MakeSweet()
        {
            Sweet = true;
            NotifyofPropertyChanged("Special");
            NotifyofPropertyChanged("Price");
            NotifyofPropertyChanged("Calories");
        }
        /// <summary>
        /// Constructor, sets default size to small.
        /// </summary>
        public Tyrannotea()
        {
            Size = Size.Small;
            Ice = true;
        }
        /// <summary>
        /// Creates a string that has the size and says whether it is a sweet tea or not.
        /// </summary>
        /// <returns>Returns a string with size, whether its sweet and name of drink.</returns>
        public override string ToString()
        {
            if (Sweet) return $"{Size} Sweet Tyrannotea";
            else return $"{Size} Tyrannotea";
        }
    }
}
