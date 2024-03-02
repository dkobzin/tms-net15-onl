namespace HW8;

public abstract class Animal
{
    protected string Name { get; set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public abstract void Eat();
}