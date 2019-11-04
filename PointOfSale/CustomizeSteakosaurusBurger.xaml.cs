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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        /// <summary>
        /// Private SteakosaurusBurger field used for customizing.
        /// </summary>
        private SteakosaurusBurger steak;

        /// <summary>
        /// Private combo to handle if it's from a combo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Initializes the CustomizeSteakosaurusBurger page when a entree is given.
        /// </summary>
        /// <param name="steak">Given SteakosaurusBurger.</param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger steak)
        {
            InitializeComponent();
            this.steak = steak;
        }

        /// <summary>
        /// Initializes the CustomizeSteakosaurusBurger page when a combo is given.
        /// </summary>
        /// <param name="steak">Given SteakosaurusBurger.</param>
        public CustomizeSteakosaurusBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.steak = (SteakosaurusBurger)combo.Entree;
        }

        /// <summary>
        /// Will hold bun on SteakosaurusBurger when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            steak.HoldBun();
        }

        /// <summary>
        /// Will hold pickle on SteakosaurusBurger when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            steak.HoldPickle();
        }

        /// <summary>
        /// Will hold ketchup on SteakosaurusBurger when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            steak.HoldKetchup();
        }

        /// <summary>
        /// Will hold mustard on SteakosaurusBurger when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            steak.HoldMustard();
        }

        /// <summary>
        /// Will navigate back to when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else
            {
                NavigationService.GoBack();
            }
        }
    }
}
