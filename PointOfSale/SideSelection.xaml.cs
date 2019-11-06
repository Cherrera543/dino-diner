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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        //RETURN TO CUSTOMIZE PAGE BUTTON FROM MAIN MENU BUTTON
        private Side side;
        private CretaceousCombo combo;
        public SideSelection()
        {
            InitializeComponent();
            Navi.Content = "Back to Main Menu";
            Navi.Click += MainMenu;
            Mezz.Content = "Mezzorella\n Sticks";
            Mac.Content = "Meteor Mac\n And Cheese";
        }
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
            Navi.Content = "Back to Main Menu";
            Navi.Click += MainMenu;
            Mezz.Content = "Mezzorella\n Sticks";
            Mac.Content = "Meteor Mac\n And Cheese";
        }

        public SideSelection(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
            Navi.Content = "Back to Customize";
            Navi.Click += Customize;
            Mezz.Content = "Mezzorella\n Sticks";
            Mac.Content = "Meteor Mac\n And Cheese";
        }

        public void MainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        public void Customize(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(combo));
        }
        
        void SetSize(DinoDiner.Menu.Size size)
        {
            if (combo == null) { side.Size = size; }
            else { combo.Side.Size = size; }
        }
        protected void OnClickLarge(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Large);
        }
        protected void OnClickMedium(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Medium);
        }
        protected void OnClickSmall(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Small);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            string name = (String)b.Content;
            switch (name)
            {
                case "Fryceritops":
                    if (combo == null) { side = new Fryceritops(); }
                    else { combo.Side = new Fryceritops(); }
                    break;
                case "Triceritots":
                    if (combo == null) { side = new Triceritots(); }
                    else { combo.Side = new Triceritots(); }
                    break;
                case "Mezzorella\n Sticks":
                    if (combo == null) { side = new MezzorellaSticks(); }
                    else { combo.Side = new MezzorellaSticks(); }
                    break;
                default:
                    if (combo == null) { side = new MeteorMacAndCheese(); }
                    else { combo.Side = new MeteorMacAndCheese(); }
                    break;

            }
            if(DataContext is Order order)
            {
                if (combo == null) { order.Add(side); }
            }
        }
    }
}
