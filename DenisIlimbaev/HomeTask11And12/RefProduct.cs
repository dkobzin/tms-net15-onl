﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    internal class RefProduct : IComparable<RefProduct>
    {
        internal Product ProductObj { get; set; }

        internal int SpecialTagForConsole { get; init; }

        internal RefProduct() { }
        internal RefProduct(Product product) { ProductObj = product; }
        internal RefProduct(uint quantity, double price, string nameProduct, string identity)
        {
            ProductObj.Quantity = quantity;
            ProductObj.Price = price;
            ProductObj.NameProduct = nameProduct;
            ProductObj.Identity = identity;
            const int MaxValueIDCode = 10;
            foreach (int i in Enumerable.Range(0, MaxValueIDCode)) ProductObj.Identity += new Random().Next(0, 9).ToString();
        }
        public static implicit operator ValueProduct(RefProduct val)
        {
            ValueProduct obj = new ValueProduct()
            {
                Quantity = val.ProductObj.Quantity,
                Price = val.ProductObj.Price,
                NameProduct = val.ProductObj.NameProduct,
                Identity = val.ProductObj.Identity
            };
            return obj;
        }
        public override string ToString()
        {
            return SpecialTagForConsole.ToString();
        }

        public int CompareTo(RefProduct? otherProduct)
        {
            int res = 1;
            if (otherProduct == null) res = -1;
            else
            {
                bool param1 = otherProduct.ProductObj.Price != ProductObj.Price;
                bool param2 = otherProduct.ProductObj.Quantity != ProductObj.Quantity;
                if (param1 && param2) res = -1;
            }
            return res;
        }
    }
    
}
