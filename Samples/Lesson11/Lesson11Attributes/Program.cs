// See https://aka.ms/new-console-template for more information

using Lesson11Attributes;

var firstValue = ExampleEnum.FirstValue;

Console.WriteLine(firstValue.ToString());
Console.WriteLine(firstValue.GetEnumDescription());

var tom = new Person("Tom", 35);
var bob = new Person("Bob", 16);
var anon = new Person(string.Empty, 45);
 
Console.WriteLine($"Is {tom.Name}: {tom.IsValid()}");
Console.WriteLine($"Is {bob.Name}: {bob.IsValid()}");

Console.WriteLine($"Is {anon.Name}: {anon.Validate().First()}");

Console.ReadLine(); 