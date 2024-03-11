namespace HomeWork10.Data
{
    public class ExecutionManager
    {
        private Func<IEnumerable<Service>> OnGetServices;

        public ExecutionManager(Func<IEnumerable<Service>> onGetServices)
        {
            OnGetServices = onGetServices ?? throw new ArgumentNullException(nameof(onGetServices));
        }

        public void GetMaxPriceProducts()
        {
            var services = OnGetServices();

            var maxPrice = services.Max(x => x.Price);

            Console.WriteLine($"\nМаксимальное сумма - {maxPrice}\n");
        }
        public void GetMinPriceProducts()
        {
            var services = OnGetServices();

            var minPrice = services.Min(x => x.Price);

            Console.WriteLine($"\nМинимальная сумма - {minPrice}\n");
        }
        public void GetMiddlePriceProducts()
        {
            var services = OnGetServices();

            var allPrice = services.Sum(x => x.Price);

            var middlePrice = allPrice / services.Count();

            Console.WriteLine($"\nСредняя стоимость товаров - {Math.Ceiling(middlePrice)}\n");
        }
    }
}
