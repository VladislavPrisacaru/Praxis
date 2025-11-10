using Microsoft.AspNetCore.Identity;

namespace Praxis.Data.Entities
{
    public class AplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; } = string.Empty;
        public bool IsAdmin { get; set; } = false;
        public bool IsActive { get; set; } = false;
    }
}
