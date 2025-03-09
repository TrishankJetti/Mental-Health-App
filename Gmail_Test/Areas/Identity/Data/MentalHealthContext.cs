using MentalHealthApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MentalHealthApp.Data
{
    public class MentalHealthContext : IdentityDbContext<CustomUser>
    {
        public MentalHealthContext(DbContextOptions<MentalHealthContext> options)
            : base(options)
        {
        }

        public DbSet<Therapist> Therapists { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MoodEntry> MoodEntries { get; set; }
        public DbSet<MoodType> MoodTypes { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Store AppointmentStatus Enum as a string
            builder.Entity<Appointment>()
                .Property(a => a.Status)
                .HasConversion<string>();

            // Seed Identity Roles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "Patient", NormalizedName = "PATIENT" },
                new IdentityRole { Id = "3", Name = "Therapist", NormalizedName = "THERAPIST" }
            );

            // Seed Mood Types
            builder.Entity<MoodType>().HasData(
                new MoodType { MoodTypeId = 1, Name = "Happy" },
                new MoodType { MoodTypeId = 2, Name = "Sad" },
                new MoodType { MoodTypeId = 3, Name = "Anxious" },
                new MoodType { MoodTypeId = 4, Name = "Angry" }
            );

            var hasher = new PasswordHasher<CustomUser>();

            // Seed Users
            builder.Entity<CustomUser>().HasData(
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
                },
                new CustomUser
                {
                    Id = "2",
                    UserName = "therapist1@example.com",
                    NormalizedUserName = "THERAPIST1@EXAMPLE.COM",
                    Email = "therapist1@example.com",
                    NormalizedEmail = "THERAPIST1@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "John",
                    LastName = "Doe",
                    PasswordHash = hasher.HashPassword(null, "TherapistPassword123"),
                },
                new CustomUser
                {
                    Id = "3",
                    UserName = "patient1@example.com",
                    NormalizedUserName = "PATIENT1@EXAMPLE.COM",
                    Email = "patient1@example.com",
                    NormalizedEmail = "PATIENT1@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "Alice",
                    LastName = "Smith",
                    PasswordHash = hasher.HashPassword(null, "PatientPassword123"),
                }
            );

            // Seed Therapists
            builder.Entity<Therapist>().HasData(
                new Therapist
                {
                    TherapistId = 1,
                    UserId = "2",
                    FirstName = "John",
                    LastName = "Doe",
                    Specialization = "Cognitive Behavioral Therapy",
                    Bio = "Experienced CBT therapist.",
                    Email = "therapist1@example.com",
                    PhoneNumber = "123-456-7890"
                }
            );

            // Seed Patients
            builder.Entity<Patient>().HasData(
                new Patient
                {
                    PatientId = 1,
                    FirstName = "Alice",
                    LastName = "Smith",
                    UserId = "1"
                },
                new Patient
                {
                    PatientId = 2,
                    FirstName = "Jonathan",
                    LastName = "Joestar",
                    UserId = "2"
                },
                new Patient
                {
                    PatientId = 3,
                    FirstName = "Yuno",
                    LastName = "Kristopher",
                    UserId = "3"
                }
            );

            // Seed Mood Entries
            builder.Entity<MoodEntry>().HasData(
                new MoodEntry
                {
                    Id = 1,
                    UserId = "1",
                    MoodId = 1, // Happy
                    Date = DateTime.Now.AddDays(-1),
                    Notes = "Feeling great today!",
                    PatientId = 1
                },
                   new MoodEntry
                   {
                       Id = 2,
                       UserId = "2",
                       MoodId = 3, // Happy
                       Date = DateTime.Now.AddDays(-1),
                       Notes = "I have a test tommorow.",
                       PatientId = 2
                   },
                   new MoodEntry
                   {
                       Id = 3,
                       UserId = "3",
                       MoodId = 4, // Happy
                       Date = DateTime.Now.AddDays(-1),
                       Notes = "I got fired from my job.",
                       PatientId = 3
                   },
                   new MoodEntry
                   {
                       Id = 4,
                       UserId = "1",
                       MoodId = 2, // Sad
                       Date = DateTime.Now.AddDays(-2),
                       Notes = "Missed an important meeting.",
                       PatientId = 1
                   },
                    new MoodEntry
                    {
                        Id = 5,
                        UserId = "2",
                        MoodId = 1, // Happy
                        Date = DateTime.Now.AddDays(-3),
                        Notes = "Had a great workout session!",
                        PatientId = 2
                    },
                    new MoodEntry
                    {
                        Id = 6,
                        UserId = "3",
                        MoodId = 3, // Anxious
                        Date = DateTime.Now.AddDays(-4),
                        Notes = "Feeling nervous about my interview.",
                        PatientId = 3
                    },
                    new MoodEntry
                    {
                        Id = 7,
                        UserId = "1",
                        MoodId = 4, // Angry
                        Date = DateTime.Now,
                        Notes = "Traffic was terrible today.",
                        PatientId = 1
                    },
                    new MoodEntry
                    {
                        Id = 8,
                        UserId = "2",
                        MoodId = 1, // Happy
                        Date = DateTime.Now.AddDays(-5),
                        Notes = "Finally finished my project!",
                        PatientId = 2
                    },
                    new MoodEntry
                    {
                        Id = 9,
                        UserId = "3",
                        MoodId = 2, // Sad
                        Date = DateTime.Now.AddDays(-6),
                        Notes = "Had an argument with a friend.",
                        PatientId = 3
                    }
                            );

            // Seed Appointments with Enum
            builder.Entity<Appointment>().HasData(
                new Appointment
                {
                    AppointmentId = 1,
                    TherapistId = 1,
                    PatientId = 2,
                    AppointmentDate = DateTime.Now.AddDays(3).AddHours(10), // 3 days from now at 10 AM
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Scheduled, // Enum used here
                    Notes = "Initial consultation session",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Appointment
                {
                    AppointmentId = 2,
                    TherapistId = 1,
                    PatientId = 3,
                    AppointmentDate = DateTime.Now.AddDays(7).AddHours(14), // 7 days from now at 2 PM
                    DurationMinutes = 45,
                    Status = AppointmentStatus.Scheduled, // Enum used here
                    Notes = "Follow-up session",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Appointment
                {
                    AppointmentId = 3,
                    TherapistId = 1,
                    PatientId = 1,
                    AppointmentDate = DateTime.Now.AddDays(-5).AddHours(9), // 5 days ago at 9 AM
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Completed, // Enum used here
                    Notes = "Discussed progress and next steps",
                    CreatedAt = DateTime.Now.AddDays(-6),
                    UpdatedAt = DateTime.Now.AddDays(-5)
                }
            );
        }
    }
}
