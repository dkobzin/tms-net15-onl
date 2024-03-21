using System.Xml.Serialization;

namespace Lesson14Xml;

[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Year { get; set; }

    [XmlIgnore]
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