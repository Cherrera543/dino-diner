﻿using DinoDiner.Menu;
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public NavigationService NavigationService { get; set; }
        public OrderControl()
        {
            InitializeComponent();
            MountItemListener();
        }
        public void OnSelectionChanged(object sender, EventArgs e)
        {
            if(itemsList.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            else if(itemsList.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
            else if(itemsList.SelectedItem is Entree entree)
            {
                NavigationService?.Navigate(new EntreeSelection(entree));
            }
            else if(itemsList.SelectedItem is CretaceousCombo c)
            {
                NavigationService?.Navigate(new ComboSelection(c));
            }
        }

        public void OnDataContextChanged(Object sender, DependencyPropertyChangedEventArgs e)
        {
            MountItemListener();
        }
        public void MountItemListener()
        {
            if(DataContext is Order order)
            {
                order.Items.CollectionChanged += OnCollectionChanged;
            }
        }
        public void OnCollectionChanged(object sender, EventArgs e)
        {

        }

        private void OnRemoveOrderItem(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                {
                    if(element.DataContext is IOrderItem item)
                    {
                        order.Items.Remove(item);
                    }
                }
            }
        }
    }
}