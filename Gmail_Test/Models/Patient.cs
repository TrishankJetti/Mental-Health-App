using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MentalHealthApp.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; }

        [Required]
        public string UserId { get; set; }
        public CustomUser User { get; set; }

        public List<MoodEntry> MoodEntries { get; set; } = new();

        public ICollection<Appointment> Appointments { get; set; }
    }
}