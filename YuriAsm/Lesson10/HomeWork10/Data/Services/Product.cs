using HomeWork10.Data.Services.Base;
using System.Linq;

namespace HomeWork10.Data.Services
{
    public class Product : Service
    {
        public override ServiceType Type => ServiceType.Product;

        public double Calories { get; protected set; }

        public Product(string category, string name, decimal price, int count, double? calories = null) : base(category, name, price, count)
        {
            Calories = calories ?? 0;
        }

        public override void SetNewData(Service service)
        {
            if(service is Product product)
            {
                Name = product.Name;
                Price = product.Price;
                Count = product.Count;
                CategoryName = product.CategoryName;
                Calories = product. Calories;
            }

            throw new InvalidCastException();
        }
    }
}
