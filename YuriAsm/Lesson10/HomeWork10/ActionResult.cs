namespace HomeWork10
{
    public class ActionResult
    {
        public bool Succeseeded { get; }
        public string? ErrorMessage { get; }

        protected ActionResult(bool succeseeded, string? errorMessage = null)
        {
            Succeseeded = succeseeded;
            ErrorMessage = errorMessage;
        }

        public static ActionResult Completed()
            => new ActionResult(true);
        public static ActionResult<T> Completed<T>(T data)
            => new ActionResult<T>(true, data);
        public static ActionResult Failed(string errorMessage)
            => new ActionResult(false, errorMessage);
        public static ActionResult<T> Failed<T>(string errorMessage)
            => new ActionResult<T>(false, default!, errorMessage);
    }

    public class ActionResult<T> : ActionResult 
    {
        public T Data { get; }

        public ActionResult(bool succeseeded, T data, string? errorMessage = null) : base(succeseeded, errorMessage)
        {
            Data = data;
        }
    }
}
