namespace WebApiHT25and26.Model
{
    public class RegisterModel : LoginModel
    {
        public string Name { get; set; } = null!;
        public string? LastName { get; set; }
        public string Telephone { get; set; } = null!;
    }
}
