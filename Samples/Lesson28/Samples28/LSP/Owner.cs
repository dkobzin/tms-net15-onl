using Samples28.SRP;

namespace Samples28.LSP;

public class Owner(Animal pet)
{
    public Animal Pet { get; set; } = pet;

    public Type GetPetType() => Pet.GetType();
}