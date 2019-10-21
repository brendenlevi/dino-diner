﻿/* VelociWrap.cs
 * Author: Brenden Levi
 */

using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// VelociWrap Class
    /// </summary>
    public class VelociWrap : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Bools used to hold ingredients
        /// </summary>
        private bool lettuce = true;
        private bool dressing = true;
        private bool cheese = true;

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
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor setting price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Sets dressing bool to false so it will not be added to ingredients
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Sets lettuce bool to false so it will not be added to ingredients
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Sets cheese bool to false so it will not be added to ingredients
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }


        /// <summary>
        // Overrides the ToString Method
        // <returns>name.</returns>
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Veloci-Wrap");
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
                if (!lettuce) special.Add("Hold Lettuce");
                if (!dressing) special.Add("Hold Dressing");
                if (!cheese) special.Add("Hold Parmesan Cheese");
                return special.ToArray();
            }
        }
    }
}
