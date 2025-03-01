using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentalHealthApp.Models
{

    public class MoodEntry
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int MoodId { get; set; } // Foreign Key for moodId from table MoodType

        [ForeignKey("MoodId")]
        public MoodType Mood { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now;

        [StringLength(200)]
        public string Notes { get; set; }


        public int PatientId { get; set; }
        public Patient Patient { get; set; } // Navigation property
    }

}
