using HomeWork10;
using HomeWork10.Abstraction;
using HomeWork10.Authorase;
using HomeWork10.Authorase.ValidateUser;
using HomeWork10.Data;
using HomeWork10.Data.Services;
using System.Net.WebSockets;

ProgramHelper helper = new ProgramHelper();
IInventory inventory = new Inventory();
ExecutionManager manager = new ExecutionManager(() => inventory.Services);
IActionService actionService = new ActionService(inventory);

var furniture = inventory.Get<Furniture>();
var pruduct = inventory.Get<Product>();

Dictionary<int, string> actions = new Dictionary<int, string>
{
    { 1, "Показать список" },
    { 2, "Показать общую цену товаров" },
    { 3, "Показать общее количество товаров" },
    { 4, "Добавить товар" },
    { 5, "Удалить товар" },
    { 6, "Добавить еденицу товара" },
    { 7, "Удалить еденицу товара" },
    { 8, "Провести инвентаризацию товара" },
    { 9, "Очистить консоль" }
};

bool exit = false;

Console.Write("Pleas, enter login : ");
string userLogin = Console.ReadLine();
Console.Write("Pleas, enter password : ");
string userPassword = Console.ReadLine();
Console.Write("Pleas, enter password again : ");
string userConfirmPasscword = Console.ReadLine();

User user = new(userLogin, userPassword, userConfirmPasscword);

try
{
    Authorization.Login(user);
}
catch (WrongLoginExeption ex)
{
    Console.WriteLine(ex.Message);
}
catch (WrongPasswordExeption ex)

{
    Console.WriteLine(ex.Message);
};



Console.WriteLine("Добро пожаловать в наш сервис продаж\n");
Console.WriteLine("Для выхода из магазина введите: exit\n");

while (!exit)
{
    helper.ShowActions(actions);

    var input = Console.ReadLine();

    if (input == "exit")
    {
        exit = true;

        break;
    }

    if (!int.TryParse(input, out int key) || !actions.TryGetValue(key, out var _))
    {
        Console.WriteLine("\nНеизвестное действие\n");
        Console.ReadLine();
        Console.Clear();

        continue;
    }

    switch (key)
    {
        case 1:
            helper.ShowServices(inventory.Services);
            break;
        case 2:
            Console.Write("\nОбщая сумма наших товаров:  ");
            Console.Write(inventory.TotalPrice + " руб." + "\n");
            break;
        case 3:
            Console.Write("\nОбщее колличество наших товаров:  ");
            Console.Write(inventory.TotalCount + "шт." + "\t");
            break;
        case 4:
               
                var result = helper.ShowAddService();

                if (result.Succeseeded)
                    actionService.AddService(result.Data);

                else
                    Console.WriteLine("\n" + result.ErrorMessage + "\n");
              
             
                  break;
            
        case 5:
            
                var serviceId = helper.ShowInputId();

                if (!helper.ValidateGuid(serviceId))
                    continue;

                var deleteResult = actionService.RemoveService(new Guid(serviceId.Data));

                helper.IsFailedOperation(deleteResult);
            
            

            break;
        case 6:
           
                var serviceIdResult = helper.ShowInputId();

                if (helper.IsFailedOperation(serviceIdResult))
                    continue;


                if (!helper.ValidateGuid(serviceIdResult))
                    continue;

                var countResult = helper.ShowAddCount();

                if (helper.IsFailedOperation(countResult))
                    continue;


                var addedCountResult = actionService.AddServiceCount(new Guid(serviceIdResult.Data), countResult.Data);

                if (addedCountResult.Succeseeded)
                    Console.WriteLine("Операция выполнена");

                else
                {
                    helper.IsFailedOperation(addedCountResult);
                    continue;
                }

            break;
        case 7:
           
                var serviceDeleteIdResult = helper.ShowInputId();

                if (helper.IsFailedOperation(serviceDeleteIdResult))
                    continue;

                if (!helper.ValidateGuid(serviceDeleteIdResult))
                    continue;

                var countSubtractResult = helper.ShowAddCount();

                if (helper.IsFailedOperation(countSubtractResult))
                    continue;

                var subtractResult = actionService.SubtractServiceCount(new Guid(serviceDeleteIdResult.Data), countSubtractResult.Data);

                if (subtractResult.Succeseeded)
                    Console.WriteLine("Операция выполнена");

                else
                {
                    helper.IsFailedOperation(subtractResult);
                    continue;
                }
            break;
        case 8:
            helper.HandleInventoryActions(manager);
            break;
        case 9:
            Console.Clear();
            break;
        default:
            throw new NotSupportedException();
    }
}