using System.Runtime.Serialization;

namespace Lesson14Custom;

[Serializable]
public class Person : ISerializable
{
    public string Name { get; set; }
    public int Year { get; set; }

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

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Name", Name);
        info.AddValue("Year", Year);
    }
    
    protected Person(SerializationInfo info, StreamingContext context)
    {
        Name = info.GetString("Name");
        Year = Int32.Parse(info.GetString("Year"));
    }
}