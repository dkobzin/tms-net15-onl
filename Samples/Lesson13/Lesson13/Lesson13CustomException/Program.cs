using Lesson13CustomException;
using InvalidDataException = Lesson13CustomException.InvalidDataException;

Console.WriteLine($"Please, input int number:");
var strNumber = Console.ReadLine();
try
{
    if (int.TryParse(strNumber, out var intNumber))
    {
        Console.WriteLine(intNumber);
    }
    else
    {
        throw new InvalidDataException();
        // throw new InvalidDataException(ExceptionStatusEnum.Active);
        
    }
}
catch (InvalidDataException ex) when (ex.StatusEnum == ExceptionStatusEnum.Active)
{
    Console.WriteLine($"{ex.StatusEnum}");
    Console.WriteLine(ex.GetType());
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.InnerException);
}
catch (InvalidDataException ex)
{
    Console.WriteLine($"{strNumber} is not integer!");
    Console.WriteLine(ex.GeatType());
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.InnerException);
}

Console.ReadLine();