using System.Collections.Generic;
using System.ComponentModel;
/*PrehistoricPBJ
 * Nathan Bean
 * Modified by Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    {
        public override string Description { get { return this.ToString(); } }
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Boolean that sets peanut butter as an ingredient, default is true.
        /// </summary>
        public bool peanutButter = true;
        /// <summary>
        /// Boolean that sets jelly as an ingredient, default is true.
        /// </summary>
        public bool jelly = true;


        /// <summary>
        /// This creates and returns a list of ingredients, including the default items, and any that may not have been removed.
        /// </summary>
        public override List<string> Ingredients
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
            NotifyofPropertyChanged("Special");
        }
        /// <summary>
        /// This method checks if the user has declined Jelly on the entree and sets the bool to false.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyofPropertyChanged("Special");
        }
        /// <summary>
        /// Creates a string with the entree name.
        /// </summary>
        /// <returns>Returns entree name.</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
