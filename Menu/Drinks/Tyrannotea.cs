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
                if (Sweet)
                {
                    Calories *= 2;
                    ingredients.Add("Cane Sugar");
                }
                else
                {
                    Calories /= 2;
                    ingredients.Remove("Cane Sugar");
                }
                NotifyOfPropertyChanged("Description");
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Class constructor setting size and then Price and Calories are updated
        /// </summary>
        public Tyrannotea()
        {
            Size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Tea");
        }

        /// <summary>
        /// Sets Lemon bool to true so it will be added to ingredients
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Sets Lemon bool to false so it will be removed from ingredients
        /// </summary>
        public void HoldLemon()
        {
            Lemon = false;
            ingredients.Remove("Lemon");
            NotifyOfPropertyChanged("Special");
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
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}
