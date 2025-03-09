using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentalHealthApp.Models
{
    public class MoodEntry
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int MoodId { get; set; }
        [ForeignKey("MoodId")]
        public MoodType Mood { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now;

        [StringLength(200, ErrorMessage = "Notes cannot exceed 200 characters.")]
        public string Notes { get; set; }

        [Required]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}