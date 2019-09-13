﻿/* Brontowurst.cs
 * Author: Brenden Levi
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Brontowurst Class
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// Bools used to hold ingredients
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;

        /// <summary>
        /// Double containing the Price and Calories set in the class constructor
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// Ingredients which uses bools to add said ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor setting price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Sets bun bool to false so it will not be added to ingredients
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Sets peppers bool to false so it will not be added to ingredients
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Sets onion bool to false so it will not be added to ingredients
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
    }
}
