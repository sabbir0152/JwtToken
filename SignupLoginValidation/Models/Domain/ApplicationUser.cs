using Microsoft.AspNetCore.Identity;

namespace SignupLoginValidation.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
