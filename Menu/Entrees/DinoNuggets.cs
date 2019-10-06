/* DinoNuggets.cs
 * Author: Brenden Levi
 */

using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// DinoNuggets Class
    /// </summary>
    public class DinoNuggets : Entree
    {

        /// <summary>
        /// Int to contain the total number of nuggets
        /// </summary>
        public uint totalNuggets { get; set; }

        /// <summary>
        /// Ingredients which uses bools to add said ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < totalNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor setting price and calories and totalNuggets
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
            this.totalNuggets = 6;
        }

        /// <summary>
        /// Adjusts properties if a nugget is added to the meal
        /// </summary>
        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            this.totalNuggets += 1;
        }


        /// <summary>
        // Overrides the ToString Method
        // <returns>name.</returns>
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Dino-Nuggets");
            return sb.ToString();
        }
    }
}
