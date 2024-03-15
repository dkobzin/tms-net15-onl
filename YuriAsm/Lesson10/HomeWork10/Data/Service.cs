namespace HomeWork10.Data
{
    public class Service
    {
        public Guid Id { get; }
        public decimal Price { get; private set; }
        public int Count { get; private set; }
        public string Name { get; private set; } = string.Empty;

        public Service(string name, decimal price, int count)
        {
            if (price <= 0m)
                throw new ArgumentException("incorrect input price");
            if (count <= 0)
                throw new ArgumentException("incorrect input count");
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            Id = Guid.NewGuid();
            Price = price;
            Count = count;
            Name = name;
        }

        public void Supplement(int? count = null)
        {
            if (count.HasValue)
                Count += count.Value;
            else
                Count++;
        }
        public void Subtract(int? count = null)
        {
            if (count.HasValue)
                Count -= count.Value;
            else
                Count--;
        }
    }
}
