using Microsoft.AspNetCore.Identity;

namespace FarmersCentral.Models
{
    public class UsersRoles : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
