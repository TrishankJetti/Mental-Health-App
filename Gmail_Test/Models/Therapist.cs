using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MentalHealthApp.Models
{
    public class Therapist
    {
        [Key]
        public int TherapistId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Specialization cannot exceed 100 characters.")]
        public string Specialization { get; set; }

        [StringLength(500, ErrorMessage = "Bio cannot exceed 500 characters.")]
        public string Bio { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required]
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}