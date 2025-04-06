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

    //No validaiton for these fields because external logins dont provide a way for us to input these fields so they are left null.
    //Hence we use front end validaiton to validate these fields.
    public string? FirstName { get; set; }
    public string? LastName { get; set; }


    public List<Patient> Patients { get; set; } = new();
}



