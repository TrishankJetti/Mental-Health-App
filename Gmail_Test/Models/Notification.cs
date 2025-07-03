// 1. NOTIFICATION MODEL
using System;
using System.ComponentModel.DataAnnotations;

namespace MentalHealthApp.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty; // ASP.NET Identity UserId

        [Required]
        public string Message { get; set; } = string.Empty;

        public string? LinkUrl { get; set; } // Optional link

        public string? Type { get; set; } // E.g. "Appointment"

        public bool IsRead { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
