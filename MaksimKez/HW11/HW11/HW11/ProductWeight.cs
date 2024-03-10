using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    internal class ProductWeight : Product, IPricePerWeight
    {
        public double Weight { get; set; }
        public double PricePerKilo { get; set; }
        public ProductWeight()
        {
            while (true)
            {
                Console.WriteLine("Введите вес товара");
                if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0) continue;
                this.Weight = weight;
                break;
            }
            while (true)
            {
                Console.WriteLine("Введите цену за кг товара");
                if (!double.TryParse(Console.ReadLine(), out double pricePerKilo) || pricePerKilo <= 0) continue;
                this.PricePerKilo = pricePerKilo;
                break;
            }

            while (true)
            {
                Console.WriteLine("Введите название товара");
                Name = Console.ReadLine();
                if (string.IsNullOrEmpty(Name)) continue;
                break;
            }

            this.TotalPrice = CalculatePrice();
            this.ID = Guid.NewGuid().ToString();
        }

        public double CalculatePrice() => Weight * PricePerKilo;
        public override string ToString()
        {
            return $"Название продукта {this.Name}. Итоговая цена продутка {this.TotalPrice} " +
                $"Цена за единицу {this.PricePerKilo}. Единиц товара {this.Weight}";
        }

    }
}
