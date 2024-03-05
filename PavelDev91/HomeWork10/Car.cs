
//-------------------------------------------------------------
abstract class Car : IVehicle
{
    public int fuelValue { get; set; } = 0;
    public virtual void Drive(out string message)
    {
        if (fuelValue > 0)
        {
            message = "Ваш '" + this.ToString() + "' едет!";

            return;
        }

        message = "У вашего автомобиля <" + this.ToString() + "> закончился бензин!";
    }

    public virtual bool ReFuel(int value)
    {
        fuelValue = value;

        return true;
    }
}
//-------------------------------------------------------------
