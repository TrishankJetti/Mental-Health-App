using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Threading.Tasks;
using MentalHealthApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MentalHealthApp.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<CustomUser> _userManager;
        private readonly SignInManager<CustomUser> _signInManager;
        private readonly IWebHostEnvironment _environment;

        public IndexModel(
            UserManager<CustomUser> userManager,
            SignInManager<CustomUser> signInManager,
            IWebHostEnvironment environment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _environment = environment;
        }

        public string Username { get; set; }
        public string CurrentProfilePicture { get; set; } = string.Empty; // Initialize as empty string if user hasnt set a pfp yet. 

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "First Name must start with a capital letter and contain only letters.")]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "Last Name must start with a capital letter and contain only letters.")]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [NotMapped]
            [DisplayName("Profile Picture")]
            public IFormFile PfpFile { get; set; }
        }

        private async Task LoadAsync(CustomUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            Username = userName;

            Input = new InputModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName
            };

            // Store current profile picture for display
            CurrentProfilePicture = user.PfpName ?? string.Empty; // Handle null PfpName, if the pfpName is empty.
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            // Update names
            if (Input.FirstName != user.FirstName)
            {
                user.FirstName = Input.FirstName;
            }

            if (Input.LastName != user.LastName)
            {
                user.LastName = Input.LastName;
            }

            // Handle profile picture upload
            // Handle profile picture upload
            if (Input.PfpFile != null && Input.PfpFile.Length > 0)
            {
                // Validate file type and size
                var validExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                var extension = Path.GetExtension(Input.PfpFile.FileName).ToLower();

                if (!validExtensions.Contains(extension))
                {
                    ModelState.AddModelError("Input.PfpFile", "Only image files (JPG, PNG, GIF) are allowed.");
                    await LoadAsync(user);
                    return Page();
                }

                var uploadsFolder = Path.Combine(_environment.WebRootPath, "img", "pfps");
                Directory.CreateDirectory(uploadsFolder); // Creates folder if doesn't exist

                var uniqueFileName = $"{Guid.NewGuid()}{extension}";
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await Input.PfpFile.CopyToAsync(fileStream);
                }

                // Delete old pic if exists
                if (!string.IsNullOrEmpty(user.PfpName) &&
                    user.PfpName != "default-pfp.png" )
                   
                {
                    var oldFilePath = Path.Combine(_environment.WebRootPath, "img", "pfps", user.PfpName);
                    if (System.IO.File.Exists(oldFilePath))
                    {
                        System.IO.File.Delete(oldFilePath);
                    }
                }

                user.PfpName = uniqueFileName;
            }

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                foreach (var error in updateResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                await LoadAsync(user);
                return Page();
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}