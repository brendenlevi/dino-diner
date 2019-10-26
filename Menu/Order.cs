/* Order.cs
 * Author: Brenden Levi
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Represents the items added to the order.
        /// </summary>
        private List<IOrderItem> items;
        public IOrderItem[] Items
        {
            get { return items.ToArray(); }
        }

        /// <summary>
        /// Notification for Price Change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Calculates the total price from the prices of all 
        /// order items.
        /// </summary>
        private double subtotalCost;
        public double SubtotalCost
        {
            get
            {
                subtotalCost = 0;
                foreach( IOrderItem item in Items)
                {
                    subtotalCost += item.Price;
                }

                if(subtotalCost < 0)
                {
                    subtotalCost = 0;
                }
                return subtotalCost;
            }
        }

        /// <summary>
        /// Sales Tax used to calculate SalesTaxCost
        /// </summary>
        public double SalesTaxRate
        {
            get { return SalesTaxRate; }
            set
            {
                if( value < 0)
                {
                    return;
                }
                else
                {
                    SalesTaxRate = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
                }
            }
        }

        /// <summary>
        /// Calculates the cost of the Sales Tax.
        /// </summary>
        public double SalesTaxCost 
        { 
            get 
            {
                return Math.Round(SalesTaxRate * SubtotalCost, 2, MidpointRounding.AwayFromZero); 
            } 
        }

        /// <summary>
        /// Calculates the total cost of the order.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return Math.Round(SubtotalCost + SalesTaxCost, 2, MidpointRounding.AwayFromZero);
            }
        }

        /// <summary>
        /// Creates the Items list.
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }

        /// <summary>
        /// Adds the given item into the items property
        /// </summary>
        /// <param name="item"> The order item to add. </param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        /// <summary>
        /// Removes the given item into the items property
        /// </summary>
        /// <param name="item"> The order item to add. </param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }

        /// <summary>
        /// Generates the appropiate notification when an item is added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
