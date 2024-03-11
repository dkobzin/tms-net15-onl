using HomeWork10.Data;

namespace HomeWork10
{
    public class ProgramHelper
    {
        public void ShowServices(IEnumerable<Service> services)
        {
            Console.WriteLine("\nНаши товары\n");

            foreach (var service in services)
            {
                Console.WriteLine(service.Id.ToString() + "\t" + service.Name + "\t" + service.Price + "\t" + service.Count);
            }
        }

        public void ShowActions(Dictionary<int, string> actions)
        {
            Console.WriteLine("\nВыберите действие:\n");

            foreach (var keyValue in actions)
            {
                Console.WriteLine(keyValue.Key + "\t" + keyValue.Value);
            }
        }

        public InventoryResult<Service> ShowAddService()
        {
            bool exit = false;

            string? name = string.Empty;
            decimal price = 0m;
            int count = 0;

            Service service = null!;

            while (!exit)
            {
                Console.WriteLine("\nВведите наименование\n");

                while (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                {
                    name = Console.ReadLine();

                    if (name == "exit")
                    {
                        exit = true;

                        return InventoryResult.Failed<Service>("Отменено пользователем");
                    }
                }

                Console.WriteLine("\nВведите цену\n");

                while (price <= 0m)
                {
                    var priceStr = Console.ReadLine();

                    if (priceStr == "exit")
                    {
                        exit = true;

                        return InventoryResult.Failed<Service>("Отменено пользователем");
                    }

                    _ = decimal.TryParse(priceStr, out price);
                }

                Console.WriteLine("\nВведите количество\n");

                while (count <= 0)
                {
                    var countStr = Console.ReadLine();

                    if (countStr == "exit")
                    {
                        exit = true;

                        return InventoryResult.Failed<Service>("Отменено пользователем");
                    }

                    _ = int.TryParse(countStr, out count);
                }

                service = new Service(name, price, count);
                exit = true;
            }

            return InventoryResult.Completed(service);
        }

        public InventoryResult<int> ShowAddCount()
        {
            bool exit = false;

            int count = 0;

            while (!exit)
            {
                Console.WriteLine("\nВведите количество\n");

                while (count <= 0)
                {
                    var countStr = Console.ReadLine();

                    if (countStr == "exit")
                    {
                        exit = true;

                        return InventoryResult.Failed<int>("Отменено пользователем");
                    }

                    _ = int.TryParse(countStr, out count);
                }

                exit = true;
            }

            return InventoryResult.Completed(count);
        }

        public InventoryResult<string> ShowInputId()
        {
            Console.WriteLine("\nУкажите идентификатор\n");

            string? id = string.Empty;
            bool exit = false;

            while (!exit)
            {
                while (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
                {
                    id = Console.ReadLine();

                    if (id == "exit")
                    {
                        exit = true;

                        return InventoryResult.Failed<string>("Отменено пользователем");
                    }
                }

                exit = true;
            }

            return InventoryResult.Completed(id);
        }
        public bool ValidateGuid(InventoryResult<string> serviceId)
        {
            if (!Guid.TryParse(serviceId.Data, out var _))
            {
                Console.WriteLine("\nНекорректное значение\n");
                Console.ReadLine();
                Console.Clear();

                return false;
            }
            return true;
        }

        public bool IsFailedOperation(InventoryResult inventoryResult)
        {
            if (!inventoryResult.Succeseeded)
            {
                Console.WriteLine("\n" + inventoryResult.ErrorMessage + "\n");

                return true;
            }

            return false;
        }
    }
}
