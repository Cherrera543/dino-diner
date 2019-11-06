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
        private Drink d;
        private CretaceousCombo combo;
        private bool newdrink;
        public DrinkSelection()
        {
            InitializeComponent();
            Backbutton.Content = "<--Go Back to Main Menu";
            Backbutton.Click += Mainmenu;
            newdrink = true;
        }
        public DrinkSelection(Drink dr)
        {
            InitializeComponent();
            d = dr;
            string name = "";
            if(d is Sodasaurus s) { name = "Sodasaurus"; }
            else if (d is Tyrannotea t) { name = "Tyrannotea"; }
            else if (d is Water w) { name = "Water"; }
            else if (d is JurassicJava j) { name = "Jurrasic Java"; }
            ButtonArrange(name);
            Backbutton.Content = "<--Go Back to Main Menu";
            Backbutton.Click += Mainmenu;
            newdrink = false;
        }
        public DrinkSelection(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
            Backbutton.Content = "<--Go Back to Custom";
            newdrink = false;
        }

        public void Mainmenu(object sender, RoutedEventArgs e) { NavigationService.Navigate(new MenuCategorySelection()); }
        public void Customize(object sender, RoutedEventArgs e) { NavigationService.GoBack(); }

        private void ButtonArrange(string s)
        {
            SpecialOp1.IsEnabled = true;
            SpecialLemon.IsEnabled = true;
            SpecialIce.IsEnabled = true;
            SpecialIce.Content = "Hold Ice";
            SpecialLemon.Content = "Add Lemon";
            switch (s)
            {

                case "Sodasaurus":
                    SpecialOp1.Content = "Flavor";
                    SpecialLemon.IsEnabled = false;
                    SpecialIce.IsEnabled = false;
                    break;
                case "Tyrannotea":
                    SpecialOp1.Content = "Sweet";
                    SpecialIce.IsEnabled = false;
                    break;
                case "Jurrasic Java":
                    SpecialOp1.Content = "Decaf";
                    SpecialIce.Content = "Add Ice";
                    SpecialLemon.Content = "Room For\n Cream";
                    break;
                case "Water":
                    SpecialOp1.IsEnabled = false;
                    SpecialIce.IsEnabled = false;
                    break;
            }
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
                    if (combo == null) { d = new Sodasaurus(); }
                    else { combo.Drink = new Sodasaurus(); }
                    SpecialOp1.Content = "Flavor";
                    SpecialLemon.IsEnabled = false;
                    SpecialIce.IsEnabled = false;
                    break;
                case "Tyrannotea":
                    if (combo == null) { d = new Tyrannotea(); }
                    else { combo.Drink = new Tyrannotea(); }
                    SpecialOp1.Content = "Sweet";
                    SpecialIce.IsEnabled = false;
                    break;
                case "Water":
                    if (combo == null) { d = new Water(); }
                    else { combo.Drink = new Water(); }
                    SpecialOp1.IsEnabled = false;
                    SpecialIce.IsEnabled = false;
                    break;
                case "Jurrasic Java":
                    if (combo == null) { d = new JurassicJava(); }
                    else { combo.Drink = new JurassicJava(); }
                    SpecialOp1.Content = "Decaf";
                    SpecialIce.Content = "Add Ice";
                    SpecialLemon.Content = "Room For\n Cream";
                    break;
            }

            if (DataContext is Order order) { if (newdrink) { order.Add(d); } };
            
        }

        public void SpecialButton(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            string sp = (string)b.Content;
            if (combo == null)
            {
                switch (sp)
                {
                    case "Hold Ice":
                        d.HoldIce();
                        break;
                    case "Add Lemon":
                        if (d is Tyrannotea t) { t.AddLemon(); }
                        if (d is Water w) { w.AddLemon(); }
                        break;
                    case "Flavor":
                        if (d is Sodasaurus s) { NavigationService.Navigate(new FlavorSelection(s)); }
                        break;
                    case "Sweet":
                        if (d is Tyrannotea ty) { ty.MakeSweet(); }
                        break;
                    case "Decaf":
                        if (d is JurassicJava j) { j.MakeDecaf(); }
                        break;
                    case "Add Ice":
                        if (d is JurassicJava ju) { ju.AddIce(); }
                        break;
                    case "Room For\n Cream":
                        if (d is JurassicJava jur) { jur.LeaveRoomForCream(); }
                        break;
                }
            }
            else { SpecialButtonE(sp); }
        }

        private void SpecialButtonE(string sp)
        {
            switch (sp)
            {
                case "Hold Ice":
                    combo.Drink.HoldIce();
                    break;
                case "Add Lemon":
                    if (combo.Drink is Tyrannotea t) { t.AddLemon(); }
                    if (combo.Drink is Water w) { w.AddLemon(); }
                    break;
                case "Flavor":
                    if (combo.Drink is Sodasaurus s) { NavigationService.Navigate(new FlavorSelection(s)); }
                    break;
                case "Sweet":
                    if (combo.Drink is Tyrannotea ty) { ty.MakeSweet(); }
                    break;
                case "Decaf":
                    if (combo.Drink is JurassicJava j) { j.MakeDecaf(); }
                    break;
                case "Add Ice":
                    if (combo.Drink is JurassicJava ju) { ju.AddIce(); }
                    break;
                case "Room For\n Cream":
                    if (combo.Drink is JurassicJava jur) { jur.LeaveRoomForCream(); }
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (b.Content.Equals("Small"))
            {
                if (combo == null)
                {
                    if (d is Drink a) { a.Size = DinoDiner.Menu.Size.Small; }
                }
                else { if(combo.Drink is Drink a) { a.Size = DinoDiner.Menu.Size.Small; } }
            }
            else if (b.Content.Equals("Medium"))
            {
                if (combo == null)
                {
                    if (d is Drink a) { a.Size = DinoDiner.Menu.Size.Medium; }
                }
                else { if (combo.Drink is Drink a) { a.Size = DinoDiner.Menu.Size.Medium; } }
            }
            else if (b.Content.Equals("Large"))
            {
                if (combo == null)
                {
                    if (d is Drink a) { a.Size = DinoDiner.Menu.Size.Large; }
                }
                else { if (combo.Drink is Drink a) { a.Size = DinoDiner.Menu.Size.Large; } }
            }
        }

        public void BackButton(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
