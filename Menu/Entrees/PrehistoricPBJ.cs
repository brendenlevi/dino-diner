/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Brenden Levi
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// PrehistoricPBJ Class
    /// </summary>
    public class PrehistoricPBJ
    {
        /// <summary>
        /// Bools used to hold ingredients
        /// </summary>
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// Doubles containing the Price and Calories set in the class constructor
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
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor setting price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Sets peanutButter bool to false so it will not be added to ingredients
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Sets jelly bool to false so it will not be added to ingredients
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
