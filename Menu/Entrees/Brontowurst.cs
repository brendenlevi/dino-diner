/* Brontowurst.cs
 * Author: Brenden Levi
 */

using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Brontowurst Class
    /// </summary>
    public class Brontowurst : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Bools used to hold ingredients
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;

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

        /// <summary>
        // Overrides the ToString Method
        // <returns>name.</returns>
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Brontowurst");
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
                if (!bun) special.Add("Hold Whole Wheat Bun");
                if (!peppers) special.Add("Hold Peppers");
                if (!onion) special.Add("Hold Onion");
                return special.ToArray();
            }
        }
    }
}
