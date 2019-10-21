/* IOrderItem.cs
 * Author: Brenden Levi
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    // Interface for every order item, containing price, Description, and Special
    public interface IOrderItem
    {
        double Price { get; }

        string Description { get; }

        string[] Special { get; }
    }
}
