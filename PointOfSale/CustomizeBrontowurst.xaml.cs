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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        /// <summary>
        /// Private Brontowurst field used for customizing.
        /// </summary>
        private Brontowurst brontowurst;

        /// <summary>
        /// Private combo to handle if it's from a combo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Initializes the CustomizeBrontowurst page when a entree is given.
        /// </summary>
        /// <param name="brontowurst">Given Brontowurst.</param>
        public CustomizeBrontowurst(Brontowurst brontowurst)
        {
            InitializeComponent();
            this.brontowurst = brontowurst;
        }

        /// <summary>
        /// Initializes the CustomizeBrontowurst page when a combo is given.
        /// </summary>
        /// <param name="brontowurst">Given Brontowurst.</param>
        public CustomizeBrontowurst(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.brontowurst = (Brontowurst)combo.Entree;
        }

        /// <summary>
        /// Will hold onions on Brontowurst when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnions(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldOnion();
        }

        /// <summary>
        /// Will hold peppers on Brontowurst when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldPeppers();
        }

        /// <summary>
        /// Will hold bun on Brontowurst when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldBun();
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
