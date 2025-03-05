using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RandevuApp.Models;

namespace RandevuApp.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Sabit hizmetleri ekle (Seed Data)
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, Name = "Egzoz Gazı Ölçümü" },
                new Service { Id = 2, Name = "Fren Testi" },
                new Service { Id = 3, Name = "Far Ayarı" }
            );
        }
    }
}
