using Microsoft.AspNetCore.Identity;

namespace App10.Api.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = string.Empty;
    }
}
