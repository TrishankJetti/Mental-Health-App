using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Gmail_Test.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Gmail_TestUser class
public class Gmail_TestUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

