/* CretaceousCombo.cs
 * Author: Brenden Levi
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : Combo
    {

        // Side for Combo
        private Side side;
        public override Side Side
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
        public override Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                drink.Size = size;
            }
        }

        // Price which is all items added together minus 25 cetns.
        public override double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        // Calories are all Item calories added together
        public override uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        // Updates the size of all items when combo size is changed
        private Size size = Size.Small;
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        // All Ingredients added together
        public override List<string> Ingredients
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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Entree.ToString());
            sb.Append(" Combo");
            return sb.ToString();
        }
    }
}
