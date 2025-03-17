using Microsoft.AspNetCore.Mvc.Rendering;
using MentalHealthApp.Models;

namespace MentalHealthApp.Models
{
    public class UserRoleViewModel
    {
        public string UserName { get; set; }
        public string UserId { get; set; }
        public List<SelectListItem> Roles { get; set; } // List of roles that user has
        public string SelectedRole { get; set; } // Selected role for each user
    }

}
