using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson11
{
    public class ExecutionManager
    {

        public void Start()
        {
            Console.WriteLine("1. Посчитать сумму товаров");
            Console.WriteLine("2. Найти самый дорогой товар");
            Console.WriteLine("3. Найти самый дешевый товар");
            Console.WriteLine("4. Посчитать среднюю цену на товар");
            Console.WriteLine("5. Выйти");

            string operationChoice = Console.ReadLine();
            
            switch (operationChoice)
            {
                case "1":
                    Console.WriteLine($"Сумма цен товаров: {CalculateSum()}.");
                    break;
                case "2":
                    Console.WriteLine($"Самый дорогой товар: {FindHighestPrice()}.");
                    break;
                case "3":
                    Console.WriteLine($"Самый дешевый товар: {FindLowestPrice()}.");
                    break;
                case "4":
                    Console.WriteLine($"Средняя цена продуктов: {CalculateArithmeticMean()}.");
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверное значение.");
                    break;
            }
        }
        
        private ItemCatalog catalog;

        public ExecutionManager(ItemCatalog catalog)
        {
            this.catalog = catalog;
        }

        public double FindLowestPrice()
        {
            double lowestPrice = double.MaxValue;

            if (catalog.apple.price < lowestPrice)
            {
                lowestPrice = catalog.apple.price;
            }

            if (catalog.watermelon.price < lowestPrice)
            {
                lowestPrice = catalog.watermelon.price;
            }

            if (catalog.banana.price < lowestPrice)
            {
                lowestPrice = catalog.banana.price;
            }

            return lowestPrice;
        }

        public double FindHighestPrice()
        {
            double highestPrice = double.MinValue;

            if (catalog.apple.price > highestPrice)
            {
                highestPrice = catalog.apple.price;
            }

            if (catalog.watermelon.price > highestPrice)
            {
                highestPrice = catalog.watermelon.price;
            }

            if (catalog.banana.price > highestPrice)
            {
                highestPrice = catalog.banana.price;
            }

            return highestPrice;
           
        }

        public double CalculateArithmeticMean()
        {
            double sum = catalog.apple.price + catalog.watermelon.price + catalog.banana.price;
            return sum / 3;
        }

        public double CalculateSum()
        {
            return catalog.apple.price + catalog.watermelon.price + catalog.banana.price;
        }
    }
}
