using Microsoft.AspNetCore.Identity;

namespace RandevuApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
        public List<Appointment>? Appointments { get; set; }
    }
}
