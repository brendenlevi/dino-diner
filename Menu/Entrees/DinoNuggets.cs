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
        private uint totalNuggets { get; set; }

        /// <summary>
        /// Class constructor setting price and calories and totalNuggets
        /// </summary>
        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 59 * 6;
            totalNuggets = 6;

            for (int i = 0; i < totalNuggets; i++)
            {
                ingredients.Add("Chicken Nugget");
            }
        }

        /// <summary>
        /// Adjusts properties if a nugget is added to the meal
        /// </summary>
        public void AddNugget()
        {
            Price += .25;
            Calories += 59;
            totalNuggets++;

            ingredients.Add("Chicken Nugget");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
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
                if (totalNuggets > 6)
                {
                    special.Add((totalNuggets - 6).ToString() + " Extra Nuggets");
                }
                return special.ToArray();
            }
        }
    }
}
