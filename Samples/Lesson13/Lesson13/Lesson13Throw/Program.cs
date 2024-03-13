Console.WriteLine($"Please, input int number:");
try
{
    var strNumber = Console.ReadLine();
    try
    {
        var intNumber = int.Parse(strNumber);
    }
    catch (Exception ex)
    {
        throw;
        //throw ex;
        //throw new Exception();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.GetType());
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.InnerException);
}

Console.ReadLine();