using System.Collections.Generic;
/*PterodactylWings
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings: Entree
    {
        /// <summary>
        /// This creates and returns a list of ingredients, including the default items, and any that may not have been removed.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return Ingredients;
            }
        }
       
        /// <summary>
        /// This constructor sets the price and calories for the entree.
        /// </summary>
        public PterodactylWings()
        {
			this.Price = 7.21;
			this.Calories  = 318;
            Ingredients.Add("Chicken");
            Ingredients.Add("Wing Sauce");
		}
	}
}