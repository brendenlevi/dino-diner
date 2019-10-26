/* IOrderItem.cs
 * Author: Brenden Levi
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    // Interface for every order item, containing price, Description, and Special
    public interface IOrderItem : INotifyPropertyChanged
    {
        double Price { get; }

        string Description { get; }

        string[] Special { get; }
    }
}
