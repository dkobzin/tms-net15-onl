using System.Runtime.Serialization.Formatters.Binary;
using Lesson14Binary;
#pragma warning disable SYSLIB0011

var source = new Person("Bob", 32, "AC123-456-7890");
var formatter = new BinaryFormatter();
using Stream output = new FileStream("Person.bin", FileMode.Create, FileAccess.Write, FileShare.None);
formatter.Serialize(output, source);
output.Close();

using Stream input = new FileStream("Person.bin", FileMode.Open,FileAccess.Read,FileShare.Read);
var destination =(Person)formatter.Deserialize(input);
input.Close();
Console.WriteLine($"Deserialized person: {destination.Name} {destination.Year} {destination.accNumber}");

#pragma warning restore SYSLIB0011
