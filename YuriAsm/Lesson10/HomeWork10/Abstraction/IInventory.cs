using HomeWork10.Data.Services.Base;

namespace HomeWork10.Abstraction
{
    public interface IInventory
    {
        decimal TotalPrice {  get; }
        int TotalCount { get; }


        IEnumerable<Service> Services { get; }
        IEnumerable<T> Get<T>() where T : Service;

        void AddService(Service service);
        void UpdateService(Service service);
        void DeleteService(Service service);
    }
}
