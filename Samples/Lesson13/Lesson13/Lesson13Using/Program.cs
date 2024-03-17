using Lesson13Using;

using var baseClass1 = new BaseClass("UsingBaseClass");
baseClass1.DoWork();
var baseClass2 = new BaseClass("DefaultBaseClass");
try
{
    baseClass2.DoWork();
}
finally
{
    baseClass2.Dispose();
}
Console.ReadLine();