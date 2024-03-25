namespace HomeWork12_14.HomeWork13
{
    public class WrongLoginExeption : Exception
    {
        public WrongLoginExeption() { }
        public WrongLoginExeption(string message) : base(message){ }
    }
}
