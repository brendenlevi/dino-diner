/* MezzorellaSticks.cs
 * Author: Brenden Levi
 */

using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// MezzorellaSticks Class
    /// </summary>
    public class MezzorellaSticks : Side
    {
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
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
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
                List<string> ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
                return ingredients;
            }
        }
        
        /// <summary>
        /// Class constructor setting size and then Price and Calories are updated
        /// </summary>
        public MezzorellaSticks()
        {
            this.Size = Size.Small;
        }


        /// <summary>
        // Overrides the ToString Method
        // <returns> string with size then name.</returns>
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size.ToString());
            sb.Append(" Mezzorella Sticks");
            return sb.ToString();
        }
    }
}
