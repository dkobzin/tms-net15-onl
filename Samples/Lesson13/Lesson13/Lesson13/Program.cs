
Console.WriteLine($"Please, input int number:");
var strNumber = Console.ReadLine();
try
{
    var intNumber = int.Parse(strNumber);
}
catch (Exception ex)
{
    Console.WriteLine($"{strNumber} is not integer!");
    Console.WriteLine(ex.GetType());
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.InnerException);
}

Console.ReadLine();