using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentalHealthApp.Models
{
    public class MoodType
    {
        [Key] // Mood Id is the primary key and is unique identifier for each instance of the model.
        public int MoodTypeId { get; set; }

        [Required] //Name field for Mood, can only be 50 strings long.
        [StringLength(50, ErrorMessage = "Mood name cannot exceed 50 characters.")]
        public string Name { get; set; }
    }
}