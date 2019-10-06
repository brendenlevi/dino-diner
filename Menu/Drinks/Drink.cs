﻿/* Drink.cs
 * Author: Brenden Levi
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets or sets the ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Sets Ice bool to false so it will not be added to ingredients
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
