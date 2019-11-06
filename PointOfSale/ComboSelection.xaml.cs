using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        private CretaceousCombo combo;
        private Boolean newcombo;
        public ComboSelection()
        {
            InitializeComponent();
            combo = new CretaceousCombo(new Brontowurst());
            newcombo = true;
            
        }
        public ComboSelection(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
            newcombo = false;
        }

        private void Customize(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            string name = (String)b.Content;
            switch (name)
            {
                case "Brontowurst Combo":
                    if (newcombo) { combo.Entree = new Brontowurst(); }
                    break;
                case "Dino-Nuggets Combo":
                    if (newcombo) { combo.Entree = new DinoNuggets(); }
                    break;
                case "Prehistoric PB&amp;J Combo":
                    if (newcombo) { combo.Entree = new PrehistoricPBJ(); }
                    break;
                case "Pterodactyl Wings Combo":
                    if (newcombo) { combo.Entree = new PterodactylWings(); }
                    break;
                case "Steakasaurus Burger Combo":
                    if (newcombo) { combo.Entree = new SteakosaurusBurger(); }
                    break;
                case "T Rex King Burger Combo":
                    if (newcombo) { combo.Entree = new TRexKingBurger(); }
                    break;
                default:
                    if(newcombo){ combo.Entree = new VelociWrap(); }
                    break;
            }
            if(DataContext is Order o)
            {
                if (newcombo)
                {
                    o.Add(combo);
                }
            }
            if (combo.Entree is PterodactylWings p)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else { NavigationService.Navigate(new EntreeCustomization(combo)); }
        }
    }
}
