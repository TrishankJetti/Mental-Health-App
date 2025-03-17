using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MentalHealthApp.Data;
using MentalHealthApp.Models;
using MentalHealthApp.Hubs;
using Stripe;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// Configure Database Connection
var connectionString = builder.Configuration.GetConnectionString("MentalHealthAppContextConnection")
    ?? throw new InvalidOperationException("Connection string 'MentalHealthAppContextConnection' not found.");

builder.Services.AddDbContext<MentalHealthContext>(options =>
    options.UseSqlServer(connectionString));



builder.Services.AddIdentity<CustomUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
})
    .AddEntityFrameworkStores<MentalHealthContext>()
    .AddDefaultTokenProviders()
    .AddDefaultUI();  




builder.Services.AddSignalR();

// Add Controllers with Views and Razor Pages
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Configure Google Authentication
builder.Services.AddAuthentication()
    .AddGoogle(options =>
    {
        options.ClientId = "756478333761-rhl418v3cl4ole5ac4fo9pu9h16t9o64.apps.googleusercontent.com";
        options.ClientSecret = "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";
    });


var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();

app.UseAuthentication(); // Required for Identity
app.UseAuthorization();

// Map SignalR Hub
app.MapHub<ChatHub>("/chathub");

// Map Razor Pages and Controllers
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = services.GetRequiredService<UserManager<CustomUser>>();

    string[] roleNames = { "Admin", "User", "Therapist" }; // Add your roles here
    foreach (var roleName in roleNames)
    {
        var roleExists = await roleManager.RoleExistsAsync(roleName);
        if (!roleExists)
        {
            await roleManager.CreateAsync(new IdentityRole(roleName));
        }
    }

    // Assign Admin Role to a Default User (Optional)
    string adminEmail = "admin@example.com"; // Change this to your admin's email
    var adminUser = await userManager.FindByEmailAsync(adminEmail);
    if (adminUser != null && !(await userManager.IsInRoleAsync(adminUser, "Admin")))
    {
        await userManager.AddToRoleAsync(adminUser, "Admin");
    }
}


// Run the Application
app.Run();
