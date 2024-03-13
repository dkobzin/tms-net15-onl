namespace Lesson10Work;

public abstract class Car(string name, int fuel, int consumption)
{
    protected string Name { get; set; } = name;
    private int Fuel { get; set; } = fuel;
    protected bool isEnoughFuelCar { get; set; }
    private int Consumption { get; set; } = consumption;

    protected void DriveCar(int distance)
    {
        //var permissibleDistance = Fuel > 0 && Consumption > 0 ? (Fuel / Consumption) * 100 : default;
        var permissibleDistance = Fuel > 0 && Consumption > 0 ? (Fuel / Consumption) : default;
        isEnoughFuelCar = Fuel > 0 && permissibleDistance > distance;
    }

    protected bool RefuelCar(int refuel)
    {
        Fuel += refuel;
        isEnoughFuelCar = true;
        return isEnoughFuelCar;
    }
}