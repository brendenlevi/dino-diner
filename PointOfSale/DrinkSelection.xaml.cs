using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using DDsize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Private side variable using for customizing.
        /// </summary>
        private Drink drink;

        /// <summary>
        /// Private combo to handle if it's from a combo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Initializes the drink page when a drink is not given.
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the drink page when a drink is given.
        /// </summary>
        /// <param name="drink">Given drink.</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;

            if(drink is Sodasaurus)
            {
                ButtonStack.Children.Clear();
                ButtonStack.RowDefinitions.Clear();
                ButtonStack.RowDefinitions.Add(new RowDefinition());
                ButtonStack.RowDefinitions.Add(new RowDefinition());

                Button ice = new Button();
                ice.Content = "Hold Ice";
                ice.FontSize = 24;
                ice.Click += new RoutedEventHandler(OnSelectHoldIce);
                Grid.SetRow(ice, 0);

                Button flavor = new Button();
                flavor.Content = "Select Flavor";
                flavor.Click += new RoutedEventHandler(OnSelectFlavor);
                flavor.FontSize = 24;
                Grid.SetRow(flavor, 1);

                ButtonStack.Children.Add(ice);
                ButtonStack.Children.Add(flavor);
            }
        }

        /// <summary>
        /// Initializes the drink page when a combo is given.
        /// </summary>
        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.drink = combo.Drink;
        }

        /// <summary>
        /// Adds Select Flavor and Hold Ice button
        /// on Sodasaurus Click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {
            ButtonStack.Children.Clear();
            ButtonStack.RowDefinitions.Clear();
            ButtonStack.RowDefinitions.Add(new RowDefinition());
            ButtonStack.RowDefinitions.Add(new RowDefinition());

            Button ice = new Button();
            ice.Content = "Hold Ice";
            ice.FontSize = 24;
            ice.Click += new RoutedEventHandler(OnSelectHoldIce);
            Grid.SetRow(ice, 0);

            Button flavor = new Button();
            flavor.Content = "Select Flavor";
            flavor.Click += new RoutedEventHandler(OnSelectFlavor);
            flavor.FontSize = 24;
            Grid.SetRow(flavor, 1);

            ButtonStack.Children.Add(ice);
            ButtonStack.Children.Add(flavor);

            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                {
                    order.Add(drink);
                }
            }

        }

        /// <summary>
        /// Adds Hold Ice, Add Sweet, and Add Lemon
        /// button on Tyrannotea Click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnSelectTyrannotea(object sender, RoutedEventArgs args)
        {
            ButtonStack.Children.Clear();
            ButtonStack.RowDefinitions.Clear();
            ButtonStack.RowDefinitions.Add(new RowDefinition());
            ButtonStack.RowDefinitions.Add(new RowDefinition());
            ButtonStack.RowDefinitions.Add(new RowDefinition());

            Button ice = new Button();
            ice.Content = "Hold Ice";
            ice.FontSize = 24;
            ice.Click += new RoutedEventHandler(OnSelectHoldIce);
            Grid.SetRow(ice, 0);

            Button sweet = new Button();
            sweet.Content = "Add Sweet";
            sweet.FontSize = 24;
            sweet.Click += new RoutedEventHandler(OnSelectAddSweet);
            Grid.SetRow(sweet, 1);

            Button lemon = new Button();
            lemon.Content = "Add Lemon";
            lemon.FontSize = 24;
            lemon.Click += new RoutedEventHandler(OnSelectAddLemon);
            Grid.SetRow(lemon, 2);

            ButtonStack.Children.Add(ice);
            ButtonStack.Children.Add(sweet);
            ButtonStack.Children.Add(lemon);

            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                {
                    order.Add(drink);
                }
            }
        }

        /// <summary>
        /// Adds Add Ice, Add Space, and Make Decaf
        /// buttons on Jurrasic Java Click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnSelectJava(object sender, RoutedEventArgs args)
        {
            ButtonStack.Children.Clear();
            ButtonStack.RowDefinitions.Clear();
            ButtonStack.RowDefinitions.Add(new RowDefinition());
            ButtonStack.RowDefinitions.Add(new RowDefinition());
            ButtonStack.RowDefinitions.Add(new RowDefinition());

            Button ice = new Button();
            ice.Content = "Add Ice";
            ice.FontSize = 24;
            ice.Click += new RoutedEventHandler(OnSelectAddIce);
            Grid.SetRow(ice, 0);

            Button space = new Button();
            space.Content = "Add Space";
            space.FontSize = 24;
            space.Click += new RoutedEventHandler(OnSelectAddSpace);
            Grid.SetRow(space, 1);

            Button decaf = new Button();
            decaf.Content = "Make Decaf";
            decaf.FontSize = 24;
            decaf.Click += new RoutedEventHandler(OnSelectMakeDecaf);
            Grid.SetRow(decaf, 2);

            ButtonStack.Children.Add(ice);
            ButtonStack.Children.Add(space);
            ButtonStack.Children.Add(decaf);

            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                {
                    order.Add(drink);
                }
            }
        }

        /// <summary>
        /// Adds a Add Lemon and Hold Ice button on 
        /// Water Click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnSelectWater(object sender, RoutedEventArgs args)
        {
            ButtonStack.Children.Clear();
            ButtonStack.RowDefinitions.Clear();
            ButtonStack.RowDefinitions.Add(new RowDefinition());
            ButtonStack.RowDefinitions.Add(new RowDefinition());

            Button ice = new Button();
            ice.Content = "Hold Ice";
            ice.FontSize = 24;
            ice.Click += new RoutedEventHandler(OnSelectHoldIce);
            Grid.SetRow(ice, 0);

            Button lemon = new Button();
            lemon.Content = "Add Lemon";
            lemon.FontSize = 24;
            lemon.Click += new RoutedEventHandler(OnSelectAddLemon);
            Grid.SetRow(lemon, 1);

            ButtonStack.Children.Add(ice);
            ButtonStack.Children.Add(lemon);

            if (DataContext is Order order)
            {
                drink = new Water();
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                {
                    order.Add(drink);
                }
            }
        }

        /// <summary>
        /// Navigates back to the Menu Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Navigates to the FlavorSelection page if Flavor
        /// is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnSelectFlavor(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                if (combo.Drink is Sodasaurus soda) NavigationService.Navigate(new FlavorSelection(soda));
            }
            else
            {
                if (drink is Sodasaurus soda) NavigationService.Navigate(new FlavorSelection(soda));
            }
        }

        /// <summary>
        /// Changes the size of the drink when a size is chosen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDsize)Enum.Parse(typeof(DDsize), element.Tag.ToString());
                if (combo != null)
                {
                    combo.Drink.Size = drink.Size;
                }
            }
        }

        /// <summary>
        /// Adds Ice to java.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectAddIce(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                if (combo.Drink is JurassicJava java) java.AddIce();
            }
            else
            {
                if (drink is JurassicJava java) java.AddIce();
            }
        }

        /// <summary>
        /// Holds Ice drom drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectHoldIce(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                combo.Drink.HoldIce();
            }
            else
            {
                drink.HoldIce();
            }
        }

        /// <summary>
        /// Adds Lemon to water or tea.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectAddLemon(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                if (combo.Drink is Water water) water.AddLemon();
                if (combo.Drink is Tyrannotea tea) tea.AddLemon();
            }
            else
            {
                if (drink is Water water) water.AddLemon();
                if (drink is Tyrannotea tea) tea.AddLemon();
            }
        }

        /// <summary>
        /// Adds Sweet to tea.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectAddSweet(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                if (combo.Drink is Tyrannotea tea) tea.Sweet = true;
            }
            else
            {
                if (drink is Tyrannotea tea) tea.Sweet = true;
            }
        }

        /// <summary>
        /// Adds Space to java.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectAddSpace(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                if (combo.Drink is JurassicJava java) java.LeaveSpaceForCream();
            }
            else
            {
                if (drink is JurassicJava java) java.LeaveSpaceForCream();
            }
        }

        /// <summary>
        /// Adds Decaf to java.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMakeDecaf(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                if (combo.Drink is JurassicJava java) java.MakeDecaf();
            }
            else
            {
                if (drink is JurassicJava java) java.MakeDecaf();
            }
        }
    }
}
