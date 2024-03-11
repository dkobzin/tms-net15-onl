// See https://aka.ms/new-console-template for more information

using Lesson12;

// Boxing
Person tom = new(123, "Tom");
Person bob = new("abc", "Bob");

// Unboxing
int tomId = (int)tom.Id;
string bobId = bob.Id as string;

Console.WriteLine($"tomId: {tomId}");
Console.WriteLine($"bobId: {bobId}");

# region Generic Id
PersonGeneric<int> tomGeneric = new PersonGeneric<int>(123, "Tom Generic");
PersonGeneric<string> bobGeneric = new PersonGeneric<string>("abc", "Bob Generic");
//PersonGeneric<int> saraGeneric = new PersonGeneric<int>("abc", "Bob Generic"); // compilation error

int tomGenericId = tomGeneric.Id;
string bobGenericId = bobGeneric.Id;

Console.WriteLine($"tomGenericId: {tomGenericId}");
Console.WriteLine($"bobGenericId: {bobGenericId}");
var persons = new List<PersonGeneric<int>>()
{
    tomGeneric
};
var tomFind = persons.FirstOrDefault(_ => _.Id == 123);
#endregion

#region Generic Class

Company<PersonGeneric<int>> company = new Company<PersonGeneric<int>>(tomGeneric);
Console.WriteLine($"company CEO: {tomGeneric.Name} {tomGenericId}");

#endregion

#region Generic Multiparameters

Director<int, string>  director = new(123, "email@company.com");
Console.WriteLine($"Director: {director.Id} {director.Email}");

#endregion

#region Generic extensions method

var person = new PersonGeneric<string>("abc", "Person");
var manager = Transformer.TransformToManager<PersonGeneric<string>, Manager<string>>(person, "person@company.com");
Console.WriteLine($"Manager: {manager.Id} {manager.Name} {manager.Email}");

#endregion

#region Co / contr variation

// Co
Lesson12.Stack<Bear> bears = new Lesson12.Stack<Bear>();
bears.Push(new Bear("Grey"));

//bears.Push(new Camel("Pale")); // compilation error
//Lesson12.Stack<Animal> animals = bears; // compilation error
 IPoppable<Animal> animals = bears;   // Legal
 Animal a = animals.Pop();
 Console.WriteLine(a.Name); 

// Contr
IPushable<Animal> animals1 = new Lesson12.Stack<Animal>();
IPushable<Bear> bears1 = animals1;    // Legal
bears.Push (new Bear("Black"));
 
#endregion
Console.ReadLine();