/* CretaceousCombo.cs
 * Author: Brenden Levi
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : INotifyPropertyChanged
    {
        /// <summary>
        /// Private size backing variable
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// An event handler for PropertyChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies user of a change in a property value
        /// </summary>
        /// <param name="propertyName">Name of property changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets and sets the Entree
        /// </summary>
        private Entree entree;
        public Entree Entree
        {
            get { return entree; }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };
            }
        }

        // Side for Combo
        private Side side;
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                side.Size = size;
            }
        }

        // Drink for Combo
        private Drink drink;
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                drink.Size = size;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }

        // Price which is all items added together minus 25 cetns.
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        // Calories are all item calories added together
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        // Updates the size of all items when combo size is changed
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }

        // All Ingredients added together
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        // Creates a combo whenever an entree is passed into it
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }


        /// <summary>
        // Overrides the ToString Method
        // <returns> string with size then name.</returns>
        /// </summary>
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Entree.ToString());
            sb.Append(" Combo");
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }
    }
}
