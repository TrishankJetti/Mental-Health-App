// Models/Friendship.cs
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MentalHealthApp.Models
{
    public class Friendship
    {
        public int Id { get; set; } // Friendship ID 

        [Required]
        public string RequesterId { get; set; } //Requester's ID

        [Required]
        public string AddresseeId { get; set; } //Email Adress of user

        public FriendshipStatus Status { get; set; } = FriendshipStatus.Pending;  // Freindship status enum 
        public DateTime CreatedAt { get; set; } = DateTime.Now;   // Created time 
        public DateTime? RespondedAt { get; set; } // Response time 

        [ForeignKey("RequesterId")]
        public virtual CustomUser Requester { get; set; } //Requester Id from the Custom user's email id 

        [ForeignKey("AddresseeId")]
        public virtual CustomUser Addressee { get; set; } // Address derived fro mthe Custom user's email.
    }

    public enum FriendshipStatus  // Friendship status either blocked, accepted, pending, or declined. 
    {
        Pending, // User hasnt aceepted or rejected
        Accepted, // User has accepted the friendship
        Declined, // User has declined the friendship
        Blocked   //User has blocked the other other user as a friend and will nto be able to interact with them.
    }
}