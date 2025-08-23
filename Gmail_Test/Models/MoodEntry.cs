using System;
using System.ComponentModel.DataAnnotations;

namespace MentalHealthApp.Models
{
    public class MoodEntry
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "User ID is required.")]
        public string UserId { get; set; }  // Foreign key linking to User

        [Required(ErrorMessage = "Mood selection is required.")]
        public MoodType Mood { get; set; }  // use enum directly 🚀

        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now;

        [MaxLength(200, ErrorMessage = "Notes cannot exceed 200 characters.")]
        public string Notes { get; set; }  // Optional, but limited to 200 chars
    }

    public enum MoodType
    {
        Happy = 1,
        Sad = 2,
        Angry = 3,
        Stressed = 4,
        Excited = 5,
        Neutral = 6
    }
}
