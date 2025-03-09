using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentalHealthApp.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        public int TherapistId { get; set; }
        [ForeignKey(nameof(TherapistId))]
        public Therapist Therapist { get; set; }

        [Required]
        public int PatientId { get; set; }
        [ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; } // Date and time of appointment

        [Required]
        public int DurationMinutes { get; set; } // Duration in minutes

        [Required]
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;

        public string? Notes { get; set; } // Optional notes

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }

    public enum AppointmentStatus
    {
        Scheduled,
        Completed,
        Canceled,
        Rescheduled
    }

}
