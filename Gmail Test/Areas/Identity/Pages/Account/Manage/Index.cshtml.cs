// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Gmail_Test.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gmail_Test.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<Gmail_TestUser> _userManager;
        private readonly SignInManager<Gmail_TestUser> _signInManager;

        public IndexModel(
            UserManager<Gmail_TestUser> userManager,
            SignInManager<Gmail_TestUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            
            [Display(Name = "Date of Birth")]
            public DateTime DateOfBirth { get; set; }

           
            [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "First Name must start with a capital letter and contain only letters.")]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            
            [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "Last Name must start with a capital letter and contain only letters.")]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Phone(ErrorMessage = "Invalid phone number format.")]
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(Gmail_TestUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth.HasValue
                    ? user.DateOfBirth.Value.ToDateTime(TimeOnly.MinValue) // Convert DateOnly to DateTime
                    : DateTime.Now // Use a default DateTime if null
            };
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

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            // Update custom fields
            user.FirstName = Input.FirstName;
            user.LastName = Input.LastName;
            user.DateOfBirth = DateOnly.FromDateTime(Input.DateOfBirth); // Convert DateTime to DateOnly

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                StatusMessage = "Unexpected error when updating profile.";
                return RedirectToPage();
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }


    }
}
