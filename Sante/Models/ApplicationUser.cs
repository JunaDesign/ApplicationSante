using Microsoft.AspNetCore.Identity;

namespace Sante.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
