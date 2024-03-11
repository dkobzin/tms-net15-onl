namespace HomeWork10
{
    public class InventoryResult
    {
        public bool Succeseeded { get; }
        public string? ErrorMessage { get; }

        protected InventoryResult(bool succeseeded, string? errorMessage = null)
        {
            Succeseeded = succeseeded;
            ErrorMessage = errorMessage;
        }

        public static InventoryResult Completed()
            => new InventoryResult(true);
        public static InventoryResult<T> Completed<T>(T data)
            => new InventoryResult<T>(true, data);
        public static InventoryResult Failed(string errorMessage)
            => new InventoryResult(false, errorMessage);
        public static InventoryResult<T> Failed<T>(string errorMessage)
            => new InventoryResult<T>(false, default!, errorMessage);
    }

    public class InventoryResult<T> : InventoryResult
    {
        public T Data { get; }

        public InventoryResult(bool succeseeded, T data, string? errorMessage = null) : base(succeseeded, errorMessage)
        {
            Data = data;
        }
    }
}
