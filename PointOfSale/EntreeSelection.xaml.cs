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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree;
        public EntreeSelection()
        {
            InitializeComponent();
        }
        public EntreeSelection(Entree e)
        {
            InitializeComponent();
            entree = e;
        }
        private void AddEntree()
        {
            if(DataContext is Order order)
            {
                order.Items.Add(entree);
            }
        }
        private void BrontoClick(object sender, RoutedEventArgs e)
        {
            entree = new Brontowurst();
            AddEntree();
            NavigationService.Navigate(new MenuCategorySelection());
        }
        private void DinoClick(object sender, RoutedEventArgs e)
        {
            entree = new DinoNuggets();
            AddEntree();
            NavigationService.Navigate(new MenuCategorySelection());
        }
        private void PrehistoricClick(object sender, RoutedEventArgs e)
        {
            entree = new PrehistoricPBJ();
            AddEntree();
            NavigationService.Navigate(new MenuCategorySelection());
        }
        private void WingClick(object sender, RoutedEventArgs e)
        {
            entree = new PterodactylWings();
            AddEntree();
            NavigationService.Navigate(new MenuCategorySelection());
        }
        private void SteakClick(object sender, RoutedEventArgs e)
        {
            entree = new SteakosaurusBurger();
            AddEntree();
            NavigationService.Navigate(new MenuCategorySelection());
        }
        private void TRexClick(object sender, RoutedEventArgs e)
        {
            entree = new TRexKingBurger();
            AddEntree();
            NavigationService.Navigate(new MenuCategorySelection());
        }
        private void WrapClick(object sender, RoutedEventArgs e)
        {
            entree = new VelociWrap();
            AddEntree();
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
