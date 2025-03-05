using System.ComponentModel.DataAnnotations;

namespace RandevuApp.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;  // Hizmet adı (Egzoz Gazı Ölçümü vb.)

        public List<Appointment>? Appointments { get; set; }  // Hizmetin randevuları
    }
}
