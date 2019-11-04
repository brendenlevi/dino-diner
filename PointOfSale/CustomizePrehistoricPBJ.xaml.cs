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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        /// <summary>
        /// Private PrehistoricPBJ field used for customizing.
        /// </summary>
        private PrehistoricPBJ pbj;

        /// <summary>
        /// Private combo to handle if it's from a combo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Initializes the CustomizePrehistoricPBJ page when a entree is given.
        /// </summary>
        /// <param name="pbj">Given PrehistoricPBJ.</param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        /// <summary>
        /// Initializes the CustomizePrehistoricPBJ page when a combo is given.
        /// </summary>
        /// <param name="pbj">Given PrehistoricPBJ.</param>
        public CustomizePrehistoricPBJ(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.pbj = (PrehistoricPBJ)combo.Entree;
        }

        /// <summary>
        /// Will hold peanut butter on Prehistoric PBJ when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }

        /// <summary>
        /// Will hold jelly on Prehistoric PBJ when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
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
