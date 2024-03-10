using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
enum CategoryProduct
{
    Food,
    Cosmetic,
    
}
namespace HomeTask11
{
    interface ProductStandart
    {
        public uint Quantity { get; set; }
        public double Price { get; set; }
        public string? NameProduct { get; set; }
        public string? Identity { get; init; }
        public CategoryProduct CategoryProduct { get; set; }
    }
    class Product : ProductStandart
    {
        public uint Quantity { get; set; }
        public double Price { get; set; }
        public string? NameProduct { get; set; }
        public string? Identity { get; init; }
        public CategoryProduct CategoryProduct {  get; set; }
        public Product()
        {
            const int MaxValueIDCode = 10;
            foreach(int i in Enumerable.Range(0, MaxValueIDCode)) Identity += new Random().Next(0,9).ToString();
        }
    }

    struct ProductStruct : ProductStandart
    {
        public uint Quantity { get; set; }
        public double Price { get; set; }
        public string? NameProduct { get; set; }
        public string? Identity { get; init; }
        public CategoryProduct CategoryProduct { get; set; }
        public ProductStruct()
        {
            const int MaxValueIDCode = 10;
            foreach (int i in Enumerable.Range(0, MaxValueIDCode)) Identity += new Random().Next(0, 9).ToString();
        }
    }
    
}
