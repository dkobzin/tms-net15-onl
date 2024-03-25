
using HomeWork10.Data;
using HomeWork10.Data.Services;
using HomeWork10.Data.Services.Base;

namespace HomeWork10
{

    public class ProgramHelper
    {
        public void ShowServices(IEnumerable<Service> services)
        {
            Console.WriteLine("\nНаши товары\n");

            foreach (var service in services)
            {
                Console.WriteLine(service.Id.ToString()+"\t"+ service.CategoryName + "\t" + service.Name + "\t" + service.Price + "\t" + service.Count);
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

        public ActionResult<Service> ShowAddService()
        {
            bool exit = false;

            string? category = string.Empty;
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

                        return ActionResult.Failed<Service>("Отменено пользователем");
                    }
                }

                Console.WriteLine("\nВведите цену\n");

                while (price <= 0m)
                {
                    var priceStr = Console.ReadLine();

                    if (priceStr == "exit")
                    {
                        exit = true;

                        return ActionResult.Failed<Service>("Отменено пользователем");
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

                        return ActionResult.Failed<Service>("Отменено пользователем");
                    }

                    _ = int.TryParse(countStr, out count);
                }

                ServiceType type = ServiceType.Furniture;

                switch (type)
                {
                    case ServiceType.Furniture:
                        service = new Furniture(category, name, price, count) ; 
                        break;
                    case ServiceType.Product:
                        service = new Product(category, name, price, count);

                        break;
                    default:
                        break;
                }

               
                exit = true;
            }

            return ActionResult.Completed(service);
        }

        public ActionResult<int> ShowAddCount()
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

                        return ActionResult.Failed<int>("Отменено пользователем");
                    }

                    _ = int.TryParse(countStr, out count);
                }

                exit = true;
            }

            return ActionResult.Completed(count);
        }

        public ActionResult<string> ShowInputId()
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

                        return ActionResult.Failed<string>("Отменено пользователем");
                    }
                }

                exit = true;
            }

            return ActionResult.Completed(id);
        }

        public bool ValidateGuid(ActionResult<string> serviceId)
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

        public bool IsFailedOperation(ActionResult inventoryResult)
        {
            if (!inventoryResult.Succeseeded)
            {
                Console.WriteLine("\n" + inventoryResult.ErrorMessage + "\n");

                return true;
            }

            return false;
        }

        public void HandleInventoryActions(ExecutionManager manager)
        {
            bool exit = false;

            Dictionary<int, string> actions = new Dictionary<int, string>
            {
               { 1, "Показать товар с максимальной ценой" },
               { 2, "Показать товар с минимальной ценой" },
               { 3, "Высчитать среднюю цену товаров" },
               { 4, "Очистить консоль" }
            
            };

            ShowActions(actions);

            Console.WriteLine("\nДля выхода из режима инвентаризации введите - exit");

            while (!exit)
            {
                var input = Console.ReadLine();

                if (input == "exit")
                {
                    exit = true;

                    break;
                }

                if (!int.TryParse(input, out var key) || !actions.TryGetValue(key, out var _))
                {
                    Console.WriteLine("\nНеизвестное действие\n");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                switch (key)
                {
                    case 1:
                        manager.GetMaxPriceProducts();
                        break;
                    case 2:
                        manager.GetMinPriceProducts();
                        break;
                    case 3:
                        manager.GetMiddlePriceProducts();
                        break;
                    case 4:
                        Console.Clear();
                        ShowActions(actions);
                        Console.WriteLine("\nДля выхода из режима инвентаризации введите - exit");
                        break;
                    default:
                        throw new NotSupportedException();

                }
            }
        }
    }
}
