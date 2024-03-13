namespace HW11
{
    internal interface IPricePerWeight
    {
        public double Weight { get; set; }
        public double PricePerKilo { get; set; }
        public double CalculatePrice();
    }
}
