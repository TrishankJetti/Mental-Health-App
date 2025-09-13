using System;
using System.ComponentModel.DataAnnotations;

namespace MentalHealthApp.Models
{
    public class MoodEntry
    {
        [Key]
        public int Id { get; set; } //Id for eahc MoodEntry

        [Required(ErrorMessage = "User ID is required.")]
        public string UserId { get; set; }   //UserId of current signed in user.

        [Required(ErrorMessage = "Mood selection is required.")]
        public MoodType Mood { get; set; }    //Enum for mood for each mood entry
         
        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date)]    
        public DateTime Date { get; set; } = DateTime.Now;    //Automatically sets the default value of the Date to the current DateTime.

        [MaxLength(200, ErrorMessage = "Notes cannot exceed 200 characters.")]
        public string Notes { get; set; }    // Extra notes for the MoodEntry
    }

    public enum MoodType //Enum for the Mood. 
    {
        Happy = 1,
        Sad = 2,
        Angry = 3,
        Stressed = 4,
        Excited = 5,
        Neutral = 6
    }
}
