using Microsoft.AspNetCore.Identity;

namespace App10.Api.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = default!;
    }
}
