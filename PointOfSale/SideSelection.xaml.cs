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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public SideSelection()
        {
            InitializeComponent();
            DataContext = null;
        }
        public SideSelection(Side side)
        {
            InitializeComponent();
            DataContext = side;
        }

        void SetSizeButtonEnabled(bool isEnabled)
        {
            MakeLarge.IsEnabled = isEnabled;
            MakeMedium.IsEnabled = isEnabled;
            MakeSmall.IsEnabled = isEnabled;
        }
        void SetSize(Size size)
        {

        }
        protected void OnClickLarge(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Large);
        }
    }
}
