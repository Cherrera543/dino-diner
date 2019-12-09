using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public interface MenuItem : IOrderItem, INotifyPropertyChanged
    {
        uint Calories { get; }
        List<string> Ingredients { get; }
        Size Size { get; set; }
    }
}
