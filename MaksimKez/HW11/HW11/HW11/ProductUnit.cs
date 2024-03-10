using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    internal class ProductUnit : Product, IPricePerUnit
    {
        public int Quantity { get ; set; }
        public double PricePerUnit { get; set; }

        public ProductUnit()
        {
            while (true)
            {
                Console.WriteLine("Введите количество единиц товара");
                if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0) continue;
                this.Quantity = quantity;
                break;
            }

            while (true)
            {
                Console.WriteLine("Введите цену товара за единицу");
                if (!double.TryParse(Console.ReadLine(), out double pricePerUnit) || pricePerUnit <= 0) continue;
                this.PricePerUnit = pricePerUnit;
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

        public double CalculatePrice() => Quantity * PricePerUnit;

        public override string ToString()
        {
            return $"Название продукта {this.Name}. Итоговая цена продутка {this.TotalPrice} " +
                $"Цена за единицу {this.PricePerUnit}. Единиц товара {this.Quantity}";
        }
    }
}
