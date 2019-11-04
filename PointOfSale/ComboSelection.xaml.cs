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

        void CustomizeCombo(object sender, RoutedEventArgs args)
        {
        }
    }
}
