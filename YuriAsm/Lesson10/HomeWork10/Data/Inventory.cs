using HomeWork10.Abstraction;
using HomeWork10.Data.Services;
using HomeWork10.Data.Services.Base;

namespace HomeWork10.Data
{
    public class Inventory : IInventory
    {
        private readonly List<Service> services;
       
        public IEnumerable<Service> Services
        {
            get
            {
                foreach (var service in services)
                    yield return service;
            }
        }
        public decimal TotalPrice
            => Services.Sum(x => x.Price * x.Count);
        public int TotalCount
            => Services.Sum(x => x.Count);

        public Inventory()
        {
            services = new List<Service>()
            {
                new Furniture("Мебель","Стол", 500m, 5, "Tree"),
                new Furniture("Мебель", "Стул", 724m, 7),
                new Furniture("Мебель", "Шкаф", 4712m, 13),
                new Product("Продукты", "Хлеб", 24m, 13),
                new Product("Продукты","Масло", 50m, 7)
            };

            services.Sort();
        }

        public IEnumerable<T> Get<T>() where T : Service
        {
            List<T> result = new List<T>();

            foreach (var service in services)
                if(service is T tService)
                    result.Add(tService);

            return result;
        }

        public void AddService(Service service)
        {
            if(service is null)
                throw new ArgumentNullException(nameof(service));

            if (Services.Any(x => x.Id == service.Id))
                throw new InvalidOperationException();

            services.Add(service);
        }

        public void UpdateService(Service service)
        {
            if(service is null)
                throw new ArgumentNullException(nameof(service));

            if (services.Any(x => x.Id != service.Id))
                throw new InvalidOperationException();

            var currentService = Services.Single(x => x.Id == service.Id);

            currentService.SetNewData(service);
        }

        public void DeleteService(Service service)
        {
            if (service is null)
                throw new ArgumentNullException(nameof(service));

            if (!Services.Any(x => x.Id == service.Id))
                throw new InvalidOperationException();

            services.RemoveAll(x => x.Id == service.Id);
        }
    }
}
