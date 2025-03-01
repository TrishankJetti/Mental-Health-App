using Microsoft.Identity;

namespace MentalHealthApp.Models

{
    public class Patient
    {
        public int PatientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserId { get; set; } // FK to ApplicationUser (Therapist)
        public CustomUser User { get; set; } // Navigation property

        public List<MoodEntry> MoodEntries { get; set; } = new();


        public ICollection<Appointment> Appointments { get; set; }
    }

}
