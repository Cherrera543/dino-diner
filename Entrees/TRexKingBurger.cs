using System.Collections.Generic;
using System.ComponentModel;
/*TRexKingBurger
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree, INotifyPropertyChanged
    {
        public override string Description { get { return this.ToString(); } }
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }
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
        public override List<string> Ingredients
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
            NotifyofPropertyChanged("Special");
        }
        /// <summary>
        /// This method checks if the user has declined lettuce on the entree and sets the bool to false.
        /// </summary>
		public void HoldLettuce()
        {
			lettuce = false;
            NotifyofPropertyChanged("Special");
        }

        /// <summary>
        /// This method checks if the user has declined tomato on the entree and sets the bool to false.
        /// </summary>
		public void HoldTomato()
        {
			tomato = false;
            NotifyofPropertyChanged("Special");
        }

        /// <summary>
        /// This method checks if the user has declined onion on the entree and sets the bool to false.
        /// </summary>
		public void HoldOnion()
        {
			onion = false;
            NotifyofPropertyChanged("Special");
        }

        /// <summary>
        /// This method checks if the user has declined pickle on the entree and sets the bool to false.
        /// </summary>
		public void HoldPickle()
        {
			pickle = false;
            NotifyofPropertyChanged("Special");
        }
        /// <summary>
        /// This method checks if the user has declined ketchup on the entree and sets the bool to false.
        /// </summary>
		public void HoldKetchup()
        {
			ketchup = false;
            NotifyofPropertyChanged("Special");
        }

        /// <summary>
        /// This method checks if the user has declined mustard on the entree and sets the bool to false.
        /// </summary>
		public void HoldMustard()
        {
			mustard = false;
            NotifyofPropertyChanged("Special");
        }

        /// <summary>
        /// This method checks if the user has declined mayo on the entree and sets the bool to false.
        /// </summary>
		public void HoldMayo()
        {
			mayo = false;
            NotifyofPropertyChanged("Special");
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