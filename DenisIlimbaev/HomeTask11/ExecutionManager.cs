using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    interface IMangerInventory
    {
        public double MaxPrice();
        public double MinPrice();
        public double MiddlePrice();
    }
    internal class ExecutionManager<TProduct> : IMangerInventory where TProduct : ProductStandart, new()
    {
        internal UserInventory<TProduct> inventory;
       
        internal ExecutionManager(UserInventory<TProduct> inventory)
        {
            this.inventory = inventory;
        }
        //internal Dictionary<CategoryProduct, string> DivideIntoGroups()
        //{
        //    var container = new Dictionary<CategoryProduct, string>();
        //    const char splitLines = ' ';
        //    foreach (var item in inventory.UserInv)
        //    {
        //        for(int i = 0; i < container.Count; i++)
        //        {
        //            if (!container.ContainsKey(item.Item1))
        //            {
        //                container.Add(item.Item1, item.Item2 + splitLines);
        //            }
        //            else
        //            {
        //                container[item.Item1] += item.Item2;
        //            }
        //        }
        //    }
        //    return container;
        //}
        public double MaxPrice()
        {
            IList<double> prices = new List<double>();
            foreach (var item in inventory.UserInv)
            {
                prices.Add(item.Item3);
            }
            return prices.Max();
        }
        public double MinPrice()
        {
            IList<double> prices = new List<double>();
            foreach (var item in inventory.UserInv)
            {
                prices.Add(item.Item3);
            }
            return prices.Min();
        }
        public double MiddlePrice()
        {
            IList<double> prices = new List<double>();
            foreach (var item in inventory.UserInv)
            {
                prices.Add(item.Item3);
            }
            return prices.Sum() / prices.Count;
        }

        
    }
}
