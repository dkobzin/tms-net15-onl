namespace TasksLesson8;

public abstract class Animal
{
    public string Name { get; private set; } = "";
    public string GetName() => Name;
    public void SetName(string name) => Name = name;
    public abstract void Eat();
}
