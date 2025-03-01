using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;


namespace MentalHealthApp.Models
{
    public class Therapist
    {
        public int TherapistId { get; set; }

        public string UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Specialization { get; set; }

        public string Bio { get;}

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
