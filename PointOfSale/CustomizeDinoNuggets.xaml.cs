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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        /// <summary>
        /// Private DinoNuggets field used for customizing.
        /// </summary>
        private DinoNuggets dino;

        /// <summary>
        /// Private combo to handle if it's from a combo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Initializes the CustomizeDinoNuggets page when a entree is given.
        /// </summary>
        /// <param name="dino">Given DinoNuggets.</param>
        public CustomizeDinoNuggets(DinoNuggets dino)
        {
            InitializeComponent();
            this.dino = dino;
        }

        /// <summary>
        /// Initializes the CustomizeDinoNuggets page when a combo is given.
        /// </summary>
        /// <param name="brontowurst">Given Brontowurst.</param>
        public CustomizeDinoNuggets(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.dino = (DinoNuggets)combo.Entree;
        }

        /// <summary>
        /// Will add nuggets on DinoNuggets when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            dino.AddNugget();
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
