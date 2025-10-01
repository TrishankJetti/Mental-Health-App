using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MentalHealthApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Authorize(Roles = "Admin")]
public class RoleManagementController : Controller
{
    private readonly UserManager<CustomUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public RoleManagementController(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task<IActionResult> Index(string role)
    {
        var users = _userManager.Users.ToList();
        var filteredUsers = new List<CustomUser>();

        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);
            if (string.IsNullOrEmpty(role) || roles.Contains(role))
            {
                filteredUsers.Add(user);
            }
        }

        // Send roles to the view for dropdown
        ViewBag.Roles = _roleManager.Roles.Select(r => r.Name).ToList();
        ViewBag.SelectedRole = role;

        return View(filteredUsers);
    }


    public async Task<IActionResult> ManageRole(string userId)
    {
        ViewBag.userId = userId;

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return NotFound();
        }

        var model = new List<UserRoleViewModel>();
        foreach (var role in _roleManager.Roles)
        {
            var userRolesViewModel = new UserRoleViewModel
            {
                RoleId = role.Id,
                RoleName = role.Name,
                IsSelected = await _userManager.IsInRoleAsync(user, role.Name)
            };
            model.Add(userRolesViewModel);
        }

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> ManageRole(string userId, string SelectedRole) // Only allows one role to be added to user.
    {
        var user = await _userManager.FindByIdAsync(userId); // Finds the user by their Id
        if (user == null)
        {
            return NotFound();
        }

        // Remove existing role from user before applyting then ew role. That way user doesnt have two roles to their name isntead of one.
        var roles = await _userManager.GetRolesAsync(user);
        await _userManager.RemoveFromRolesAsync(user, roles);

        // Add the new single role
        if (!string.IsNullOrEmpty(SelectedRole))
        {
            await _userManager.AddToRoleAsync(user, SelectedRole);
        }

        return RedirectToAction(nameof(Index)); // Return to index view.
    }

}