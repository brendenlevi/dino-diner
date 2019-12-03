using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{ 
    public class MenuModel : PageModel
    {
        public Menu Menu { get { return new Menu(); } }

        public List<Entree> Entrees { get; set; }
        public List<CretaceousCombo> Combos { get; set; }
        public List<Drink> Drinks { get; set; }
        public List<Side> Sides { get; set; }

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }

        [BindProperty]
        public List<string> ingredient { get; set; } = new List<string>();

        public void OnGet()
        {
            Entrees = Menu.AvailableEntrees;
            Combos = Menu.AvailableCombos;
            Drinks = Menu.AvailableDrinks;
            Sides = Menu.AvailableSides;
        }

        public void OnPost(string search, List<string> menuCategory, float? minimumPrice, float? maximumPrice, List<string> ingredient)
        {
            Entrees = Menu.AvailableEntrees;
            Combos = Menu.AvailableCombos;
            Drinks = Menu.AvailableDrinks;
            Sides = Menu.AvailableSides;

            if(search != null)
            {
                searchName(search);
            }

            if (menuCategory.Count != 0)
            {
                filterByCategory(menuCategory);
            }

            if(minimumPrice != null)
            {
                filterByMinimumPrice(minimumPrice);
            }

            if (maximumPrice != null)
            {
                filterByMaximumPrice(maximumPrice);
            }

            if (ingredient.Count != 0)
            {
                filterByIngredient(ingredient);
            }
        }

        private void filterByCategory(List<string> menuCategory)
        {
            if (!menuCategory.Contains("Combo"))
            {
                Combos = new List<CretaceousCombo>();
            }

            if (!menuCategory.Contains("Entree"))
            {
                Entrees = new List<Entree>();
            }

            if (!menuCategory.Contains("Side"))
            {
                Sides = new List<Side>();
            }

            if (!menuCategory.Contains("Drink"))
            {
                Drinks = new List<Drink>();
            }
        }

        private void searchName(string search)
        {
            List<Entree> tempEntree = new List<Entree>();
            foreach(Entree entree in Entrees)
            {
                if(entree.ToString() != null && entree.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    tempEntree.Add(entree);
                }
            }
            Entrees = tempEntree;

            List<CretaceousCombo> tempCombo = new List<CretaceousCombo>();
            foreach (CretaceousCombo combo in Combos)
            {
                if (combo.ToString() != null && combo.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    tempCombo.Add(combo);
                }
            }
            Combos = tempCombo;

            List<Side> tempSide = new List<Side>();
            foreach (Side side in Sides)
            {
                if (side.ToString() != null && side.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    tempSide.Add(side);
                }
            }
            Sides = tempSide;

            List<Drink> tempDrink = new List<Drink>();
            foreach (Drink drink in Drinks)
            {
                if (drink.ToString() != null && drink.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    tempDrink.Add(drink);
                }
            }
            Drinks = tempDrink;
        }

        private void filterByMinimumPrice(float? minimumPrice)
        {
            List<Entree> tempEntree = new List<Entree>();
            foreach (Entree entree in Entrees)
            {
                if (entree.Price >= minimumPrice)
                {
                    tempEntree.Add(entree);
                }
            }
            Entrees = tempEntree;

            List<CretaceousCombo> tempCombo = new List<CretaceousCombo>();
            foreach (CretaceousCombo combo in Combos)
            {
                if (combo.Price >= minimumPrice)
                {
                    tempCombo.Add(combo);
                }
            }
            Combos = tempCombo;

            List<Side> tempSide = new List<Side>();
            foreach (Side side in Sides)
            {
                if (side.Price >= minimumPrice)
                {
                    tempSide.Add(side);
                }
            }
            Sides = tempSide;

            List<Drink> tempDrink = new List<Drink>();
            foreach (Drink drink in Drinks)
            {
                if (drink.Price >= minimumPrice)
                {
                    tempDrink.Add(drink);
                }
            }
            Drinks = tempDrink;
        }

        private void filterByMaximumPrice(float? maximumPrice)
        {
            List<Entree> tempEntree = new List<Entree>();
            foreach (Entree entree in Entrees)
            {
                if (entree.Price <= maximumPrice)
                {
                    tempEntree.Add(entree);
                }
            }
            Entrees = tempEntree;

            List<CretaceousCombo> tempCombo = new List<CretaceousCombo>();
            foreach (CretaceousCombo combo in Combos)
            {
                if (combo.Price <= maximumPrice)
                {
                    tempCombo.Add(combo);
                }
            }
            Combos = tempCombo;

            List<Side> tempSide = new List<Side>();
            foreach (Side side in Sides)
            {
                if (side.Price <= maximumPrice)
                {
                    tempSide.Add(side);
                }
            }
            Sides = tempSide;

            List<Drink> tempDrink = new List<Drink>();
            foreach (Drink drink in Drinks)
            {
                if (drink.Price <= maximumPrice)
                {
                    tempDrink.Add(drink);
                }
            }
            Drinks = tempDrink;
        }

        private void filterByIngredient(List<string> ingredient)
        {
            List<Entree> tempEntree = new List<Entree>();
            List<CretaceousCombo> tempCombo = new List<CretaceousCombo>();
            List<Side> tempSide = new List<Side>();
            List<Drink> tempDrink = new List<Drink>();

            foreach (string i in ingredient)
            {
                foreach (Entree entree in Entrees)
                {
                    if (entree.Ingredients != null && entree.Ingredients.Contains(i))
                    {
                        tempEntree.Add(entree);
                    }
                }

                foreach (CretaceousCombo combo in Combos)
                {
                    if (combo.ToString() != null && combo.Ingredients.Contains(i))
                    {
                        tempCombo.Add(combo);
                    }
                }

                foreach (Side side in Sides)
                {
                    if (side.ToString() != null && side.Ingredients.Contains(i))
                    {
                        tempSide.Add(side);
                    }
                }

                foreach (Drink drink in Drinks)
                {
                    if (drink.ToString() != null && drink.Ingredients.Contains(i))
                    {
                        tempDrink.Add(drink);
                    }
                }

                foreach(Entree entree in tempEntree)
                {
                    Entrees.Remove(entree);
                }

                foreach (CretaceousCombo combo in tempCombo)
                {
                    Combos.Remove(combo);
                }

                foreach(Side side in tempSide)
                {
                    Sides.Remove(side);
                }

                foreach(Drink drink in tempDrink)
                {
                    Drinks.Remove(drink);
                }
            }

        }
    }
}