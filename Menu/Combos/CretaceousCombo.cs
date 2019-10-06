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

        public override double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        public override uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

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
