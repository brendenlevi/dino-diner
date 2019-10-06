/* Water .cs
 * Author: Brenden Levi
 */

using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Water Class
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Gets and Sets the Lemon bool
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Updates Size, Price, and Calories on a value change.
        /// </summary>
        private Size size;
        public override Size Size
        {
            set
            {
                size = value;
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
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor setting size and then Price and Calories are updated
        /// </summary>
        public Water()
        {
            this.Size = Size.Small;
            this.Price = .10;
            this.Calories = 0;
        }

        /// <summary>
        /// Sets Lemon bool to true so it will be added to ingredients
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }

        /// <summary>
        // Overrides the ToString Method
        // <returns> string with size then name.</returns>
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size.ToString());
            sb.Append(" Water");
            return sb.ToString();
        }
    }
}
