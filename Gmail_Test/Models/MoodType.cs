using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentalHealthApp.Models
{
    public class MoodType
    {
        [Key]
        public int MoodTypeId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Mood name cannot exceed 50 characters.")]
        public string Name { get; set; }
    }
}