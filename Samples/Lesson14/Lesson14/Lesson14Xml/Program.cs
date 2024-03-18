using System.Xml.Serialization;
using Lesson14Xml;

var source = new Person("Bob", 32, "AC123-456-7890");
var serializer = new XmlSerializer(typeof(Person));
using Stream output = new FileStream("person.xml", FileMode.Create);
serializer.Serialize(output, source);
output.Close();

using Stream input = new FileStream("person.xml", FileMode.Open);
Person destination = serializer.Deserialize(input) as Person;
input.Close();

Console.WriteLine($"Deserialized person: {destination.Name} {destination.Year} {destination.accNumber}");
