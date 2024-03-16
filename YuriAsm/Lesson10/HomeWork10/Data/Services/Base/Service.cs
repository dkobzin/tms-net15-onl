namespace HomeWork10.Data.Services.Base
{
    public abstract class Service : IComparable<Service>
    {
        public abstract ServiceType Type { get; }
        public virtual Guid Id { get; }

        public decimal Price { get; protected set; }
        public int Count { get; protected set; }
        public string Name { get; protected set; } = string.Empty;
        public string CategoryName { get; protected set; }     

        public Service(string category, string name, decimal price, int count)
        {
            if (price <= 0m)
                throw new ArgumentException("incorrect input price");
            if (count <= 0)
                throw new ArgumentException("incorrect input count");
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            CategoryName = category ?? throw new ArgumentNullException(nameof(category));
            Id = Guid.NewGuid();
            Price = price;
            Count = count;
            Name = name;
        }

        public abstract void SetNewData(Service service);
        public virtual void Supplement(int? count = null)
        {
            if (count.HasValue)
                Count += count.Value;
            else
                Count++;
        }

        public virtual void Subtract(int? count = null)
        {
            if (count.HasValue)
                Count -= count.Value;
            else
                Count--;
        }

        public virtual int CompareTo(Service? other)
        {
            if (other == null)
                return 0;

            if (this.Count > other.Count) return 1;
            else if (this.Count < other.Count) return -1;
            else return 0;
        }
    }
}
