using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RandevuApp.Models;

namespace RandevuApp.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Service> Services { get; set; }
    }

    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }  // Kullanıcıya ekstra alan ekleyebilirsin
    }
}
