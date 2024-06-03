// See https://aka.ms/new-console-template for more information

// SRP

// It's not right

using Samples28.ISP;
using Samples28.LSP;
using Samples28.OCP;
using Samples28.SRP;

var user = new User();
user.Build();
user.Drive();
user.Run();

// It's right

var builder = new Builder();
builder.Build();
var driver = new Driver();
driver.Drive();
var runner = new Runner();
runner.Run();

// OCP

// It's not good 

//var fish = new Animal("Fish");
//fish.Eat();
//fish.Swim();
//fish.Fly(); // ????
    
//var bird = new Animal("Bird");
//bird.Eat();
//bird.Swim(); // ???
//bird.Fly();  

// It's good 

var fish = new Fish("Fish");
fish.Eat();
fish.Swim();

var bird = new Bird("Bird");
bird.Eat();
bird.Fly();

// LSP & covariant vs. contr variant

var owner = new Owner(fish);
owner.Pet.Swim();

var type = owner.GetPetType();


owner = new Owner(new Animal("Pinguin"));
owner.Pet.Swim();
owner.Pet.Eat();

type = owner.GetPetType();

// ISP

var animals = new List<Animal>()
{
    bird, 
    fish
};

foreach (var animal in animals)
{
    animal.Eat();
}

// It's not good
//var notifier = new Notifier();
//notifier.SendSms();
//notifier.SendMail();
//notifier.SendPush();

// It's good!
Notifier notifier = new NotifierSmSPush(); 
((NotifierSmSPush) notifier).SendPush();
((NotifierSmSPush) notifier).SendSms();

notifier = new NotifierSms();
((NotifierSms)notifier).SendSms();

Console.ReadLine();

