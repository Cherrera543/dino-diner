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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus soda;
        public FlavorSelection(Sodasaurus s)
        {
            InitializeComponent();
            soda = s;
        }

        private void CherryClick(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Cherry;
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }
        private void ColaClick(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Cola;
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }
        private void ChocoClick(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Chocolate;
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }
        private void GrapeClick(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Grape;
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }
        private void LimeClick(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Lime;
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }
        private void OrangeClick(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Orange;
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }
        private void RootClick(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.RootBeer;
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }
        private void VanillaClick(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Vanilla;
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }
    }
}
