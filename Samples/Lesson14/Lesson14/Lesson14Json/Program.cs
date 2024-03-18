// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using Lesson14Json;

var source = new Person("Bob", 32, "AC123-456-7890");
var json = JsonSerializer.Serialize(source);

Console.WriteLine(json);

var destination = JsonSerializer.Deserialize<Person>(json);

Console.WriteLine($"Deserialized person: {destination.Name} {destination.Year} {destination.accNumber}");