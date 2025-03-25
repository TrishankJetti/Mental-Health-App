using Microsoft.AspNetCore.Mvc.Rendering;
using MentalHealthApp.Models;

namespace MentalHealthApp.Models
{
    public class UserRoleViewModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; } // List of roles that user has
        public bool IsSelected { get; set; } // Selected role for each user
    }

}