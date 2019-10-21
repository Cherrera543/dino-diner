using System.Collections.Generic;
using System.ComponentModel;
/*Brontowurst
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu
{
    public class Brontowurst : Entree, INotifyPropertyChanged
    {
        public override string Description { get { return this.ToString(); } }
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!peppers) special.Add("Hold Pepper");
                if (!onions) special.Add("Hold Onion");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Boolean sets bun ingredient as included.
        /// </summary>
		public bool bun = true;
        /// <summary>
        /// Boolean sets pepper ingredient as included.
        /// </summary>
		public bool peppers = true;
        /// <summary>
        /// Boolean sets onion pepper as included.
        /// </summary>
		public bool onions = true;
        /// <summary>
        /// This creates and returns a list of ingredients, including the default items, and any that may not have been removed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Brautwurst" };
                if (bun)
                {
                    Ingredients.Add("Whole Wheat Bun");
                }
                if (peppers)
                {
                    Ingredients.Add("Peppers");
                }
                if (onions)
                {
                    Ingredients.Add("Onion");
                }
                return Ingredients;
            }
        }
        /// <summary>
        /// This constructor sets the price and calories for the entree.
        /// </summary>
        public Brontowurst()
        {
			this.Price = 5.36;
			this.Calories = 498;
            
        }

        /// <summary>
        /// This method checks if the user has declined a bun on the entree and sets the bool to false.
        /// </summary>
        public void HoldBun()
        {
			this.bun = false;
            NotifyofPropertyChanged("Special");
		}

        /// <summary>
        /// This method checks if the user has declined peppers on the entree and sets the bool to false.
        /// </summary>
		public void HoldPeppers()
        {
			this.peppers = false;
            NotifyofPropertyChanged("Special");
        }

        /// <summary>
        /// This method checks if the user has declined onion on the entree and sets the bool to false.
        /// </summary>
		public void HoldOnion()
        {
			this.onions = false;
            NotifyofPropertyChanged("Special");
        }
        /// <summary>
        /// Creates a string with the entree name.
        /// </summary>
        /// <returns>Returns entree name.</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}