using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Creates a collection of menu items on an order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }
        /// <summary>
        /// Allows for a total of costs of all items without tax or going under 0.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double sub = 0;
                foreach (IOrderItem m in Items)
                {
                    sub += m.Price;
                }
                if (sub >= 0)
                {
                    return sub;
                }
                else { return 0; }
            }
        }
        /// <summary>
        /// Creates a set tax rate.
        /// </summary>
        public double SalesTaxRate { get; protected set; }
        /// <summary>
        /// Calculates the total taxes of the order.
        /// </summary>
        public double SalesTaxCosts
        {
            get
            {
               return SubtotalCost * SalesTaxRate;
            }
        }
        /// <summary>
        /// Calculates the total cost by adding the subtotal and the tax.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCosts;
            }
        }
        /// <summary>
        /// Constructor creats the Item list and sets the sales tax.
        /// </summary>
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            this.Items.CollectionChanged += this.OnCollectionChanged;
            SalesTaxRate = .1;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyofPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            NotifyofPropertyChanged("Subtotal Cost");
        }
    }
}
