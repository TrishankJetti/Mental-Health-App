using System.ComponentModel.DataAnnotations;

namespace Gmail_Test.Models
{

    public enum Mood
    {
        Happy, Sad , Stressed, Angry , Normal 
    }


    public class MoodEntry
    {
        public int Id { get; set; }

      
        [Required]
        public string UserId { get; set; }


        [Required]
        [Display(Name = "Mood")]
        public Mood Mood { get; set; } // e.g., Happy, Sad, Stressed

        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now; // Auto-sets date

        [StringLength(200)]
        public string Notes { get; set; } // Optional notes
    }
}
