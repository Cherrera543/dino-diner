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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private CretaceousCombo combo;
        private Drink d;
        public DrinkSelection()
        {
            InitializeComponent();
        }
        public DrinkSelection(Drink dr)
        {
            InitializeComponent();
            d = dr;
        }
        public DrinkSelection(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
            d = combo.Drink;
            Button b = new Button();
            b.Content = d.ToString();
            DrinkClick(b, new RoutedEventArgs());

        }
        

        public void DrinkClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            String name = (String)b.Content;
            SpecialOp1.IsEnabled = true;
            SpecialLemon.IsEnabled = true;
            SpecialIce.IsEnabled = true;
            SpecialIce.Content = "Hold Ice";
            SpecialLemon.Content = "Add Lemon";
            switch (name)
            {
                case "Sodasaurus":
                    d = new Sodasaurus();
                    
                    SpecialOp1.Content = "Flavor";
                    SpecialLemon.IsEnabled = false;
                    SpecialIce.IsEnabled = false;
                    break;
                case "Tyrannotea":
                    d = new Tyrannotea();
                    SpecialOp1.Content = "Sweet";
                    SpecialIce.IsEnabled = false;
                    break;
                case "Water":
                    d = new Water();
                    SpecialOp1.IsEnabled = false;
                    SpecialIce.IsEnabled = false;
                    break;
                case "Jurrasic Java":
                    d = new JurassicJava();
                    SpecialOp1.Content = "Decaf";
                    SpecialIce.Content = "Add Ice";
                    SpecialLemon.Content = "Room For\n Cream";
                    break;
            }
            if (combo == null)
            {
                if (DataContext is Order order) order.Items.Add(d);
            }
        }

        public void SpecialButton(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            string sp = (string)b.Content;
            switch (sp)
            {
                case "Hold Ice":
                    d.HoldIce();
                    break;
                case "Add Lemon":
                    if(d is Tyrannotea t)
                    {
                        if (t.Lemon) t.Lemon = false;
                        else t.AddLemon();
                    }
                    if(d is Water w)
                    {
                        if (w.Lemon) w.Lemon = false;
                        else w.AddLemon();
                    }
                    break;
                case "Flavor":
                    if (d is Sodasaurus s) NavigationService.Navigate(new FlavorSelection(s));
                    break;
                case "Sweet":
                    if(d is Tyrannotea ty)
                    {
                        if (ty.Sweet) ty.Sweet = false;
                        else ty.MakeSweet();
                    }
                    break;
                case "Decaf":
                    if(d is JurassicJava j)
                    {
                        if (j.Decaf) j.Decaf = false;
                        else j.MakeDecaf();
                    }
                    break;
                case "Add Ice":
                    if(d is JurassicJava ju)
                    {
                        if (ju.Ice) ju.Ice = false;
                        else ju.AddIce();
                    }
                    break;
                case "Room For\n Cream":
                    if(d is JurassicJava jur)
                    {
                        if (jur.RoomForCream) jur.RoomForCream = false;
                        else jur.LeaveRoomForCream();
                    }
                    break;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (b.Content.Equals("Small"))
            {
                d.Size = DinoDiner.Menu.Size.Small;
                if(combo!=null)combo.Drink.Size = DinoDiner.Menu.Size.Small;
            }else if (b.Content.Equals("Medium"))
            {
                d.Size = DinoDiner.Menu.Size.Medium;
                if(combo!=null)combo.Drink.Size = DinoDiner.Menu.Size.Medium;
            }else if (b.Content.Equals("Large"))
            {
                d.Size = DinoDiner.Menu.Size.Large;
                if(combo!=null)combo.Drink.Size = DinoDiner.Menu.Size.Large;
            }
        }
    }
}
