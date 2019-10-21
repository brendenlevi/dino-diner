/* DinoNuggets.cs
 * Author: Brenden Levi
 */

using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// DinoNuggets Class
    /// </summary>
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Int to contain the total number of nuggets
        /// </summary>
        private uint totalNuggets { get; set; }

        /// <summary>
        /// An event handler for PropertyChanged events
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies user of a change in a property value
        /// </summary>
        /// <param name="propertyName">Name of property changed</param>
        protected override void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
