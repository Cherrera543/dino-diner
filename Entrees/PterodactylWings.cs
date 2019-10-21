using System.Collections.Generic;
using System.ComponentModel;
/*PterodactylWings
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu
{
    public class PterodactylWings: Entree, INotifyPropertyChanged
    {
        public override string Description { get { return this.ToString(); } }
        public override string[] Special { get { return new string[0]; } }
        /// <summary>
        /// This creates and returns a list of ingredients, including the default items, and any that may not have been removed.
        /// </summary>
        public override List<string> Ingredients
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
        /// <summary>
        /// Creates a string with the entree name.
        /// </summary>
        /// <returns>Returns entree name.</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}