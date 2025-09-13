// Models/Message.cs
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MentalHealthApp.Models
{
    public class Message
    {
        public int Id { get; set; } // Id of the message

        [Required]
        public string SenderId { get; set; } // Sender ID 

        [Required]
        public string ReceiverId { get; set; } // The id of the reciever

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; } // Content of the message

        public DateTime SentAt { get; set; } = DateTime.Now; //Sent at time
        public bool IsRead { get; set; } = false;  // Has the message been read?
         
        [ForeignKey("SenderId")]
        public virtual CustomUser Sender { get; set; } //Sender Id linked to customUser ID , or the identity user's id.

        [ForeignKey("ReceiverId")]
        public virtual CustomUser Receiver { get; set; } //Reciever Id linked to customUser ID , or the identity user's id.
    }
}