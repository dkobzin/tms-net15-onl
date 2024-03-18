namespace Lesson14Binary;

[Serializable]
public class Person(string name, int year, string acc)
{
    public string Name { get; set; } = name;
    public int Year { get; set; } = year;

    [NonSerialized]
    public string accNumber = acc;
    
    
}