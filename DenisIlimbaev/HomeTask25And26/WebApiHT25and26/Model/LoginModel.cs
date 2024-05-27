namespace WebApiHT25and26.Model
{
    public class LoginModel
    {
        public int Id { get; set; }
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
