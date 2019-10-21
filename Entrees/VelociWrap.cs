using System.Collections.Generic;
using System.ComponentModel;
/*VelociWrap
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu
{
    public class VelociWrap : Entree, INotifyPropertyChanged
    {
        public override string Description { get { return this.ToString(); } }
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }
        /// <summary>
        /// These booleans adds these ingredients, their default is true.
        /// </summary>
        public bool dressing = true;
		public bool lettuce = true;
		public bool cheese = true;

        /// <summary>
        /// This creates and returns a list of ingredients, including the default items, and any that may not have been removed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast"};
                if (dressing)
                {
                    Ingredients.Add("Ceasar Dressing");
                }
                if (lettuce)
                {
                    Ingredients.Add("Romaine Lettuce");
                }
                if (cheese)
                {
                    Ingredients.Add("Parmesan Cheese");
                }
                return Ingredients;
            }
        }
        /// <summary>
        /// This constructor sets the price and calories for the entree.
        /// </summary>
        public VelociWrap()
        {
			this.Price = 6.86;
            this.Calories = 356;
            
        }
        /// <summary>
        /// This method checks if the user has declined dressing on the entree and sets the bool to false.
        /// </summary>
        public void HoldDressing()
        {
			dressing =false;
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
        /// This method checks if the user has declined cheese on the entree and sets the bool to false.
        /// </summary>
		public void HoldCheese()
        {
			cheese = false;
            NotifyofPropertyChanged("Special");
        }
        /// <summary>
        /// Creates a string with the entree name.
        /// </summary>
        /// <returns>Returns entree name.</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}