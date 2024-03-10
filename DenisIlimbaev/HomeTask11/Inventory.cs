using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
   
    partial class Inventory<TProduct>  where TProduct : ProductStandart
    {
        private List<TProduct> listProduct;
        internal event Action actionsin;
        internal Inventory(params TProduct[] products)
        {
            listProduct = products.ToList();
        }

        internal double PriceInventory()
        {
            double totalPrice = 0;
            foreach(var product in listProduct)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
        internal void AllProductInInventory()
        {
            foreach(var product in listProduct) Console.WriteLine($"имя продукта:{product.NameProduct} \nцена продукта: {product.Price}\nиндетификатор продукта: {product.Identity}\nколичество: {product.Quantity}\n ");
            Console.WriteLine();
        }
        internal void DeletedProductInInventory(string ID)
        {
            Action action = () => Console.WriteLine("Удалён новый продукт");
            actionsin += action;
            listProduct = listProduct.Where(x => x.Identity != ID).ToList();
        }
        internal void AddProductInInventory(TProduct product)
        {
            Action action = () => Console.WriteLine("Добавлен новый продукт");
            actionsin += action;
            listProduct.Add(product);
        }
        internal bool OpovistatorEvent()
        {
            bool eventStart = false;
            if (actionsin != null)
            {
                actionsin();
                eventStart = true;
                actionsin = null;
            }
            return eventStart;

        }
    }








    partial class Inventory<TProduct> : IEnumerable 
    {
        public IEnumerator<(CategoryProduct, string, double)> GetEnumerator()
        {
            (CategoryProduct, string, double) container;
            for (int i = 0; i < listProduct.Count; i++)
            {
                container = (listProduct[i].CategoryProduct, listProduct[i].NameProduct, listProduct[i].Price)!;
                yield return container;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i  < listProduct.Count; i++)
            {
                yield return listProduct[i];
            }
        }
    }

}
