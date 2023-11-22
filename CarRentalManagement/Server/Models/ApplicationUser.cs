using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement.Server.Models
{
    public class ApplicationUser : IdentityUser //implements
    {
        public string? FirstName { get; set; } //can contain null values
        public string? LastName { get; set; }
    }
}
