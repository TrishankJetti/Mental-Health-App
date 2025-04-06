using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MentalHealthApp.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }  // Primary Key

        [Required(ErrorMessage = "First name is required.")] //Required field.
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")] //Max string length 50.
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "First name can only contain letters.")] // The firstname's regular expression makes sure that only Alphabets A to Z lowercase or uper 
        // can be allowed.
        public string FirstName { get; set; }  // Patient's first name

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Last name can only contain letters.")]
        public string LastName { get; set; }  // Patient's last name

        [Required(ErrorMessage = "User ID is required.")]
        public string UserId { get; set; }  // Foreign Key to User

        [Required]
        public CustomUser User { get; set; }  // Navigation property for User. So it is a foregin key for the UserId from the CustomUser table.

        public List<MoodEntry> MoodEntries { get; set; } = new();  // Mood entries associated with this patient

        public ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();  // Patient's Appointments
    }
}
