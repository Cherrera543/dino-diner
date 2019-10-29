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
        private CretaceousCombo combo;
        private Side side;
        public SideSelection()
        {
            InitializeComponent();
            Mezz.Content = "Mezzorella\n Sticks";
            Mac.Content = "Meteor Mac\n And Cheese";
        }
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
            Mezz.Content = "Mezzorella\n Sticks";
            Mac.Content = "Meteor Mac\n And Cheese";
        }
        public SideSelection(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
            side = c.Side;
            side.Size = c.Side.Size;
            Mezz.Content = "Mezzorella\n Sticks";
            Mac.Content = "Meteor Mac\n And Cheese";
        }
       
        void SetSize(DinoDiner.Menu.Size size)
        {
            if (combo != null) combo.Side.Size = size;
            side.Size = size;
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
            SetSize(DinoDiner.Menu.Size.Medium);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            string name = (String)b.Content;
            switch (name)
            {
                case "Fryceritops":
                    if (combo != null)
                    {
                        combo.Side = new Fryceritops(); 
                        combo.Side.Size = side.Size;
                    }
                    side = new Fryceritops(); 
                    break;
                case "Triceritots":
                    if (combo != null)
                    {
                        combo.Side = new Triceritots();
                        combo.Side.Size = side.Size;
                    }
                    side = new Triceritots();
                    break;
                case "Mezzorella\n Sticks":
                    if (combo != null)
                    {
                        combo.Side = new MezzorellaSticks();
                        combo.Side.Size = side.Size;
                    }
                    side = new MezzorellaSticks();
                    break;
                default:
                    if (combo != null)
                    {
                        combo.Side = new MeteorMacAndCheese();
                        combo.Side.Size = side.Size;
                    }
                    side = new MeteorMacAndCheese();
                    break;

            }
            if(DataContext is Order order)
            {
                if (combo == null)
                {
                    order.Items.Add(side);
                }
            }
        }
    }
}
