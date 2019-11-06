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
        List<IOrderItem> items;
        public void Add(IOrderItem o)
        {
            o.PropertyChanged += OnItemPropertyChanged;
            items.Add(o);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCosts"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
        public bool Remove(IOrderItem o)
        {
            bool removed = items.Remove(o);
            if (removed) 
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCosts"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
            return removed;
        }
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs("SalesTaxCosts"));
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs("TotalCost"));
        }
        public IOrderItem[] Items { get { return items.ToArray(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Allows for a total of costs of all items without tax or going under 0.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double sub = 0;
                foreach (IOrderItem m in items)
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
            //this.Items.CollectionChanged += this.OnCollectionChanged;
            SalesTaxRate = .1;
            items = new List<IOrderItem>();
        }

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
