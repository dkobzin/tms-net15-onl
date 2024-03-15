// See https://aka.ms/new-console-template for more information
ReadFile();
Console.ReadLine();

void ReadFile()
{
    StreamReader reader = null;    // In System.IO namespace
    try
    {
        reader = File.OpenText("file.txt");
        if (reader.EndOfStream) return;
        Console.WriteLine(reader.ReadToEnd());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.GetType());
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.StackTrace);
        Console.WriteLine(ex.InnerException);
    }
    finally
    {
        Console.WriteLine("Read file is finished!");
        if (reader != null) reader.Dispose();
    }
}
