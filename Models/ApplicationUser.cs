using Microsoft.AspNetCore.Identity;

namespace RandevuApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        // İhtiyaca göre ek alanlar ekleyebilirsin
        public string FullName { get; set; }
    }
}
