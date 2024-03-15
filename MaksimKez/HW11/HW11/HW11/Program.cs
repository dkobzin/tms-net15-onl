namespace HW11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var invent = new Inventory();
            invent.Print();
            Console.WriteLine();
            int choice;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите действие (введите 1 - 5)");
                Console.WriteLine("1) Вывести информацию об инвентаре");
                Console.WriteLine("2) Вывести цену всего инвентаря");
                Console.WriteLine("3) Добавить продукт(ы)");
                Console.WriteLine("4) Удалить продукт");
                Console.WriteLine("5) Закончить работу программы");
                if (!int.TryParse(Console.ReadLine(), out choice)) continue;
                switch (choice)
                {
                    case 1:
                        invent.Print();
                        Console.WriteLine("Что бы продолжить введите что либо");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine($"Сумма всех продуктов ранвна {invent.SumOfProsucts()}");
                        Console.WriteLine("Что бы продолжить введите что либо");
                        Console.ReadLine();
                        break;
                    case 3:
                        invent.AddProducts();
                        break;
                    case 4:
                        invent.RemoveProduct();
                        break;
                    case 5: return;
                    default:
                        continue;
                }

            }
        }
    }
}
