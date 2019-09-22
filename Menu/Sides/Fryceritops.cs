/* Fryceritops.cs
 * Author: Brenden Levi
 */

using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Sides
{
    class Fryceritops : Side
    {
        /// <summary>
        /// Double containing the price, calories, and size set in the class constructor
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }
        public Size Size { get; set; }

        /// <summary>
        /// Ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potatoes", "Salt", "Vegtable Oil" };
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor setting price, calories, and size
        /// </summary>
        public Fryceritops()
        {
            this.Price = .99;
            this.Calories = 222;
            this.Size = Small;
        }




    }
}
