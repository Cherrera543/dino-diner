using System.Collections.Generic;
/*PterodactylWings
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings{
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
				List<string> Ingredients = new List<string>(){"Chicken", "Wing Sauce"};
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
		}
	}
}