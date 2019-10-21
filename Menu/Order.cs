/* Order.cs
 * Author: Brenden Levi
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// Represents the items added to the order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

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
        public double SalesTaxRate { get; protected set; } = 0.08;

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
    }
}
