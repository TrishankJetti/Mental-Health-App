using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MentalHealthApp.Areas.Identity;
using System.Linq;
using System.Threading.Tasks;
using MentalHealthApp.Models;

[Authorize(Roles = "Admin")]
public class RoleManagement : Controller
{
    private readonly UserManager<CustomUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public RoleManagement(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public IActionResult Index()
    {
        var users = _userManager.Users.ToList(); // Create a list full of the users in the asp identity table
        return View(users);
    }

    [HttpPost]
    public async Task<IActionResult> ManageRole(string userId, bool isAdmin, bool isTherapist , bool isPatient) // Task to manage user roles
    {
        // Find the user by their ID
        var user = await _userManager.FindByIdAsync(userId);

        // Return 404 if the user is not found
        if (user == null) return NotFound();

        // Assign or remove the "Admin" role based on the isAdmin flag
        if (isAdmin)
        {
            await _userManager.AddToRoleAsync(user, "Admin");
        }
        else
        {
            await _userManager.RemoveFromRoleAsync(user, "Admin");
        }

        // Assign or remove the "Therapist" role based on the isTherapist flag
        if (isTherapist)
        {
            await _userManager.AddToRoleAsync(user, "Therapist");
        }
        else
        {
            await _userManager.RemoveFromRoleAsync(user, "Therapist");
        }
        if (isPatient)
        {
            await _userManager.AddToRoleAsync(user, "Patient");
        }
        else
        {
            await _userManager.RemoveFromRoleAsync(user, "Patient");
        }


        // Redirect back to the index page after updating roles
        return RedirectToAction(nameof(Index));
    }
}

