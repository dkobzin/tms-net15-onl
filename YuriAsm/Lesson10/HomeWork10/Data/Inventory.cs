namespace HomeWork10.Data
{
    public class Inventory
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
                new Service("Стол", 500m, 5),
                new Service("Стул", 724m, 7),
                new Service("Шкаф", 4712m, 13)
            };
        }

        public InventoryResult AddServiceCount(Guid id, int count)
        {
            if (id == default)
                throw new ArgumentNullException(nameof(id));

            var currentService = Services.FirstOrDefault(x => x.Id == id);

            if (currentService == null)
                return InventoryResult.Failed("Товар с таким ID не найден");

            currentService.Supplement(count);

            return InventoryResult.Completed();
        }
        public InventoryResult SubtractServiceCount(Guid id, int count)
        {
            if (id == default)
                throw new ArgumentNullException(nameof(id));

            var currentService = Services.FirstOrDefault(x => x.Id == id);

            if (currentService == null)
                return InventoryResult.Failed("Товар с таким ID не найден");

            currentService.Subtract(count);

            return InventoryResult.Completed();
        }

        public InventoryResult RemoveService(Guid id)
        {
            if (id == default)
                throw new ArgumentNullException(nameof(id));

            var currentService = Services.FirstOrDefault(x => x.Id == id);

            if (currentService == null)
                return InventoryResult.Failed("Товар с таким ID не найден");

            services.Remove(currentService);

            return InventoryResult.Completed();
        }
        public InventoryResult AddService(Service service)
        {
            if (service == null)
                throw new ArgumentNullException(nameof(service));

            var currentService = Services.FirstOrDefault(x => x.Name == service.Name);

            if (currentService != null)
                return InventoryResult.Failed("Товар с таким наименованием уже существует");

            services.Add(service);

            return InventoryResult.Completed();
        }
    }
}
