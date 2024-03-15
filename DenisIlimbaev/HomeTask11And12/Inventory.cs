using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
   
     class Inventory<TProduct> : IEnumerable where TProduct : RefProduct
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
                totalPrice += product.ProductObj.Price;
            }
            return totalPrice;
        }
        internal void AllProductInInventory()
        {
            foreach(var product in listProduct) Console.WriteLine($"имя продукта:{product.ProductObj.NameProduct} \nцена продукта: {product.ProductObj.Price}\nиндетификатор продукта: {product.ProductObj.Identity}\nколичество: {product.ProductObj.Quantity}\n ");
            Console.WriteLine();
        }
        internal void DeletedProductInInventory(string ID)
        {
            Action action = () => Console.WriteLine("Удалён новый продукт");
            actionsin += action;
            listProduct = listProduct.Where(x => x.ProductObj.Identity != ID).ToList();
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
        public IEnumerator<(string, double)> GetEnumerator()
        {
            (string, double) container;
            for (int i = 0; i < listProduct.Count; i++)
            {
                container = (listProduct[i].ProductObj.NameProduct, listProduct[i].ProductObj.Price)!;
                yield return container;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
