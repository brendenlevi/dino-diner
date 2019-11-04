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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Private combo field used for customizing.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Initilizes the CustomizeCombo page when a combo is given.
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// Navigates to the SideSelection page to edit the combo's side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SideSelection(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        /// <summary>
        /// Navigates to the DrinkSelection page to edit the combo's drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void DrinkSelection(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }

        /// <summary>
        /// Changes the size of the combo when a size is chosen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                combo.Size = (DDsize)Enum.Parse(typeof(DDsize), element.Tag.ToString());
            }
        }
    }
}
