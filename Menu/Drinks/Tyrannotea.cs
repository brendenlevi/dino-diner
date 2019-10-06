/* Tyrannotea .cs
 * Author: Brenden Levi
 */

using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Tyrannotea Class
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Gets and Sets the Lemon bool
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets and Sets the Sweet bool
        /// </summary>
        private bool sweet;
        public bool Sweet {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                this.Size = this.Size; // Updates calories after value change
            }
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
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
                if (Sweet)
                {
                    Calories *= 2;
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
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor setting size and then Price and Calories are updated
        /// </summary>
        public Tyrannotea()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Sets Lemon bool to true so it will be added to ingredients
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }

        /// <summary>
        /// Sets Lemon bool to false so it will be removed from ingredients
        /// </summary>
        public void HoldLemon()
        {
            this.Lemon = false;
        }

        /// <summary>
        // Overrides the ToString Method
        // <returns> string with size, then sweet, then name.</returns>
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size.ToString());
            if (this.Sweet)
            {
                sb.Append(" Sweet");
            }
            sb.Append(" Tyrannotea");
            return sb.ToString();
        }
    }
}
