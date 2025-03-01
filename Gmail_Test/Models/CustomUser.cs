using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MentalHealthApp.Models;

// Add profile data for application users by adding properties to the MentalHealthAppUser class
public class CustomUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateOnly? DateOfBirth { get; set; }

    public List<Patient> Patients { get; set; } = new();
}



