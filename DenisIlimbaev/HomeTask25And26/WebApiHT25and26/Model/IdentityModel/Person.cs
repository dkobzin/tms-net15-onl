using Microsoft.AspNetCore.Identity;

namespace WebApiHT25and26.Model.IdentityModel
{
    public class Person : IdentityUser
    {
        public string? Telephone { get; set; }
        public bool IsSharing { get; set; }
    }
}
