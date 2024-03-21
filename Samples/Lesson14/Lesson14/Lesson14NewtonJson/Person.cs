using Newtonsoft.Json;

namespace Lesson14NewtonJson;

[JsonObject]
public class Person
{
  
    public string Name { get; set; }
    public int Year { get; set; }

    [JsonIgnore]
    public string accNumber;
    
    public Person()
    {
    }

    public Person(string name, int year, string acc)
    {
        Name = name;
        Year = year;
        accNumber = acc;
    }
}