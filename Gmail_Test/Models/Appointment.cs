using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MentalHealthApp.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; } // junction table's unique identitifer for each record 

        public int TherapistId { get; set; } // foreign key from THerapist table 
        [ForeignKey(nameof(TherapistId))]
        public Therapist Therapist { get; set; }

        public int PatientId { get; set; }
        [ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; }
        
    }
}
