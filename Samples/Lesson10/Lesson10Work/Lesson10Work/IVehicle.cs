namespace Lesson10Work;

public interface IVehicle
{
    bool isEnoughFuel { get; }
    void Drive(int distance = 0);
    bool Refuel(int fuel);
}