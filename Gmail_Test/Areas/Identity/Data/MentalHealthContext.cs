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
                },
                new CustomUser
                {
                    Id = "4",
                    UserName = "admin2@example.com",
                    NormalizedUserName = "ADMIN2@EXAMPLE.COM",
                    Email = "admin2@example.com",
                    NormalizedEmail = "ADMIN2@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "Second",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "AdminPassword456"),
                }
            );

            // Seed User Roles
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "1", RoleId = "1" }, // Admin
                new IdentityUserRole<string> { UserId = "2", RoleId = "3" }, // Therapist
                new IdentityUserRole<string> { UserId = "3", RoleId = "2" }, // Patient
                new IdentityUserRole<string> { UserId = "4", RoleId = "1" }  // Admin
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
                    UserId = "3"
                }
            );

            // Seed Mood Entries
            builder.Entity<MoodEntry>().HasData(
                new MoodEntry
                {
                    Id = 1,
                    UserId = "3",
                    MoodId = 1,
                    Date = DateTime.Now.AddDays(-1),
                    Notes = "Feeling great today!",
                    PatientId = 1
                }
            );

            // Seed Appointments
            builder.Entity<Appointment>().HasData(
                new Appointment
                {
                    AppointmentId = 1,
                    TherapistId = 1,
                    PatientId = 1,
                    AppointmentDate = DateTime.Now.AddDays(3).AddHours(10),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "Initial consultation session",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
        }
        public DbSet<MentalHealthApp.Models.ProductEntity> ProductEntity { get; set; } = default!;
    }
}
