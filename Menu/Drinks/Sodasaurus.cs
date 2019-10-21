/* Sodasaurus.cs
 * Author: Brenden Levi
 */

using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Sodasaurus Class
    /// </summary>
    public class Sodasaurus : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for PropertyChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies user of a change in a property value
        /// </summary>
        /// <param name="propertyName">Name of property changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets and Sets the Flavor
        /// </summary>
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// Updates Size, Price, and Calories on a value change.
        /// </summary>
        private Size size;
        public override Size Size
        {
            set
            {
                size = value;
                switch (Size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Overrides the Ingredients value
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor setting size to small and then Price and Calories are updated
        /// </summary>
        public Sodasaurus()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        // Overrides the ToString Method
        // <returns> string with size, then flavor, then name.</returns>
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size.ToString());
            sb.Append(" " + this.Flavor.ToString());
            sb.Append(" Sodasaurus");
            return sb.ToString();
        }

        /// <summary>
        /// Gets a description of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Contains special instructions for food preparation 
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
