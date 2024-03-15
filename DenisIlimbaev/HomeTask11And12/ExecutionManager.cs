using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    internal interface IMangerInventory
    {
        public double MaxPrice();
        public double MinPrice();
        public double MiddlePrice();
    }
    internal class ExecutionManager<TProduct> :  IMangerInventory where TProduct : RefProduct
    {
        internal UserInventory<TProduct> inventory;
       
        internal ExecutionManager(UserInventory<TProduct> inventory)
        {
            this.inventory = inventory;
        }
        IList<double> prices = new List<double>();
        
        public double MaxPrice()
        {
            prices.Clear();
            foreach (var item in inventory.UserInv)
            {
                prices.Add(item.Item2);
            }
            double max = prices.Max();
            prices.Clear();
            return max;
        }
        public double MinPrice()
        {
            prices.Clear();
            foreach (var item in inventory.UserInv)
            {
                prices.Add(item.Item2);
            }
            double min = prices.Min();
            prices.Clear();
            return min;
        }
        public double MiddlePrice()
        {
            prices.Clear();
            foreach (var item in inventory.UserInv)
            {
                prices.Add(item.Item2);
            }
            double count = prices.Count();
            double sum = prices.Sum();
            prices.Clear();
            return sum / count;
        }

        
    }
}
