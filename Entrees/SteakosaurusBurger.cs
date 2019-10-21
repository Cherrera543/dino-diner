using System.Collections.Generic;
using System.ComponentModel;
/*SteakosaurusBurger
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree, INotifyPropertyChanged
    {
        public override string Description { get { return this.ToString(); } }
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Boolean sets bun as an ingredient, default is true.
        /// </summary>
        public bool bun = true;
        /// <summary>
        /// Boolean sets pickles as an ingredient, default is true.
        /// </summary>
		public bool pickle = true;
        /// <summary>
        /// Boolean sets ketchup as an ingredient, default is true.
        /// </summary>
		public bool ketchup = true;
        /// <summary>
        /// Boolean sets mustard as an ingredient, default is true.
        /// </summary>
		public bool mustard = true;

        /// <summary>
        /// This creates and returns a list of ingredients, including the default items, and any that may not have been removed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Steakburger Pattie"};
                if (bun)
                {
                    Ingredients.Add("Whole Wheat Bun");
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
                return Ingredients;
            }
        }
        /// <summary>
        /// This constructor sets the price and calories for the entree.
        /// </summary>
        public SteakosaurusBurger()
        {
			this.Price = 5.15;
			this.Calories = 621;
           
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
        /// This method checks if the user has declined pickle on the entree and sets the bool to false.
        /// </summary>
		public void HoldPickle()
        {
			pickle = false;
            NotifyofPropertyChanged("Special");
		}
        /// <summary>
        /// This method checks if the user has declined ketchup on the entree.
        /// </summary>
		public void HoldKetchup()
        {
			ketchup= false;
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
        /// Creates a string with the entree name.
        /// </summary>
        /// <returns>Returns entree name.</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}