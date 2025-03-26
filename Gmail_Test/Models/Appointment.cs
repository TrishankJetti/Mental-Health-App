using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentalHealthApp.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        // Foreign key for Therapist
        [Required(ErrorMessage = "Therapist is required.")]
        public int TherapistId { get; set; }
        [ForeignKey(nameof(TherapistId))]
        public Therapist Therapist { get; set; }

        // Foreign key for Patient
        [Required(ErrorMessage = "Patient is required.")]
        public int PatientId { get; set; }
        [ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; }

        // Appointment date and time, must be in the future
        [Required(ErrorMessage = "Appointment date is required.")]
        [DataType(DataType.DateTime)]
        public DateTime AppointmentDate { get; set; }

        // Duration of the appointment in minutes, must be between 15 and 240 minutes
        [Required(ErrorMessage = "Duration is required.")]
        [Range(15, 240, ErrorMessage = "Duration must be between 15 and 240 minutes.")]
        public int DurationMinutes { get; set; }

        // Status of the appointment (Scheduled, Completed, Canceled, Rescheduled)
        [Required(ErrorMessage = "Appointment status is required.")]
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;

        // Optional notes with a max length of 500 characters
        [MaxLength(500, ErrorMessage = "Notes cannot exceed 500 characters.")]
        public string? Notes { get; set; }

        // Automatically set timestamps
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

   
