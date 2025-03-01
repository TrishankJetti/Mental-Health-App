using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MentalHealthApp.Data;
using MentalHealthApp.Models;
using MentalHealthApp.Hubs;
using System.Configuration;
using Stripe;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("MentalHealthAppContextConnection") ?? throw new InvalidOperationException("Connection string 'MentalHealthAppContextConnection' not found.");

builder.Services.AddDbContext<MentalHealthContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<CustomUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<MentalHealthContext>();


builder.Services.AddSignalR();



// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication().AddGoogle(options =>
{
    options.ClientId = "756478333761-rhl418v3cl4ole5ac4fo9pu9h16t9o64.apps.googleusercontent.com";
    options.ClientSecret = "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";

    

});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();

app.UseAuthorization();

app.MapHub<ChatHub>("/chathub");

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();




