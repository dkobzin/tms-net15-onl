using Lesson14NewtonJson;
using Newtonsoft.Json;

var source = new Person("Bob", 32, "AC123-456-7890");
var json = JsonConvert.SerializeObject(source);

Console.WriteLine(json);

var destination = JsonConvert.DeserializeObject<Person>(json);

Console.WriteLine($"Deserialized person: {destination.Name} {destination.Year} {destination.accNumber}");