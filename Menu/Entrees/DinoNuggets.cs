using System.Collections.Generic;
/*DinoNuggets
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// This creates and returns a list of ingredients, including the default items, and any that may not have been removed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                for (int i = 0; i < NumofNugs; i++)
                {
                    Ingredients.Add("Chicken Nugget");
                }
                return Ingredients;
            }
        }

        /// <summary>
        /// Uint keeps track of the number of nuggets.
        /// </summary>
        private uint NumofNugs = 6;
       
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
            Calories += 59;
		}
        /// <summary>
        /// Creates a string with the entree name.
        /// </summary>
        /// <returns>Returns entree name.</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}