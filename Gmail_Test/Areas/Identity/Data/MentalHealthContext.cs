using MentalHealthApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace MentalHealthApp.Data
{
    public class MentalHealthContext : IdentityDbContext<CustomUser>
    {
        public MentalHealthContext(DbContextOptions<MentalHealthContext> options)
            : base(options)
        {
        }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Therapist> Therapists { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<MoodEntry> MoodEntries { get; set; }
        public DbSet<MoodType> MoodTypes { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Appointment>()
                .Property(a => a.Status)
                .HasConversion<string>(); //Convert the Status Enum to a string variable so that each item in the array instead of being a vlue can be a string of cahracters.

            // Seed Roles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "Patient", NormalizedName = "PATIENT" },
                new IdentityRole { Id = "3", Name = "Therapist", NormalizedName = "THERAPIST" }
            );

            // Seed Mood Types (12 entries)
            builder.Entity<MoodType>().HasData(
                new MoodType { MoodTypeId = 1, Name = "Happy" },
                new MoodType { MoodTypeId = 2, Name = "Sad" },
                new MoodType { MoodTypeId = 3, Name = "Anxious" },
                new MoodType { MoodTypeId = 4, Name = "Angry" },
                new MoodType { MoodTypeId = 5, Name = "Excited" },
                new MoodType { MoodTypeId = 6, Name = "Calm" },
                new MoodType { MoodTypeId = 7, Name = "Tired" },
                new MoodType { MoodTypeId = 8, Name = "Stressed" },
                new MoodType { MoodTypeId = 9, Name = "Content" },
                new MoodType { MoodTypeId = 10, Name = "Lonely" },
                new MoodType { MoodTypeId = 11, Name = "Confused" },
                new MoodType { MoodTypeId = 12, Name = "Hopeful" }
            );

            var hasher = new PasswordHasher<CustomUser>();

            var baseDate = DateTime.Now.Date; //Just an easier way to use DateTime.Now.Date instead of repeating alot of code. This is done by initializing the variable.

            // Seed Users (20 entries)
            builder.Entity<CustomUser>().HasData(
                // Admins (3)
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
                    PasswordHash = hasher.HashPassword(null, "AdminPassword123")
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
                    PasswordHash = hasher.HashPassword(null, "AdminPassword456")
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
                    PasswordHash = hasher.HashPassword(null, "AdminPassword789")
                },

                // Therapists (10)
                new CustomUser
                {
                    Id = "4",
                    UserName = "therapist1@example.com",
                    NormalizedUserName = "THERAPIST1@EXAMPLE.COM",
                    Email = "therapist1@example.com",
                    NormalizedEmail = "THERAPIST1@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "John",
                    LastName = "Doe",
                    PasswordHash = hasher.HashPassword(null, "TherapistPassword123")
                },
                new CustomUser
                {
                    Id = "5",
                    UserName = "therapist2@example.com",
                    NormalizedUserName = "THERAPIST2@EXAMPLE.COM",
                    Email = "therapist2@example.com",
                    NormalizedEmail = "THERAPIST2@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "Sarah",
                    LastName = "Johnson",
                    PasswordHash = hasher.HashPassword(null, "TherapistPassword456")
                },
                new CustomUser
                {
                    Id = "6",
                    UserName = "therapist3@example.com",
                    NormalizedUserName = "THERAPIST3@EXAMPLE.COM",
                    Email = "therapist3@example.com",
                    NormalizedEmail = "THERAPIST3@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "Michael",
                    LastName = "Brown",
                    PasswordHash = hasher.HashPassword(null, "TherapistPassword789")
                },
                new CustomUser
                {
                    Id = "7",
                    UserName = "therapist4@example.com",
                    NormalizedUserName = "THERAPIST4@EXAMPLE.COM",
                    Email = "therapist4@example.com",
                    NormalizedEmail = "THERAPIST4@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "Jennifer",
                    LastName = "Davis",
                    PasswordHash = hasher.HashPassword(null, "TherapistPass123")
                },
                new CustomUser
                {
                    Id = "8",
                    UserName = "therapist5@example.com",
                    NormalizedUserName = "THERAPIST5@EXAMPLE.COM",
                    Email = "therapist5@example.com",
                    NormalizedEmail = "THERAPIST5@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "Robert",
                    LastName = "Miller",
                    PasswordHash = hasher.HashPassword(null, "TherapistPass456")
                },
                new CustomUser
                {
                    Id = "9",
                    UserName = "therapist6@example.com",
                    NormalizedUserName = "THERAPIST6@EXAMPLE.COM",
                    Email = "therapist6@example.com",
                    NormalizedEmail = "THERAPIST6@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "Lisa",
                    LastName = "Wilson",
                    PasswordHash = hasher.HashPassword(null, "TherapistPass789")
                },
                new CustomUser
                {
                    Id = "10",
                    UserName = "therapist7@example.com",
                    NormalizedUserName = "THERAPIST7@EXAMPLE.COM",
                    Email = "therapist7@example.com",
                    NormalizedEmail = "THERAPIST7@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "Thomas",
                    LastName = "Moore",
                    PasswordHash = hasher.HashPassword(null, "TherapistPass101")
                },
                new CustomUser
                {
                    Id = "11",
                    UserName = "therapist8@example.com",
                    NormalizedUserName = "THERAPIST8@EXAMPLE.COM",
                    Email = "therapist8@example.com",
                    NormalizedEmail = "THERAPIST8@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "Nancy",
                    LastName = "Taylor",
                    PasswordHash = hasher.HashPassword(null, "TherapistPass112")
                },
                new CustomUser
                {
                    Id = "12",
                    UserName = "therapist9@example.com",
                    NormalizedUserName = "THERAPIST9@EXAMPLE.COM",
                    Email = "therapist9@example.com",
                    NormalizedEmail = "THERAPIST9@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "Kevin",
                    LastName = "Anderson",
                    PasswordHash = hasher.HashPassword(null, "TherapistPass131")
                },
                new CustomUser
                {
                    Id = "13",
                    UserName = "therapist10@example.com",
                    NormalizedUserName = "THERAPIST10@EXAMPLE.COM",
                    Email = "therapist10@example.com",
                    NormalizedEmail = "THERAPIST10@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = "Emma",
                    LastName = "Thomas",
                    PasswordHash = hasher.HashPassword(null, "TherapistPass415")
                },

                // Patients (7)
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
                    PasswordHash = hasher.HashPassword(null, "PatientPassword123")
                },
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
                    PasswordHash = hasher.HashPassword(null, "PatientPassword456")
                },
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
                    PasswordHash = hasher.HashPassword(null, "PatientPassword789")
                },
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
                    PasswordHash = hasher.HashPassword(null, "PatientPassword101")
                },
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
                    PasswordHash = hasher.HashPassword(null, "PatientPassword112")
                },
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
                    PasswordHash = hasher.HashPassword(null, "PatientPassword131")
                },
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
                    PasswordHash = hasher.HashPassword(null, "PatientPassword415")
                }
            );

            // Seed User Roles
            builder.Entity<IdentityUserRole<string>>().HasData(
                // Admins
                new IdentityUserRole<string> { UserId = "1", RoleId = "1" },
                new IdentityUserRole<string> { UserId = "2", RoleId = "1" },
                new IdentityUserRole<string> { UserId = "3", RoleId = "1" },

                // Therapists
                new IdentityUserRole<string> { UserId = "4", RoleId = "3" },
                new IdentityUserRole<string> { UserId = "5", RoleId = "3" },
                new IdentityUserRole<string> { UserId = "6", RoleId = "3" },
                new IdentityUserRole<string> { UserId = "7", RoleId = "3" },
                new IdentityUserRole<string> { UserId = "8", RoleId = "3" },
                new IdentityUserRole<string> { UserId = "9", RoleId = "3" },
                new IdentityUserRole<string> { UserId = "10", RoleId = "3" },
                new IdentityUserRole<string> { UserId = "11", RoleId = "3" },
                new IdentityUserRole<string> { UserId = "12", RoleId = "3" },
                new IdentityUserRole<string> { UserId = "13", RoleId = "3" },

                // Patients
                new IdentityUserRole<string> { UserId = "14", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "15", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "16", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "17", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "18", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "19", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "20", RoleId = "2" }
            );

            // Seed Therapists (10 entries)
            builder.Entity<Therapist>().HasData(
                new Therapist
                {
                    TherapistId = 1,
                    UserId = "4",
                    FirstName = "John",
                    LastName = "Doe",
                    Specialization = "Cognitive Behavioral Therapy",
                    Bio = "10+ years experience with anxiety disorders",
                    Email = "therapist1@example.com",
                    PhoneNumber = "123-456-7890"
                },
                new Therapist
                {
                    TherapistId = 2,
                    UserId = "5",
                    FirstName = "Sarah",
                    LastName = "Johnson",
                    Specialization = "Family Therapy",
                    Bio = "Specializes in relationship counseling",
                    Email = "therapist2@example.com",
                    PhoneNumber = "234-567-8901"
                },
                new Therapist
                {
                    TherapistId = 3,
                    UserId = "6",
                    FirstName = "Michael",
                    LastName = "Brown",
                    Specialization = "Trauma Therapy",
                    Bio = "Expert in PTSD treatment",
                    Email = "therapist3@example.com",
                    PhoneNumber = "345-678-9012"
                },
                new Therapist
                {
                    TherapistId = 4,
                    UserId = "7",
                    FirstName = "Jennifer",
                    LastName = "Davis",
                    Specialization = "Child Psychology",
                    Bio = "Works with children and adolescents",
                    Email = "therapist4@example.com",
                    PhoneNumber = "456-789-0123"
                },
                new Therapist
                {
                    TherapistId = 5,
                    UserId = "8",
                    FirstName = "Robert",
                    LastName = "Miller",
                    Specialization = "Addiction Counseling",
                    Bio = "Substance abuse specialist",
                    Email = "therapist5@example.com",
                    PhoneNumber = "567-890-1234"
                },
                new Therapist
                {
                    TherapistId = 6,
                    UserId = "9",
                    FirstName = "Lisa",
                    LastName = "Wilson",
                    Specialization = "Eating Disorders",
                    Bio = "Helps with body image issues",
                    Email = "therapist6@example.com",
                    PhoneNumber = "678-901-2345"
                },
                new Therapist
                {
                    TherapistId = 7,
                    UserId = "10",
                    FirstName = "Thomas",
                    LastName = "Moore",
                    Specialization = "Couples Therapy",
                    Bio = "Relationship expert",
                    Email = "therapist7@example.com",
                    PhoneNumber = "789-012-3456"
                },
                new Therapist
                {
                    TherapistId = 8,
                    UserId = "11",
                    FirstName = "Nancy",
                    LastName = "Taylor",
                    Specialization = "Art Therapy",
                    Bio = "Creative approaches to healing",
                    Email = "therapist8@example.com",
                    PhoneNumber = "890-123-4567"
                },
                new Therapist
                {
                    TherapistId = 9,
                    UserId = "12",
                    FirstName = "Kevin",
                    LastName = "Anderson",
                    Specialization = "Sports Psychology",
                    Bio = "Performance and mental health",
                    Email = "therapist9@example.com",
                    PhoneNumber = "901-234-5678"
                },
                new Therapist
                {
                    TherapistId = 10,
                    UserId = "13",
                    FirstName = "Emma",
                    LastName = "Thomas",
                    Specialization = "Grief Counseling",
                    Bio = "Helping with loss and bereavement",
                    Email = "therapist10@example.com",
                    PhoneNumber = "012-345-6789"
                }
            );

            // Seed Patients (7 entries)
            builder.Entity<Patient>().HasData(
                new Patient { PatientId = 1, UserId = "14", FirstName = "Alice", LastName = "Smith" },
                new Patient { PatientId = 2, UserId = "15", FirstName = "Mike", LastName = "Johnson" },
                new Patient { PatientId = 3, UserId = "16", FirstName = "Emily", LastName = "Williams" },
                new Patient { PatientId = 4, UserId = "17", FirstName = "David", LastName = "Lee" },
                new Patient { PatientId = 5, UserId = "18", FirstName = "Sophia", LastName = "Garcia" },
                new Patient { PatientId = 6, UserId = "19", FirstName = "James", LastName = "Wilson" },
                new Patient { PatientId = 7, UserId = "20", FirstName = "Olivia", LastName = "Martinez" }
            );

            // Seed Mood Entries (20 entries)
            builder.Entity<MoodEntry>().HasData(
                // Patient 1 (Alice)
                new MoodEntry { Id = 1, UserId = "14", MoodId = 1, Date = baseDate.AddDays(-5), Notes = "Had a great day with friends", PatientId = 1 },
                new MoodEntry { Id = 2, UserId = "14", MoodId = 3, Date = baseDate.AddDays(-3), Notes = "Work stress is getting to me", PatientId = 1 },
                new MoodEntry { Id = 3, UserId = "14", MoodId = 6, Date = baseDate.AddDays(-1), Notes = "Feeling calm after meditation", PatientId = 1 },

                // Patient 2 (Mike)
                new MoodEntry { Id = 4, UserId = "15", MoodId = 2, Date = baseDate.AddDays(-6), Notes = "Feeling down today", PatientId = 2 },
                new MoodEntry { Id = 5, UserId = "15", MoodId = 5, Date = baseDate.AddDays(-2), Notes = "Excited for upcoming trip", PatientId = 2 },
                new MoodEntry { Id = 6, UserId = "15", MoodId = 8, Date = baseDate.AddDays(-1), Notes = "Stressed about work deadline", PatientId = 2 },

                // Patient 3 (Emily)
                new MoodEntry { Id = 7, UserId = "16", MoodId = 4, Date = baseDate.AddDays(-7), Notes = "Angry about argument with friend", PatientId = 3 },
                new MoodEntry { Id = 8, UserId = "16", MoodId = 7, Date = baseDate.AddDays(-4), Notes = "Exhausted from lack of sleep", PatientId = 3 },
                new MoodEntry { Id = 9, UserId = "16", MoodId = 9, Date = baseDate.AddDays(-2), Notes = "Content with how things are going", PatientId = 3 },

                // Patient 4 (David)
                new MoodEntry { Id = 10, UserId = "17", MoodId = 10, Date = baseDate.AddDays(-5), Notes = "Feeling lonely this weekend", PatientId = 4 },
                new MoodEntry { Id = 11, UserId = "17", MoodId = 12, Date = baseDate.AddDays(-3), Notes = "Hopeful about therapy progress", PatientId = 4 },
                new MoodEntry { Id = 12, UserId = "17", MoodId = 11, Date = baseDate.AddDays(-1), Notes = "Confused about my feelings", PatientId = 4 },

                // Patient 5 (Sophia)
                new MoodEntry { Id = 13, UserId = "18", MoodId = 1, Date = baseDate.AddDays(-4), Notes = "Happy about good news", PatientId = 5 },
                new MoodEntry { Id = 14, UserId = "18", MoodId = 3, Date = baseDate.AddDays(-2), Notes = "Anxious about upcoming test", PatientId = 5 },

                // Patient 6 (James)
                new MoodEntry { Id = 15, UserId = "19", MoodId = 5, Date = baseDate.AddDays(-6), Notes = "Excited to see family", PatientId = 6 },
                new MoodEntry { Id = 16, UserId = "19", MoodId = 6, Date = baseDate.AddDays(-3), Notes = "Calm after yoga session", PatientId = 6 },
                new MoodEntry { Id = 17, UserId = "19", MoodId = 2, Date = baseDate.AddDays(-1), Notes = "Sad about pet being sick", PatientId = 6 },

                // Patient 7 (Olivia)
                new MoodEntry { Id = 18, UserId = "20", MoodId = 7, Date = baseDate.AddDays(-5), Notes = "Tired from work week", PatientId = 7 },
                new MoodEntry { Id = 19, UserId = "20", MoodId = 9, Date = baseDate.AddDays(-2), Notes = "Content with life right now", PatientId = 7 },
                new MoodEntry { Id = 20, UserId = "20", MoodId = 12, Date = baseDate.AddDays(-1), Notes = "Hopeful about new treatment", PatientId = 7 }
            );

            // Seed Appointments (20 entries)
            builder.Entity<Appointment>().HasData(
                // Therapist 1 (John Doe)
                new Appointment
                {
                    AppointmentId = 1,
                    TherapistId = 1,
                    PatientId = 1,
                    AppointmentDate = baseDate.AddDays(1).AddHours(10),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "Initial consultation",
                    CreatedAt = baseDate.AddDays(-7),
                    UpdatedAt = baseDate.AddDays(-3)
                },
                new Appointment
                {
                    AppointmentId = 2,
                    TherapistId = 1,
                    PatientId = 2,
                    AppointmentDate = baseDate.AddDays(2).AddHours(11),
                    DurationMinutes = 45,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "Follow-up session",
                    CreatedAt = baseDate.AddDays(-5),
                    UpdatedAt = baseDate.AddDays(-2)
                },

                // Therapist 2 (Sarah Johnson)
                new Appointment
                {
                    AppointmentId = 3,
                    TherapistId = 2,
                    PatientId = 3,
                    AppointmentDate = baseDate.AddDays(1).AddHours(14),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "Family therapy",
                    CreatedAt = baseDate.AddDays(-4),
                    UpdatedAt = baseDate.AddDays(-1)
                },
                new Appointment
                {
                    AppointmentId = 4,
                    TherapistId = 2,
                    PatientId = 4,
                    AppointmentDate = baseDate.AddDays(3).AddHours(15),
                    DurationMinutes = 90,
                    Status = AppointmentStatus.Canceled,
                    Notes = "Couples counseling",
                    CreatedAt = baseDate.AddDays(-3),
                    UpdatedAt = baseDate
                },

                // Therapist 3 (Michael Brown)
                new Appointment
                {
                    AppointmentId = 5,
                    TherapistId = 3,
                    PatientId = 5,
                    AppointmentDate = baseDate.AddDays(2).AddHours(9),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Completed,
                    Notes = "Trauma session",
                    CreatedAt = baseDate.AddDays(-6),
                    UpdatedAt = baseDate.AddDays(-1)
                },
                new Appointment
                {
                    AppointmentId = 6,
                    TherapistId = 3,
                    PatientId = 6,
                    AppointmentDate = baseDate.AddDays(4).AddHours(10),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "PTSD follow-up",
                    CreatedAt = baseDate.AddDays(-5),
                    UpdatedAt = baseDate.AddDays(-2)
                },

                // Therapist 4 (Jennifer Davis)
                new Appointment
                {
                    AppointmentId = 7,
                    TherapistId = 4,
                    PatientId = 7,
                    AppointmentDate = baseDate.AddDays(1).AddHours(13),
                    DurationMinutes = 45,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "Child therapy evaluation",
                    CreatedAt = baseDate.AddDays(-5),
                    UpdatedAt = baseDate.AddDays(-1)
                },
                new Appointment
                {
                    AppointmentId = 8,
                    TherapistId = 4,
                    PatientId = 1,
                    AppointmentDate = baseDate.AddDays(5).AddHours(14),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "Adolescent counseling",
                    CreatedAt = baseDate.AddDays(-4),
                    UpdatedAt = baseDate
                },

                // Therapist 5 (Robert Miller)
                new Appointment
                {
                    AppointmentId = 9,
                    TherapistId = 5,
                    PatientId = 2,
                    AppointmentDate = baseDate.AddDays(3).AddHours(16),
                    DurationMinutes = 90,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "Addiction counseling",
                    CreatedAt = baseDate.AddDays(-4),
                    UpdatedAt = baseDate
                },
                new Appointment
                {
                    AppointmentId = 10,
                    TherapistId = 5,
                    PatientId = 3,
                    AppointmentDate = baseDate.AddDays(6).AddHours(11),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Rescheduled,
                    Notes = "Substance abuse follow-up",
                    CreatedAt = baseDate.AddDays(-7),
                    UpdatedAt = baseDate.AddDays(-1)
                },

                // Therapist 6 (Lisa Wilson)
                new Appointment
                {
                    AppointmentId = 11,
                    TherapistId = 6,
                    PatientId = 4,
                    AppointmentDate = baseDate.AddDays(2).AddHours(15),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "Eating disorder support",
                    CreatedAt = baseDate.AddDays(-3),
                    UpdatedAt = baseDate
                },
                new Appointment
                {
                    AppointmentId = 12,
                    TherapistId = 6,
                    PatientId = 5,
                    AppointmentDate = baseDate.AddDays(7).AddHours(10),
                    DurationMinutes = 90,
                    Status = AppointmentStatus.Rescheduled,
                    Notes = "Body image therapy",
                    CreatedAt = baseDate.AddDays(-2),
                    UpdatedAt = baseDate
                },

                // Therapist 7 (Thomas Moore)
                new Appointment
                {
                    AppointmentId = 13,
                    TherapistId = 7,
                    PatientId = 6,
                    AppointmentDate = baseDate.AddDays(4).AddHours(13),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "Couples therapy session",
                    CreatedAt = baseDate.AddDays(-2),
                    UpdatedAt = baseDate
                },
                new Appointment
                {
                    AppointmentId = 14,
                    TherapistId = 7,
                    PatientId = 7,
                    AppointmentDate = baseDate.AddDays(8).AddHours(14),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Completed,
                    Notes = "Relationship counseling",
                    CreatedAt = baseDate.AddDays(-7),
                    UpdatedAt = baseDate.AddDays(-1)
                },

                // Therapist 8 (Nancy Taylor)
                new Appointment
                {
                    AppointmentId = 15,
                    TherapistId = 8,
                    PatientId = 1,
                    AppointmentDate = baseDate.AddDays(3).AddHours(9),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "Art therapy introduction",
                    CreatedAt = baseDate.AddDays(-5),
                    UpdatedAt = baseDate.AddDays(-2)
                },
                new Appointment
                {
                    AppointmentId = 16,
                    TherapistId = 8,
                    PatientId = 2,
                    AppointmentDate = baseDate.AddDays(9).AddHours(11),
                    DurationMinutes = 90,
                    Status = AppointmentStatus.Completed,
                    Notes = "Creative expression session",
                    CreatedAt = baseDate.AddDays(-4),
                    UpdatedAt = baseDate
                },

                // Therapist 9 (Kevin Anderson)
                new Appointment
                {
                    AppointmentId = 17,
                    TherapistId = 9,
                    PatientId = 3,
                    AppointmentDate = baseDate.AddDays(5).AddHours(10),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "Sports performance anxiety",
                    CreatedAt = baseDate.AddDays(-3),
                    UpdatedAt = baseDate
                },
                new Appointment
                {
                    AppointmentId = 18,
                    TherapistId = 9,
                    PatientId = 4,
                    AppointmentDate = baseDate.AddDays(10).AddHours(15),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Completed,
                    Notes = "Competition stress management",
                    CreatedAt = baseDate.AddDays(-6),
                    UpdatedAt = baseDate.AddDays(-1)
                },

                // Therapist 10 (Emma Thomas)
                new Appointment
                {
                    AppointmentId = 19,
                    TherapistId = 10,
                    PatientId = 5,
                    AppointmentDate = baseDate.AddDays(6).AddHours(14),
                    DurationMinutes = 90,
                    Status = AppointmentStatus.Scheduled,
                    Notes = "Grief counseling",
                    CreatedAt = baseDate.AddDays(-4),
                    UpdatedAt = baseDate
                },
                new Appointment
                {
                    AppointmentId = 20,
                    TherapistId = 10,
                    PatientId = 6,
                    AppointmentDate = baseDate.AddDays(11).AddHours(16),
                    DurationMinutes = 60,
                    Status = AppointmentStatus.Rescheduled,
                    Notes = "Bereavement support",
                    CreatedAt = baseDate.AddDays(-5),
                    UpdatedAt = baseDate.AddDays(-2)
                }
            );
        }
        public DbSet<MentalHealthApp.Models.Product> Product { get; set; } = default!;

    }
}