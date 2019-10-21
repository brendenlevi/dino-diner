/* Entree.cs
 * Author: Brenden Levi
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for PropertyChanged events
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies user of a change in a property value
        /// </summary>
        /// <param name="propertyName">Name of property changed</param>
        protected abstract void NotifyOfPropertyChanged(string propertyName);

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets the string containing the description.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Gets the string containing specials.
        /// </summary>
        public abstract string[] Special { get; }

    }
}
