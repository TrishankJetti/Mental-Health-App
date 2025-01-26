using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Gmail_Test.Data;
using Gmail_Test.Areas.Identity.Data;
using System.Configuration;
using Stripe;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Gmail_TestContextConnection") ?? throw new InvalidOperationException("Connection string 'Gmail_TestContextConnection' not found.");

builder.Services.AddDbContext<Gmail_TestContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<Gmail_TestUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<Gmail_TestContext>();

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

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
