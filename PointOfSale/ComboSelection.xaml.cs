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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Private combo field used for customizing.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Initializes the ComboSelection page.
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates the combo for the customize brontowurst combo page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizeBrontowurstCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst brontowurst = new Brontowurst();
                combo = new CretaceousCombo(brontowurst);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeBrontowurst(combo));
            }
        }

        /// <summary>
        /// Creates the combo for the customize DinoNuggets combo page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizeDinoNuggetsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets dino = new DinoNuggets();
                combo = new CretaceousCombo(dino);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeDinoNuggets(combo));
            }
        }

        /// <summary>
        /// Creates the combo for the customize brontowurst combo page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizePrehistoricPBJCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                combo = new CretaceousCombo(pbj);
                order.Add(combo);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(combo));
            }
        }

        /// <summary>
        /// Creates the combo for the customize brontowurst combo page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizePterodactylWingsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                combo = new CretaceousCombo(wings);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Creates the combo for the customize brontowurst combo page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizeSteakosaurusBurgerCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger steak = new SteakosaurusBurger();
                combo = new CretaceousCombo(steak);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(combo));
            }
        }

        /// <summary>
        /// Creates the combo for the customize brontowurst combo page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizeTRexKingBurgerCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger trex = new TRexKingBurger();
                combo = new CretaceousCombo(trex);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeTRexKingBurger(combo));
            }
        }

        /// <summary>
        /// Creates the combo for the customize brontowurst combo page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizeVelociWrapCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                combo = new CretaceousCombo(wrap);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeVelociWrap(combo));
            }
        }
    }
}
