using System.Collections.Generic;
/*SteakosaurusBurger
 * Columba Herrera-Gonzalez
 */
namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger{
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
		
		public bool bun = true;
		public bool pickle = true;
		public bool ketchup = true;
		public bool mustard = true;
        /// <summary>
        /// This method creates a list of ingrediants, it includes required ingredients and checks those that are optional.
        /// </summary>
        public List<string> Ingredients{
			get{
				List<string> Ingredients = new List<string>(){"Steakburger Pattie"};
				if(bun)
                {
                    Ingredients.Add("Whole Wheat Bun");
                }
				if(pickle)
                {
                    Ingredients.Add("Pickle");
                }
				if(ketchup)
                {
                    Ingredients.Add("Ketchup");
                }
				if(mustard)
                {
                    Ingredients.Add("Mustard");
                }
				return Ingredients;
			}
		}
        /// <summary>
        /// This constructor sets the price and calories for the entree.
        /// </summary>
        public SteakosaurusBurger()
        {
			this.Price = 5.15;
			this.Calories = 621;
		}

        /// <summary>
        /// This method checks if the user has declined a bun on the entree and sets the bool to false.
        /// </summary>
        public void HoldBun()
        {
			bun = false;
		}

        /// <summary>
        /// This method checks if the user has declined pickle on the entree and sets the bool to false.
        /// </summary>
		public void HoldPickle()
        {
			pickle = false;
		}
		public void HoldKetchup()
        {
			ketchup= false;
		}

        /// <summary>
        /// This method checks if the user has declined mustard on the entree and sets the bool to false.
        /// </summary>
		public void HoldMustard()
        {
			mustard = false;
		}
	}
}