using System.Collections.Generic;
/*DinoNuggets
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets{
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

        uint NumofNugs = 6;
        /// <summary>
        /// This method creates a list of ingrediants, it includes required ingredients and checks those that are optional.
        /// </summary>
		public List<string> Ingredients{
			get
            {
				List<string> Ingredients = new List<string>();
				for(int i =0; i<NumofNugs; i++)
                {
					Ingredients.Add("Chicken Nugget");
				}
				return Ingredients;
			}
		}
        /// <summary>
        /// This constructor sets the price and calories for the entree.
        /// </summary>
        public DinoNuggets()
        {
			this.Price = 4.25;
            this.Calories = 59 * NumofNugs;
		}
		
        /// <summary>
        /// This method adds a nugget to the order and 25 cents to the total price.
        /// </summary>
		public void AddNugget()
        {
			NumofNugs++;
			Price+=.25;
		}
	}
}