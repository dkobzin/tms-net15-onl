using HomeWork10.Data.Services.Base;

namespace HomeWork10.Data.Services
{
    public class Furniture : Service
    {
        public override ServiceType Type => ServiceType.Furniture;
        public string? Material { get; set; }

        public Furniture(string category, string name, decimal price, int count, string? material = null) : base(category, name, price, count)
        {
            Material = material;
        }

        public override void SetNewData(Service service)
        {
            if(service is Furniture furniture)
            {
                Name = furniture.Name;
                Price = furniture.Price;
                Count = furniture.Count;
                Material = furniture.Material;
                CategoryName = furniture.CategoryName;
            }

            throw new InvalidCastException();
        }
    }
}
