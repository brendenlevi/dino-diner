/* IMenuItem.cs
 * Author: Brenden Levi
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    // Interface for every menu item, containing price, calories, and ingredients
    public interface IMenuItem
    {
        double Price { get; }

        uint Calories { get; }

        List<string> Ingredients { get; }
    }
}
