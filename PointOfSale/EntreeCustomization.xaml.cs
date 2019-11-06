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
    /// Interaction logic for EntreeCustomization.xaml
    /// </summary>
    public partial class EntreeCustomization : Page
    {
        private CretaceousCombo combo;
        private Entree entree;
        private string name;

        public EntreeCustomization(Entree e)
        {
            InitializeComponent();
            entree = e;
            name = e.ToString();
            ArrangeButton();
            Customizebutton.Click += MainMenu;
            Customizebutton.Content = "To Main Menu--";
        }
        public EntreeCustomization(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
            name = c.Entree.ToString();
            ArrangeButton();
            Customizebutton.Click += CustomButton;
        }

        private void ArrangeButton()
        {
            Button b = new Button();
            b.Content = "Hold Bun";
            b.Click += SpecialButton;
            Button o = new Button();
            o.Content = "Hold Onion";
            o.Click += SpecialButton;
            Button pickle = new Button();
            pickle.Content = "Hold Pickle";
            pickle.Click += SpecialButton;
            Button ket = new Button();
            ket.Content = "Hold Ketchup";
            ket.Click += SpecialButton;
            Button mus = new Button();
            mus.Content = "Hold Mustard";
            mus.Click += SpecialButton;
            Button let = new Button();
            let.Content = "Hold Lettuce";
            let.Click += SpecialButton;
            switch (name)
            {
                case "Brontowurst":
                    Button p = new Button();
                    p.Content = "Hold Pepper";
                    p.Click += SpecialButton;
                    stack.Children.Add(p);
                    stack.Children.Add(o);
                    stack.Children.Add(b);
                    break;
                case "Dino-Nuggets":
                    Button a = new Button();
                    a.Content = "Add Nuggets";
                    a.Click += SpecialButton;
                    stack.Children.Add(a);
                    break;
                case "Prehistoric PB&J":
                    Button pe = new Button();
                    pe.Content = "Hold Peanut Butter";
                    pe.Click += SpecialButton;
                    Button j = new Button();
                    j.Content = "Hold Jelly";
                    j.Click += SpecialButton;
                    stack.Children.Add(pe);
                    stack.Children.Add(j);
                    break;
                case "Steakosaurus Burger":
                    stack.Children.Add(b);
                    stack.Children.Add(pickle);
                    stack.Children.Add(ket);
                    stack.Children.Add(mus);
                    break;
                case "T-Rex King Burger":
                    Button tom = new Button();
                    tom.Content = "Hold Tomato";
                    tom.Click += SpecialButton;
                    Button mayo = new Button();
                    mayo.Content = "Hold Mayo";
                    mayo.Click += SpecialButton;
                    stack.Children.Add(b);
                    stack.Children.Add(let);
                    stack.Children.Add(tom);
                    stack.Children.Add(o);
                    stack.Children.Add(pickle);
                    stack.Children.Add(ket);
                    stack.Children.Add(mus);
                    stack.Children.Add(mayo);
                    break;
                case "Veloci-Wrap":
                    Button dress = new Button();
                    dress.Content = "Hold Dressing";
                    dress.Click += SpecialButton;
                    Button cheese = new Button();
                    cheese.Content = "Hold Cheese";
                    cheese.Click += SpecialButton;
                    if (stack != null)
                    {
                        stack.Children.Add(dress);
                        stack.Children.Add(let);
                        stack.Children.Add(cheese);
                    }
                    break;
            }
        }
        private void SpecialButton(object sender, RoutedEventArgs e)
        {
            Button sp = (Button)sender;
            string special = (string)sp.Content;
            if (combo == null) SpecialButtonE(special);
            else
            {
                switch (special)
                {
                    case "Hold Bun":
                        if (combo.Entree is Brontowurst b) { b.HoldBun(); }
                        if (combo.Entree is SteakosaurusBurger s) { s.HoldBun(); }
                        if (combo.Entree is TRexKingBurger t) { t.HoldBun(); }
                        break;
                    case "Hold Onion":
                        if (combo.Entree is Brontowurst br) { br.HoldOnion(); }
                        if (combo.Entree is TRexKingBurger tr) { tr.HoldOnion(); }
                        break;
                    case "Hold Pickle":
                        if (combo.Entree is SteakosaurusBurger sb) { sb.HoldPickle(); }
                        if (combo.Entree is TRexKingBurger trk) { trk.HoldPickle(); }
                        break;
                    case "Hold Ketchup":
                        if (combo.Entree is SteakosaurusBurger sbr) { sbr.HoldKetchup(); }
                        if (combo.Entree is TRexKingBurger trkb) { trkb.HoldKetchup(); }
                        break;
                    case "Hold Mustard":
                        if (combo.Entree is SteakosaurusBurger skb) { skb.HoldMustard(); }
                        if (combo.Entree is TRexKingBurger trkr) { trkr.HoldMustard(); }
                        break;
                    case "Hold Lettuce":
                        if (combo.Entree is TRexKingBurger tkr) { tkr.HoldLettuce(); }
                        if (combo.Entree is VelociWrap v) { v.HoldLettuce(); }
                        break;
                    case "Hold Pepper":
                        if (combo.Entree is Brontowurst bw) { bw.HoldPeppers(); }
                        break;
                    case "Add Nuggets":
                        if (combo.Entree is DinoNuggets d) { d.AddNugget(); }
                        break;
                    case "Hold Peanut Butter":
                        if (combo.Entree is PrehistoricPBJ pb) { pb.HoldPeanutButter(); }
                        break;
                    case "Hold Jelly":
                        if (combo.Entree is PrehistoricPBJ pbj) { pbj.HoldJelly(); }
                        break;
                    case "Hold Tomato":
                        if (combo.Entree is TRexKingBurger tkb) { tkb.HoldTomato(); }
                        break;
                    case "Hold Mayo":
                        if (combo.Entree is TRexKingBurger tb) { tb.HoldMayo(); }
                        break;
                    case "Hold Dressing":
                        if (combo.Entree is VelociWrap vw) { vw.HoldDressing(); }
                        break;
                    case "Hold Cheese":
                        if (combo.Entree is VelociWrap w) { w.HoldCheese(); }
                        break;
                }
            }
        }

        private void SpecialButtonE(string special)
        {
            switch (special)
            {
                case "Hold Bun":
                    if (entree is Brontowurst b) { b.HoldBun(); }
                    if (entree is SteakosaurusBurger s) { s.HoldBun(); }
                    if (entree is TRexKingBurger t) { t.HoldBun(); }
                    break;
                case "Hold Onion":
                    if (entree is Brontowurst br) { br.HoldOnion(); }
                    if (entree is TRexKingBurger tr) { tr.HoldOnion(); }
                    break;
                case "Hold Pickle":
                    if (entree is SteakosaurusBurger sb) { sb.HoldPickle(); }
                    if (entree is TRexKingBurger trk) { trk.HoldPickle(); }
                    break;
                case "Hold Ketchup":
                    if (entree is SteakosaurusBurger sbr) { sbr.HoldKetchup(); }
                    if (entree is TRexKingBurger trkb) { trkb.HoldKetchup(); }
                    break;
                case "Hold Mustard":
                    if (entree is SteakosaurusBurger skb) { skb.HoldMustard(); }
                    if (entree is TRexKingBurger trkr) { trkr.HoldMustard(); }
                    break;
                case "Hold Lettuce":
                    if (entree is TRexKingBurger tkr) { tkr.HoldLettuce(); }
                    if (entree is VelociWrap v) { v.HoldLettuce(); }
                    break;
                case "Hold Pepper":
                    if (entree is Brontowurst bw) { bw.HoldPeppers(); }
                    break;
                case "Add Nuggets":
                    if (entree is DinoNuggets d) { d.AddNugget(); }
                    break;
                case "Hold Peanut Butter":
                    if (entree is PrehistoricPBJ pb) { pb.HoldPeanutButter(); }
                    break;
                case "Hold Jelly":
                    if (entree is PrehistoricPBJ pbj) { pbj.HoldJelly(); }
                    break;
                case "Hold Tomato":
                    if (entree is TRexKingBurger tkb) { tkb.HoldTomato(); }
                    break;
                case "Hold Mayo":
                    if (entree is TRexKingBurger tb) { tb.HoldMayo(); }
                    break;
                case "Hold Dressing":
                    if (entree is VelociWrap vw) { vw.HoldDressing(); }
                    break;
                case "Hold Cheese":
                    if (entree is VelociWrap w) { w.HoldCheese(); }
                    break;
            }
        }

        public void BackButton(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        public void CustomButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(combo));
        }
        public void MainMenu(object sender,RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
