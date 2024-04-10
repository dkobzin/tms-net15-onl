using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HomeTask15Web
{
   public class Users
    {

        public string? Name { get; set; }
        public string? LastName { get; set; }
        public bool UserIsSharing { get; set; } = false;
        public string? Status { get; set; }

    }
}
