using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentalHealthApp.Models
{
    public class MoodEntry
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "User ID is required.")]
        public string UserId { get; set; }  // Foreign key linking to User

        [Required(ErrorMessage = "Mood selection is required.")]
        public int MoodId { get; set; }

        [ForeignKey("MoodId")]
        public MoodType Mood { get; set; }  // Navigation property for MoodType

        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date)] // Date field is predefined on input since it already is given a value, b
        public DateTime Date { get; set; } = DateTime.Now;

        [MaxLength(200, ErrorMessage = "Notes cannot exceed 200 characters.")]
        public string Notes { get; set; }  // Optional, but limited to 200 characters

        [Required(ErrorMessage = "Patient ID is required.")]
        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }  // Navigation property for Patient

      
    }

}
