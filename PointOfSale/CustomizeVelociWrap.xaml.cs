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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        /// <summary>
        /// Private VelociWrap field used for customizing.
        /// </summary>
        private VelociWrap wrap;

        /// <summary>
        /// Private combo to handle if it's from a combo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Initializes the CustomizeVelociWrap page when an entree is given.
        /// </summary>
        /// <param name="wrap">Given VelociWrap.</param>
        public CustomizeVelociWrap(VelociWrap wrap)
        {
            InitializeComponent();
            this.wrap = wrap;
        }

        /// <summary>
        /// Initializes the CustomizeVelociWrap page when a combo is given.
        /// </summary>
        /// <param name="wrap">Given VelociWrap.</param>
        public CustomizeVelociWrap(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.wrap = (VelociWrap)combo.Entree;
        }

        /// <summary>
        /// Will hold lettuce on VelociWrap when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            wrap.HoldLettuce();
        }

        /// <summary>
        /// Will hold dressing on VelociWrap when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            wrap.HoldDressing();
        }

        /// <summary>
        /// Will hold cheese on VelociWrap when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            wrap.HoldCheese();
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
