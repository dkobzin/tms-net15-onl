namespace IdentityWebApiLesson29
{
    public class ApiLoginResult
    {
        public bool Success { get; set; }

        public required string Message { get; set; }

        public string? Token { get; set; }
    }
}
