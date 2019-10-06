/* Combo.cs
 * Author: Brenden Levi
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    // Combo Class created to maintain consistency with other classes
    public abstract class Combo : IMenuItem
    {
        /// <summary>
        /// Gets and sets the Entree
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Gets and sets the Side
        /// </summary>
        public virtual Side Side { get; set; }

        /// <summary>
        /// Gets and sets the Drink
        /// </summary>
        public virtual Drink Drink { get; set; }

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }


        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }
    }
}
