using System.Collections.Generic;
/*PrehistoricPBJ
 * Nathan Bean
 * Modified by Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ: Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// This creates and returns a list of ingredients, including the default items, and any that may not have been removed.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Bread" };
                if (peanutButter) Ingredients.Add("Peanut Butter");
                if (jelly) Ingredients.Add("Jelly");
                return Ingredients;
            }
        }
        /// <summary>
        /// This constructor sets the price and calories for the entree.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
           
        }
        /// <summary>
        /// This method checks if the user has declined peanut butter on the entree and sets the bool to false.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// <summary>
        /// This method checks if the user has declined Jelly on the entree and sets the bool to false.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
