﻿/* JurrasicJava .cs
 * Author: Brenden Levi
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// JurrasicJava Class
    /// </summary>
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Gets and Sets the RoomForCream bool
        /// </summary>
        public bool SpaceForCream { get; set; } = false;

        /// <summary>
        /// Gets and Sets the Decaf bool
        /// </summary>
        public bool Decaf { get; set; } = false;

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
                        Price = .59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
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
                List<string> ingredients = new List<string>() { "Water", "Coffee" };
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor setting size to small and ice false 
        /// and then Price and Calories are updated
        /// </summary>
        public JurrasicJava()
        {
            this.Ice = false;
            this.Size = Size.Small;
        }

        /// <summary>
        /// Sets Ice bool to true
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }

        /// <summary>
        /// Sets Ice bool to true
        /// </summary>
        public void LeaveSpaceForCream()
        {
            this.SpaceForCream = true;
        }

        /// <summary>
        /// Sets Decaf bool to true
        /// </summary>
        public void MakeDecaf()
        {
            this.Decaf = true;
        }
    }
}
