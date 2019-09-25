/* Sodasaurus.cs
 * Author: Brenden Levi
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Sodasaurus Class
    /// </summary>
    public class Sodasaurus : Drink
    {
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
    }
}
