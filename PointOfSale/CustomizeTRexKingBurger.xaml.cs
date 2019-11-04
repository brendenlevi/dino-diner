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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        /// <summary>
        /// Private TRexKingBurger field used for customizing.
        /// </summary>
        private TRexKingBurger trex;

        /// <summary>
        /// Initializes the CustomizeTRexKingBurger page when a pbj is given.
        /// </summary>
        /// <param name="trex">Given TRexKingBurger.</param>
        public CustomizeTRexKingBurger(TRexKingBurger trex)
        {
            InitializeComponent();
            this.trex = trex;
        }

        /// <summary>
        /// Will hold bun on TRexKingBurger when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            trex.HoldBun();
        }

        /// <summary>
        /// Will hold pickle on TRexKingBurger when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            trex.HoldPickle();
        }

        /// <summary>
        /// Will hold ketchup on TRexKingBurger when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            trex.HoldKetchup();
        }

        /// <summary>
        /// Will hold mustard on TRexKingBurger when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            trex.HoldMustard();
        }

        /// <summary>
        /// Will hold lettuce on TRexKingBurger when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            trex.HoldLettuce();
        }

        /// <summary>
        /// Will hold tomato on TRexKingBurger when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            trex.HoldTomato();
        }

        /// <summary>
        /// Will hold onion on TRexKingBurger when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            trex.HoldOnion();
        }

        /// <summary>
        /// Will hold mayo on TRexKingBurger when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            trex.HoldMayo();
        }

        /// <summary>
        /// Will navigate back to when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
