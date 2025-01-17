﻿using System;
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// Private side variable using for customizing.
        /// </summary>
        private Side side;

        /// <summary>
        /// Private combo to handle if it's from a combo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Initializes the side page when a side is not given.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the side page when a side is given.
        /// </summary>
        /// <param name="drink">Given drink.</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        /// <summary>
        /// Initializes the side page when a combo is given.
        /// </summary>
        /// <param name="drink">Given drink.</param>
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.side = combo.Side;
        }

        /// <summary>
        /// Adds a Fryceritops to the order when selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                side = new Fryceritops();
                if (combo != null)
                {
                    combo.Side = side;
                }
                else
                {
                    order.Add(side);
                }
            }
        }

        /// <summary>
        /// Adds a MeteorMacAndCheese to the order when selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMeteorMac(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                if (combo != null)
                {
                    combo.Side = side;
                }
                else
                {
                    order.Add(side);
                }
            }
        }

        /// <summary>
        /// Adds a MezzorellaSticks to the order when selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMezzorella(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                if (combo != null)
                {
                    combo.Side = side;
                }
                else
                {
                    order.Add(side);
                }
            }
        }

        /// <summary>
        /// Adds a Triceritots to the order when selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                if (combo != null)
                {
                    combo.Side = side;
                }
                else
                {
                    order.Add(side);
                }
            }
        }

        /// <summary>
        /// Changes the size of the side when a size is chosen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
                side.Size = (DDsize)Enum.Parse(typeof(DDsize), element.Tag.ToString());
                if(combo != null)
                {
                    combo.Side.Size = side.Size;
                }
            }
            if(combo != null)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
