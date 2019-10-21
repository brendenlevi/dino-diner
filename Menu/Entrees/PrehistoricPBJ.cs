/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Brenden Levi
 */

using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// PrehistoricPBJ Class
    /// </summary>
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    { 
        /// <summary>
        /// Private Backing bools used to hold ingredients
        /// </summary>
        private bool peanutButter = true;
        private bool jelly = true;

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
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Sets jelly bool to false so it will not be added to ingredients
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        // Overrides the ToString Method
        // <returns>name</returns>
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Prehistoric PB&J");
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
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
    }
}
