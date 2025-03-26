using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace MentalHealthApp.Models
{
    public class Therapist
    {
        // Unique identifier for the therapist
        [Key]
        public int TherapistId { get; set; }

        // UserId is required to associate a therapist with a user
        [Required(ErrorMessage = "User ID is required.")]
        public string UserId { get; set; }

        // First name is required and should not exceed 50 characters
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        // Last name is required and should not exceed 50 characters
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; }

        // Specialization is required and should not exceed 100 characters
        [Required(ErrorMessage = "Specialization is required.")]
        [StringLength(100, ErrorMessage = "Specialization cannot exceed 100 characters.")]
        public string Specialization { get; set; }

        // Bio is optional but if provided, it should not exceed 500 characters
        [StringLength(500, ErrorMessage = "Bio cannot exceed 500 characters.")]
        public string Bio { get; set; }

        

        // Email is required and must be a valid email address
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        // Phone number is required and must be in a valid format
        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string PhoneNumber { get; set; }

        // Each therapist can have multiple appointments, so a collection is used here
        public ICollection<Appointment> Appointments { get; set; }
    }
}
