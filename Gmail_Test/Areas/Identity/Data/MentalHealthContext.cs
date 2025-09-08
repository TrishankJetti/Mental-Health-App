using MentalHealthApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Emit;

namespace MentalHealthApp.Data
{
    public class MentalHealthContext : IdentityDbContext<CustomUser>
    {
        public MentalHealthContext(DbContextOptions<MentalHealthContext> options)
            : base(options)
        {
        }

        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Product> Products { get; set; }
 
        public DbSet<MoodEntry> MoodEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed Roles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "Patient", NormalizedName = "PATIENT" }
            );

            var hasher = new PasswordHasher<CustomUser>();
            var baseDate = DateTime.Now.Date; // Just an easier way to use DateTime.Now.Date

            // Seed Users (20 entries)
            builder.Entity<CustomUser>().HasData(
        // Admins
        new CustomUser
        {
            Id = "1",
            UserName = "admin@example.com",
            NormalizedUserName = "ADMIN@EXAMPLE.COM",
            Email = "admin@example.com",
            NormalizedEmail = "ADMIN@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "System",
            LastName = "Admin",
            PasswordHash = hasher.HashPassword(null, "AdminPassword123"),
            CurrentStreak = 0,
            LongestStreak = 0,
            Badge = "None",
            LastMoodCheckIn = null
        },
        new CustomUser
        {
            Id = "2",
            UserName = "admin2@example.com",
            NormalizedUserName = "ADMIN2@EXAMPLE.COM",
            Email = "admin2@example.com",
            NormalizedEmail = "ADMIN2@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Second",
            LastName = "Admin",
            PasswordHash = hasher.HashPassword(null, "AdminPassword456"),
            CurrentStreak = 0,
            LongestStreak = 0,
            Badge = "None",
            LastMoodCheckIn = null
        },
        new CustomUser
        {
            Id = "3",
            UserName = "admin3@example.com",
            NormalizedUserName = "ADMIN3@EXAMPLE.COM",
            Email = "admin3@example.com",
            NormalizedEmail = "ADMIN3@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Third",
            LastName = "Admin",
            PasswordHash = hasher.HashPassword(null, "AdminPassword789"),
            CurrentStreak = 0,
            LongestStreak = 0,
            Badge = "None",
            LastMoodCheckIn = null
        },

        // Patients
        // Patient 1 - Alice (UserId 14)
        new CustomUser
        {
            Id = "14",
            UserName = "patient1@example.com",
            NormalizedUserName = "PATIENT1@EXAMPLE.COM",
            Email = "patient1@example.com",
            NormalizedEmail = "PATIENT1@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Alice",
            LastName = "Smith",
            PasswordHash = hasher.HashPassword(null, "PatientPassword123"),
            CurrentStreak = 1,
            LongestStreak = 2,
            Badge = "Bronze",
            LastMoodCheckIn = baseDate.AddDays(-1) // last entry
        },

        // Patient 2 - Mike (UserId 15)
        new CustomUser
        {
            Id = "15",
            UserName = "patient2@example.com",
            NormalizedUserName = "PATIENT2@EXAMPLE.COM",
            Email = "patient2@example.com",
            NormalizedEmail = "PATIENT2@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Mike",
            LastName = "Johnson",
            PasswordHash = hasher.HashPassword(null, "PatientPassword456"),
            CurrentStreak = 1,
            LongestStreak = 1,
            Badge = "Bronze",
            LastMoodCheckIn = baseDate.AddDays(-1)
        },

        // Patient 3 - Emily (UserId 16)
        new CustomUser
        {
            Id = "16",
            UserName = "patient3@example.com",
            NormalizedUserName = "PATIENT3@EXAMPLE.COM",
            Email = "patient3@example.com",
            NormalizedEmail = "PATIENT3@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Emily",
            LastName = "Williams",
            PasswordHash = hasher.HashPassword(null, "PatientPassword789"),
            CurrentStreak = 1,
            LongestStreak = 1,
            Badge = "Bronze",
            LastMoodCheckIn = baseDate.AddDays(-2)
        },

        // Patient 4 - David (UserId 17)
        new CustomUser
        {
            Id = "17",
            UserName = "patient4@example.com",
            NormalizedUserName = "PATIENT4@EXAMPLE.COM",
            Email = "patient4@example.com",
            NormalizedEmail = "PATIENT4@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "David",
            LastName = "Lee",
            PasswordHash = hasher.HashPassword(null, "PatientPassword101"),
            CurrentStreak = 1,
            LongestStreak = 1,
            Badge = "Bronze",
            LastMoodCheckIn = baseDate.AddDays(-1)
        },

        // Patient 5 - Sophia (UserId 18)
        new CustomUser
        {
            Id = "18",
            UserName = "patient5@example.com",
            NormalizedUserName = "PATIENT5@EXAMPLE.COM",
            Email = "patient5@example.com",
            NormalizedEmail = "PATIENT5@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Sophia",
            LastName = "Garcia",
            PasswordHash = hasher.HashPassword(null, "PatientPassword112"),
            CurrentStreak = 1,
            LongestStreak = 1,
            Badge = "Bronze",
            LastMoodCheckIn = baseDate.AddDays(-2)
        },

        // Patient 6 - James (UserId 19)
        new CustomUser
        {
            Id = "19",
            UserName = "patient6@example.com",
            NormalizedUserName = "PATIENT6@EXAMPLE.COM",
            Email = "patient6@example.com",
            NormalizedEmail = "PATIENT6@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "James",
            LastName = "Wilson",
            PasswordHash = hasher.HashPassword(null, "PatientPassword131"),
            CurrentStreak = 1,
            LongestStreak = 1,
            Badge = "Bronze",
            LastMoodCheckIn = baseDate.AddDays(-1)
        },

        // Patient 7 - Olivia (UserId 20)
        new CustomUser
        {
            Id = "20",
            UserName = "patient7@example.com",
            NormalizedUserName = "PATIENT7@EXAMPLE.COM",
            Email = "patient7@example.com",
            NormalizedEmail = "PATIENT7@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Olivia",
            LastName = "Martinez",
            PasswordHash = hasher.HashPassword(null, "PatientPassword415"),
            CurrentStreak = 1,
            LongestStreak = 1,
            Badge = "Bronze",
            LastMoodCheckIn = baseDate.AddDays(-1)
        }
    );

            // Seed User Roles
            builder.Entity<IdentityUserRole<string>>().HasData(
                // Admins
                new IdentityUserRole<string> { UserId = "1", RoleId = "1" },
                new IdentityUserRole<string> { UserId = "2", RoleId = "1" },
                new IdentityUserRole<string> { UserId = "3", RoleId = "1" },
                // Patients
                new IdentityUserRole<string> { UserId = "14", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "15", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "16", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "17", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "18", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "19", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "20", RoleId = "2" }
            );

            // Seed MoodEntries (20 entries) - Using enum values cast to int
            builder.Entity<MoodEntry>().HasData(
                // Patient 1 (Alice - User ID 14)
                new MoodEntry { Id = 1, UserId = "14", Mood = MoodType.Happy, Date = baseDate.AddDays(-5), Notes = "Had a great day with friends" },
                new MoodEntry { Id = 2, UserId = "14", Mood = MoodType.Stressed, Date = baseDate.AddDays(-3), Notes = "Work stress is getting to me" },
                new MoodEntry { Id = 3, UserId = "14", Mood = MoodType.Neutral, Date = baseDate.AddDays(-1), Notes = "Feeling calm after meditation" },

                // Patient 2 (Mike - User ID 15)
                new MoodEntry { Id = 4, UserId = "15", Mood = MoodType.Sad, Date = baseDate.AddDays(-6), Notes = "Feeling down today" },
                new MoodEntry { Id = 5, UserId = "15", Mood = MoodType.Excited, Date = baseDate.AddDays(-2), Notes = "Excited for upcoming trip" },
                new MoodEntry { Id = 6, UserId = "15", Mood = MoodType.Stressed, Date = baseDate.AddDays(-1), Notes = "Stressed about work deadline" },

                // Patient 3 (Emily - User ID 16)
                new MoodEntry { Id = 7, UserId = "16", Mood = MoodType.Angry, Date = baseDate.AddDays(-7), Notes = "Angry about argument with friend" },
                new MoodEntry { Id = 8, UserId = "16", Mood = MoodType.Stressed, Date = baseDate.AddDays(-4), Notes = "Exhausted from lack of sleep" },
                new MoodEntry { Id = 9, UserId = "16", Mood = MoodType.Neutral, Date = baseDate.AddDays(-2), Notes = "Content with how things are going" },

                // Patient 4 (David - User ID 17)
                new MoodEntry { Id = 10, UserId = "17", Mood = MoodType.Sad, Date = baseDate.AddDays(-5), Notes = "Feeling lonely this weekend" },
                new MoodEntry { Id = 11, UserId = "17", Mood = MoodType.Happy, Date = baseDate.AddDays(-3), Notes = "Hopeful about therapy progress" },
                new MoodEntry { Id = 12, UserId = "17", Mood = MoodType.Neutral, Date = baseDate.AddDays(-1), Notes = "Confused about my feelings" },

                // Patient 5 (Sophia - User ID 18)
                new MoodEntry { Id = 13, UserId = "18", Mood = MoodType.Happy, Date = baseDate.AddDays(-4), Notes = "Happy about good news" },
                new MoodEntry { Id = 14, UserId = "18", Mood = MoodType.Stressed, Date = baseDate.AddDays(-2), Notes = "Anxious about upcoming test" },

                // Patient 6 (James - User ID 19
                new MoodEntry { Id = 15, UserId = "19", Mood = MoodType.Excited, Date = baseDate.AddDays(-6), Notes = "Excited to see family" },
                new MoodEntry { Id = 16, UserId = "19", Mood = MoodType.Neutral, Date = baseDate.AddDays(-3), Notes = "Calm after yoga session" },
                new MoodEntry { Id = 17, UserId = "19", Mood = MoodType.Sad, Date = baseDate.AddDays(-1), Notes = "Sad about pet being sick" },

                // Patient 7 (Olivia - User ID 20)
                new MoodEntry { Id = 18, UserId = "20", Mood = MoodType.Stressed, Date = baseDate.AddDays(-5), Notes = "Tired from work week" },
                new MoodEntry { Id = 19, UserId = "20", Mood = MoodType.Neutral, Date = baseDate.AddDays(-2), Notes = "Content with life right now" },
                new MoodEntry { Id = 20, UserId = "20", Mood = MoodType.Happy, Date = baseDate.AddDays(-1), Notes = "Hopeful about new treatment" }
            );

           

        builder.Entity<Product>().HasData(
                new Product { Id = 1, Category = ProductCategory.Other, Price = 25m, IsPrivate = false, Name = "Shanti Black Tee", Description = "Want to support our cause but rock some swag? This is the perfect  choice for you!", ImageUrl = "/img/ShantiShirtMerch.png" },
                new Product { Id = 2, Category = ProductCategory.Other, Price = 25m, IsPrivate = false, Name = "Shanti Plushy", Description = "Get a fun plushy to be your companion! ", ImageUrl = "/img/ShantiPlushy.png" },
                new Product
                {
                    Id = 3,
                    Name = "Wellness Book - 'Calm Your Mind'",
                    Description = "A bestselling book with practical tips for mental wellness.",
                    Price = 15.49m,
                    ImageUrl = "/img/Wellbook.png",
                    IsPrivate = false,
                    Category = ProductCategory.Books
                },
                 new Product
                 {
                     Id = 4,
                     Name = "Stress Relief Kit",
                     Description = "Includes stress balls, aroma oils, and calming teas.",
                     Price = 29.99m,
                     ImageUrl = "/img/stresskit.png",
                     IsPrivate = false,
                     Category = ProductCategory.StressRelief
                 }


                 );
        



        }



    }
}