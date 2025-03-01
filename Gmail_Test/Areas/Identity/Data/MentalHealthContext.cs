using MentalHealthApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace MentalHealthApp.Data
{
    public class MentalHealthContext : IdentityDbContext<CustomUser>
    {
        public MentalHealthContext(DbContextOptions<MentalHealthContext> options)
            : base(options)
        {
        }

        public DbSet<MoodEntry> MoodEntries { get; set; }
        public DbSet<MoodType> MoodType { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


          builder.Entity<IdentityRole>().HasData(
              new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "Patient", NormalizedName = "PATIENT" },
                new IdentityRole { Id = "3", Name = "Therapist", NormalizedName = "THERAPIST" }
           );


            // Set table names
            builder.Entity<MoodEntry>().ToTable("MoodEntry");
            builder.Entity<MoodType>().ToTable("MoodTypes");



        }

     
    }
}
