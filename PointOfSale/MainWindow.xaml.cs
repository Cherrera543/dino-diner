﻿using System;
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
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            ordercon.NavigationService = frame.NavigationService;
            
        }


        private void PassDataContext()
        {
            if (frame.Content is Page p)
            {
                p.DataContext = DataContext;
            }
        }

        private void LoadCompleted(object sender, NavigationEventArgs e)
        {
            PassDataContext();
        }

        private void DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            PassDataContext();
        }
    }
}
