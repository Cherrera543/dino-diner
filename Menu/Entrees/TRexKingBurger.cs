using System.Collections.Generic;
/*TRexKingBurger
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
    {
        
		/// <summary>
        /// These booleans adds these ingredients, their default is true.
        /// </summary>
		public bool bun = true;
		public bool lettuce = true;
		public bool tomato = true;
		public bool onion = true;
		public bool pickle = true;
		public bool ketchup = true;
		public bool mustard = true;
		public bool mayo = true;

        /// <summary>
        /// This creates and returns a list of ingredients, including the default items, and any that may not have been removed.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun)
                {
                    Ingredients.Add("Whole Wheat Bun");
                }
                if (lettuce)
                {
                    Ingredients.Add("Lettuce");
                }
                if (tomato)
                {
                    Ingredients.Add("Tomato");
                }
                if (onion)
                {
                    Ingredients.Add("Onion");
                }
                if (pickle)
                {
                    Ingredients.Add("Pickle");
                }
                if (ketchup)
                {
                    Ingredients.Add("Ketchup");
                }
                if (mustard)
                {
                    Ingredients.Add("Mustard");
                }
                if (mayo)
                {
                    Ingredients.Add("Mayo");
                }
                return Ingredients;
            }
        }
        /// <summary>
        /// This constructor sets the price and calories for the entree.
        /// </summary>
        public TRexKingBurger()
        {
			this.Price = 8.45;
			this.Calories = 728;
            Ingredients.Add("Steakburger Pattie");
            Ingredients.Add("Steakburger Pattie");
            Ingredients.Add("Steakburger Pattie");
            
        }
        /// <summary>
        /// This method checks if the user has declined a bun on the entree and sets the bool to false.
        /// </summary>
        public void HoldBun()
        {
			bun = false;
		}
        /// <summary>
        /// This method checks if the user has declined lettuce on the entree and sets the bool to false.
        /// </summary>
		public void HoldLettuce()
        {
			lettuce = false;
		}

        /// <summary>
        /// This method checks if the user has declined tomato on the entree and sets the bool to false.
        /// </summary>
		public void HoldTomato()
        {
			tomato = false;
		}

        /// <summary>
        /// This method checks if the user has declined onion on the entree and sets the bool to false.
        /// </summary>
		public void HoldOnion()
        {
			onion = false;
		}

        /// <summary>
        /// This method checks if the user has declined pickle on the entree and sets the bool to false.
        /// </summary>
		public void HoldPickle()
        {
			pickle = false;
		}
        /// <summary>
        /// This method checks if the user has declined ketchup on the entree and sets the bool to false.
        /// </summary>
		public void HoldKetchup()
        {
			ketchup = false;
		}

        /// <summary>
        /// This method checks if the user has declined mustard on the entree and sets the bool to false.
        /// </summary>
		public void HoldMustard()
        {
			mustard = false;
		}

        /// <summary>
        /// This method checks if the user has declined mayo on the entree and sets the bool to false.
        /// </summary>
		public void HoldMayo()
        {
			mayo = false;
		}
        /// <summary>
        /// Creates a string with the entree name.
        /// </summary>
        /// <returns>Returns entree name.</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}