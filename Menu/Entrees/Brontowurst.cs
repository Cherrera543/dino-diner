using System.Collections.Generic;
/*Brontowurst
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst{
		
		public bool bun = true;
		public bool peppers = true;
		public bool onions = true;
        /// <summary>
        /// This method allows the price property to be set and reached from other classes.
        /// </summary>
        public double Price
        {
            get; set;
        }
        /// <summary>
        /// This method allows the calories property to be set and reached from other classes.
        /// </summary>
		public uint Calories
        {
            get; set;
        }
        /// <summary>
        /// This method creates a list of ingrediants, it includes required ingredients and checks those that are optional.
        /// </summary>
        public List<string> Ingredients{
			get{
				List<string> Ingredients = new List<string>() {"Brautwurst"};
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
		}

        /// <summary>
        /// This method checks if the user has declined peppers on the entree and sets the bool to false.
        /// </summary>
		public void HoldPeppers()
        {
			this.peppers = false;
		}

        /// <summary>
        /// This method checks if the user has declined onion on the entree and sets the bool to false.
        /// </summary>
		public void HoldOnion()
        {
			this.onions = false;
		}
	}
}