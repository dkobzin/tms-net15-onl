namespace DenisHT9
{
    internal interface IVehicle
    {
        internal void Drive();
        // uint логичнее т.к дистанция не может быть -
        internal bool Refuel(uint colfuel);
    }
   
    
    
}
