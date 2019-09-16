using System.Collections.Generic;
/*PrehistoricPBJ
 * Nathan Bean
 * Modified by Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ
    {
        private bool peanutButter = true;
        private bool jelly = true;
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
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
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
