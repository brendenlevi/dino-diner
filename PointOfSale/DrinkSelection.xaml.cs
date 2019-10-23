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
        private Drink drink;

        public DrinkSelection()
        {
            InitializeComponent();
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
            Button ice = new Button();
            ice.Content = "Hold Ice";

            Button flavor = new Button();
            flavor.Content = "Select Flavor";
            flavor.Click += new RoutedEventHandler(FlavorClick);


            ButtonStack.Children.Add(flavor);
            ButtonStack.Children.Add(ice);

            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Items.Add(drink);
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
            Button ice = new Button();
            ice.Content = "Hold Ice";

            Button sweet = new Button();
            sweet.Content = "Add Sweet";

            Button lemon = new Button();
            lemon.Content = "Add Lemon";


            ButtonStack.Children.Add(sweet);
            ButtonStack.Children.Add(lemon);
            ButtonStack.Children.Add(ice);

            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Items.Add(drink);
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
            Button ice = new Button();
            ice.Content = "Add Ice";

            Button space = new Button();
            space.Content = "Add Space";

            Button decaf = new Button();
            decaf.Content = "Make Decaf";


            ButtonStack.Children.Add(space);
            ButtonStack.Children.Add(decaf);
            ButtonStack.Children.Add(ice);

            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Items.Add(drink);
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
            Button ice = new Button();
            ice.Content = "Hold Ice";

            Button lemon = new Button();
            lemon.Content = "Add Lemon";

            ButtonStack.Children.Add(lemon);
            ButtonStack.Children.Add(ice);

            if (DataContext is Order order)
            {
                drink = new Water();
                order.Items.Add(drink);
            }
        }

        /// <summary>
        /// Navigates to the FlavorSelection page if Flavor
        /// is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void FlavorClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDsize)Enum.Parse(typeof(DDsize), element.Tag.ToString());
            }
        }
    }
}
