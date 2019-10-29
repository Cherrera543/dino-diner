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
        public ComboSelection()
        {
            InitializeComponent();
            
        }
        public ComboSelection(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
        }

        private void Customize(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            string name = (String)b.Content;
            Entree entree;
            switch (name)
            {
                case "Brontowurst Combo":
                    entree = new Brontowurst();
                    break;
                case "Dino-Nuggets Combo":
                    entree = new DinoNuggets();
                    break;
                case "Prehistoric PB&amp;J Combo":
                    entree = new PrehistoricPBJ();
                    break;
                case "Pterodactyl Wings Combo":
                    entree = new PterodactylWings();
                    break;
                case "Steakosaurus Burger Combo":
                    entree = new SteakosaurusBurger();
                    break;
                case "T Rex King Burger Combo":
                    entree = new TRexKingBurger();
                    break;
                default:
                    entree = new VelociWrap();
                    break;
            }
            combo = new CretaceousCombo(entree);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }
    }
}
