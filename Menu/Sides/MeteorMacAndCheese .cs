﻿/* MeteorMacAndCheese.cs
 * Author: Brenden Levi
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// MeteorMacAndCheese Class
    /// </summary>
    public class MeteorMacAndCheese : Side
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
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
                List<string> ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor setting size and then Price and Calories are updated
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Size = Size.Small;
        }




    }
}
