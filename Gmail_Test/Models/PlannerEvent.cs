using System;
using System.ComponentModel.DataAnnotations;

namespace MentalHealthApp.Models
{
    public class PlannerEvent
    {
        public int Id { get; set; } // Id for each event within the planner 

        [Required]
        public string UserId { get; set; } // UserId to differentiate between each user's Planner so they are unique

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; } // Title of the Event

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { get; set; } // Description of event

        [Required(ErrorMessage = "Start time is required.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; } // Start time of event

        [Required(ErrorMessage = "End time is required.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; } // End time of the event 

        [Required(ErrorMessage = "Please select an event type.")]
        public EventType EventType { get; set; } // Enum field for EventType defined below

        [Required(ErrorMessage = "Please set a priority level.")]
        public PriorityLevel Priority { get; set; } // Enum field for priority defined below

        public bool IsCompleted { get; set; } = false; // Checklist for completion

        public DateTime CreatedAt { get; set; } = DateTime.Now; // Date created
        public DateTime? UpdatedAt { get; set; } // Date last updated

        // Navigation property
        public virtual CustomUser User { get; set; }
    }

    public enum EventType
    {
        Study,
        Assignment,
        Exam,
        Work,
        Personal,
        Health,
        Social,
        Other
    }

    public enum PriorityLevel
    {
        Low,
        Medium,
        High,
        Critical
    }

   
}
