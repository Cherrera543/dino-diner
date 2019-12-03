using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Menu
/// Columba Herrera-Gonzalez
/// </summary>
namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// Creates a list with an instance of every available menu item.
        /// </summary>
        public List<MenuItem> AvailableMenuItems
        {
            get
            {
                List<MenuItem> menuitmes = new List<MenuItem>();
                menuitmes.Add(new JurassicJava());
                menuitmes.Add(new Sodasaurus());
                menuitmes.Add(new Tyrannotea());
                menuitmes.Add(new Water());
                menuitmes.Add(new Brontowurst());
                menuitmes.Add(new DinoNuggets());
                menuitmes.Add(new PrehistoricPBJ());
                menuitmes.Add(new PterodactylWings());
                menuitmes.Add(new SteakosaurusBurger());
                menuitmes.Add(new TRexKingBurger());
                menuitmes.Add(new VelociWrap());
                menuitmes.Add(new Fryceritops());
                menuitmes.Add(new MeteorMacAndCheese());
                menuitmes.Add(new MezzorellaSticks());
                menuitmes.Add(new Triceritots());
                return menuitmes;
            }
        }
        /// <summary>
        /// Creates a list with every available side.
        /// </summary>
        public List<MenuItem> AvailableSide
        {
            get
            {
                List<MenuItem> menuitmes = new List<MenuItem>();
                menuitmes.Add(new Fryceritops());
                menuitmes.Add(new MeteorMacAndCheese());
                menuitmes.Add(new MezzorellaSticks());
                menuitmes.Add(new Triceritots());
                return menuitmes;
            }
        }
        /// <summary>
        /// Creates a list with every available drink.
        /// </summary>
        public List<MenuItem> AvailableDrinks
        {
            get
            {
                List<MenuItem> menuitmes = new List<MenuItem>();
                menuitmes.Add(new JurassicJava());
                menuitmes.Add(new Sodasaurus());
                menuitmes.Add(new Tyrannotea());
                menuitmes.Add(new Water());
                return menuitmes;
            }
        }
        /// <summary>
        /// Creates a list with every available entree.
        /// </summary>
        public List<MenuItem> AvailableEntrees
        {
            get
            {
                List<MenuItem> menuitmes = new List<MenuItem>();
                menuitmes.Add(new Brontowurst());
                menuitmes.Add(new DinoNuggets());
                menuitmes.Add(new PrehistoricPBJ());
                menuitmes.Add(new PterodactylWings());
                menuitmes.Add(new SteakosaurusBurger());
                menuitmes.Add(new TRexKingBurger());
                menuitmes.Add(new VelociWrap());
                return menuitmes;
            }
        }
        /// <summary>
        /// Creates a list with every combo made by every entree.
        /// </summary>
        public List<MenuItem> AvailableCombos
        {
            get
            {
                List<MenuItem> AvailableCombos = new List<MenuItem>();
                foreach(Entree m in AvailableEntrees)
                {
                    AvailableCombos.Add(new CretaceousCombo(m));
                }
                return AvailableCombos;
            }
        }
        public List<String> PossibleIngredients
        {
            get
            {
                List<String> pos = new List<String>();
                foreach (MenuItem m in AvailableCombos)
                {
                    foreach (String i in m.Ingredients) { if (!pos.Contains(i)) { pos.Add(i); } }
                }
                foreach (MenuItem m in AvailableEntrees)
                {
                    foreach (String i in m.Ingredients) { if (!pos.Contains(i)) { pos.Add(i); } }
                }
                foreach (MenuItem m in AvailableSide)
                {
                    foreach (String i in m.Ingredients) { if (!pos.Contains(i)) { pos.Add(i); } }
                }
                foreach (MenuItem m in AvailableDrinks)
                {
                    foreach (String i in m.Ingredients) { if (!pos.Contains(i)) { pos.Add(i); } }
                }
                return pos;
            }
        }
        /// <summary>
        /// Creates a stringbuilder that contains the name of every menu item
        /// </summary>
        /// <returns>Returns a string with the name of every item on the menu.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Menu:\n");
            foreach(MenuItem m in AvailableMenuItems)
            {
                string full = m.ToString();
                string[] tokens = full.Split(' ');
                if(tokens[0].Equals("Small") || tokens[0].Equals("Medium") || tokens[0].Equals("Large"))
                {
                    for(int i=1; i<tokens.Length; i++)
                    {
                        sb.Append(tokens[i]);
                        if (i == tokens.Length - 1) sb.Append("\n");
                    }
                }
                else { sb.Append(full + "\n"); }
            }
            return sb.ToString();
        }
    }
}
