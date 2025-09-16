using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MentalHealthApp.Models
{
    public class Notification
    {   //Notification IDs
        public int NotificationId { get; set; }

        [Required]  //Users id.
        public string UserId { get; set; } = string.Empty;

        [Required]
        public string Message { get; set; } = string.Empty; // Message i nthe notifiaiton by defualt is is empty.

        public bool IsRead { get; set; } = false; // IsRead is either true or false but flase by default.

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string? SenderId { get; set; }
        public int? MessageId { get; set; }
        public string? ConversationId { get; set; } 
        [ForeignKey("UserId")]
        public virtual CustomUser User { get; set; }

        [ForeignKey("SenderId")]
        public virtual CustomUser Sender { get; set; }
    }
}