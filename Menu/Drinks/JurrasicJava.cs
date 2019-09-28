using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        public bool RoomForCream = false;
        public bool Decaf = false;
        
        public List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Water");
                Ingredients.Add("Coffee");
                return Ingredients;
            }
        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        public void AddIce()
        {
            Ice = true;
        }

        public void MakeDecaf()
        {
            Decaf = true;
        }

        public JurrasicJava()
        {
            Size = Size.Small;
            Price = .59;
            Calories = 2;
            Ice = false;
        }
    }
}
