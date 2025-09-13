using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MentalHealthApp.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [Required]
        public string Message { get; set; } = string.Empty;

        public bool IsRead { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Add these for message notifications
        public string? SenderId { get; set; }
        public int? MessageId { get; set; }
        public string? ConversationId { get; set; } // Can be friendId or groupId

        [ForeignKey("UserId")]
        public virtual CustomUser User { get; set; }

        [ForeignKey("SenderId")]
        public virtual CustomUser Sender { get; set; }
    }
}