using System.Collections.Generic;
/*VelociWrap
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap{
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
		
		public bool dressing = true;
		public bool lettuce = true;
		public bool cheese = true;
        /// <summary>
        /// This method creates a list of ingrediants, it includes required ingredients and checks those that are optional.
        /// </summary>
        public List<string> Ingredients
        {
			get
            {
                List<string> Ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
				if(dressing)
                {
                    Ingredients.Add("Ceasar Dressing");
                }
				if(lettuce)
                {
                    Ingredients.Add("Romaine Lettuce");
                }
				if(cheese)
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
		}
        /// <summary>
        /// This method checks if the user has declined lettuce on the entree and sets the bool to false.
        /// </summary>
		public void HoldLettuce()
        {
			lettuce = false;
		}
        /// <summary>
        /// This method checks if the user has declined cheese on the entree and sets the bool to false.
        /// </summary>
		public void HoldCheese()
        {
			cheese = false;
		}
	}
}