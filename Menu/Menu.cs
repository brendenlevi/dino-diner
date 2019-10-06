/* Menu.cs
 * Author: Brenden Levi
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    // Contains all Items on the menu
    public class Menu
    {
        // All Available Menu Items
        private List<IMenuItem> availableMenuItems;
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                // All Drinks
                JurassicJava java = new JurassicJava();
                availableMenuItems.Add(java);
                Sodasaurus soda = new Sodasaurus();
                availableMenuItems.Add(soda);
                Tyrannotea tea = new Tyrannotea();
                availableMenuItems.Add(tea);
                Water water = new Water();
                availableMenuItems.Add(water);

                // All Entrees
                Brontowurst brontowurst = new Brontowurst();
                availableMenuItems.Add(brontowurst);
                DinoNuggets dino = new DinoNuggets();
                availableMenuItems.Add(dino);
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                availableMenuItems.Add(pbj);
                PterodactylWings wings = new PterodactylWings();
                availableMenuItems.Add(wings);
                SteakosaurusBurger steak = new SteakosaurusBurger();
                availableMenuItems.Add(steak);
                TRexKingBurger trex = new TRexKingBurger();
                availableMenuItems.Add(steak);
                VelociWrap wrap = new VelociWrap();
                availableMenuItems.Add(wrap);

                // All Sides
                Fryceritops fries = new Fryceritops();
                availableMenuItems.Add(fries);
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                availableMenuItems.Add(mac);
                MezzorellaSticks sticks = new MezzorellaSticks();
                availableMenuItems.Add(sticks);
                Triceritots triceritots = new Triceritots();
                availableMenuItems.Add(triceritots);

                return availableMenuItems;
            }
        }

        // All Available Entree Items
        private List<Entree> availableEntrees;
        public List<Entree> AvailableEntrees
        {
            get
            {
                foreach (Entree item in availableMenuItems){
                    availableEntrees.Add(item);
                }
                return availableEntrees;
            }
        }

        // All Available Side Items
        private List<Side> availableSides;
        public List<Side> AvailableSides
        {
            get
            {
                foreach (Side item in availableMenuItems)
                {
                    availableSides.Add(item);
                }
                return availableSides;
            }
        }

        // All Available Drink Items
        private List<Drink> availableDrinks;
        public List<Drink> AvailableDrinks
        {
            get
            {
                foreach (Drink item in availableMenuItems)
                {
                    availableDrinks.Add(item);
                }
                return availableDrinks;
            }
        }

        // All Available Combo Items
        private List<Combo> availableCombos;
        public List<Combo> AvailableCombos
        {
            get
            {
                foreach (Entree item in availableMenuItems)
                {
                    CretaceousCombo combo = new CretaceousCombo(item);
                    availableCombos.Add(combo);
                }
                return availableCombos;
            }
        }

        /// <summary>
        // Overrides the ToString Method
        // <returns> string with full menu contents separated by a new line</returns>
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(IMenuItem item in availableMenuItems)
            {
                sb.Append(item.ToString() + "\n");
            }
            return sb.ToString();
        }
    }
}
