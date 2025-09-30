using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentalHealthApp.Models
{
    public class CustomUser : IdentityUser
    {
        // Personal Info
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        

        // Mood Tracking / Streaks
        public int CurrentStreak { get; set; } = 0;   // how many days in a row
        public int LongestStreak { get; set; } = 0;   // longest streak ever
        public string Badge { get; set; } = "None";   // e.g., "Bronze", "Silver"
        public DateTime? LastMoodCheckIn { get; set; } // last time they posted

        // Profile Picture
        public string? PfpName { get; set; }  // filename stored in DB

        [NotMapped]
        [DisplayName("Upload PFP")]
        public IFormFile? PfpFile { get; set; } // temporary file for upload only
    }
}
