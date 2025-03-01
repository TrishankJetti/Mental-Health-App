using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentalHealthApp.Models
{
    public class MoodType
    {
        public int Id { get; set; }  // Primary Key

        [Required]
        public string Name { get; set; } // "Happy", "Sad", etc.

        public string? MoodImage { get; set; } // Image file path

        [NotMapped] // This prevents the file from being stored in the DB
        public IFormFile? ImageFile { get; set; }
    }
}
