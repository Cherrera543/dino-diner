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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo combo;
        public CustomizeCombo(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
            if(DataContext is Order order)
            {
                order.Add(combo);
            }
        }
        private void DrinkSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }
        private void SideSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        private void MakeSmall(object sender, RoutedEventArgs e)
        {
            combo.Size = DinoDiner.Menu.Size.Small;
        } 
        private void MakeMedium(object sender, RoutedEventArgs e)
        {
            combo.Size = DinoDiner.Menu.Size.Medium;
        } 
        private void MakeLarge(object sender, RoutedEventArgs e)
        {
            combo.Size = DinoDiner.Menu.Size.Large;
        }
        private void CustomEntree(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreeCustomization(combo));
        }
        private void MainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
