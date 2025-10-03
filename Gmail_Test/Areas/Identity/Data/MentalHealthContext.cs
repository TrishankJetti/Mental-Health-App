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
        public DbSet<Friendship> Friendships { get; set; }

        public DbSet<PlannerEvent> PlannerEvents { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MoodEntry> MoodEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PlannerEvent>() // Planner Event relation ship with CustomerUser class with the foreign key being UserId
            .HasOne(p => p.User)
            .WithMany()
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<Friendship>()      //Friendships have two users involved, one thats sending and one thats receiving the friendship. These Addresse and RequesterId point to UserId 
                                              // That belong to user's within the application that are using the CustomUser class. When either party is deleted the firendship will still stay.
                .HasOne(f => f.Requester)
                .WithMany()
                .HasForeignKey(f => f.RequesterId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Friendship>()
                  .HasOne(f => f.Addressee)
                  .WithMany()
                  .HasForeignKey(f => f.AddresseeId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Message>()   // A Message also has two aprties invovled the one sending and receiving the message. Both are linked to application users, or the CustomUser class and also have restrictions on delte.
                .HasOne(m => m.Sender)
                .WithMany()
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Message>()
                 .HasOne(m => m.Receiver)
                 .WithMany()
                 .HasForeignKey(m => m.ReceiverId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany()
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Notification>() // A Notification has a user and sender linked to it. The sender is the person sending the notificaiton and the user sis the one receiving the notificaiton. The notifcation will delete if the user is deleted, hence the cascade whilst when the sender is deleted the notifications stay in tact.
                .HasOne(n => n.Sender)
                .WithMany()
                .HasForeignKey(n => n.SenderId)
                .OnDelete(DeleteBehavior.Restrict);


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
                new Product
                {
                    Id = 1,
                    Category = ProductCategory.Other,
                    Price = 25m,
                    IsPrivate = false,
                    Name = "Shanti Black Tee",
                    Description = "Want to support our cause but rock some swag? This is the perfect choice for you!",
                    ImageUrl = "ShantiShirtMerch.png",
                    CreatedAt = DateTime.Now.AddDays(-2)
                },
                new Product
                {
                    Id = 2,
                    Category = ProductCategory.Other,
                    Price = 25m,
                    IsPrivate = false,
                    Name = "Shanti Plushy",
                    Description = "Get a fun plushy to be your companion!",
                    ImageUrl = "ShantiPlushy.jpg",
                    CreatedAt = DateTime.Now.AddDays(-6)
                },
                new Product
                {
                    Id = 3,
                    Name = "Wellness Book - 'Calm Your Mind'",
                    Description = "A bestselling book with practical tips for mental wellness.",
                    Price = 15.49m,
                    ImageUrl = "Wellbook.jpg",
                    IsPrivate = false,
                    Category = ProductCategory.Books,
                    CreatedAt = DateTime.Now.AddDays(-67)
                },
                new Product
                {
                    Id = 4,
                    Name = "Stress Relief Kit",
                    Description = "Includes stress balls, aroma oils, and calming teas.",
                    Price = 29.99m,
                    ImageUrl = "default-product.png",
                    IsPrivate = false,
                    Category = ProductCategory.StressRelief,
                    CreatedAt = DateTime.Now.AddDays(-14)
                }
            );


            // Seed Friendships
            builder.Entity<Friendship>().HasData(
                // Alice's friendships (User 14)
                new Friendship
                {
                    Id = 1,
                    RequesterId = "14", // Alice
                    AddresseeId = "15", // Mike
                    Status = FriendshipStatus.Accepted,
                    CreatedAt = DateTime.Now.AddDays(-10),
                    RespondedAt = DateTime.Now.AddDays(-9)
                },
                new Friendship
                {
                    Id = 2,
                    RequesterId = "14", // Alice
                    AddresseeId = "16", // Emily
                    Status = FriendshipStatus.Accepted,
                    CreatedAt = DateTime.Now.AddDays(-8),
                    RespondedAt = DateTime.Now.AddDays(-7)
                },
                new Friendship
                {
                    Id = 3,
                    RequesterId = "17", // David
                    AddresseeId = "14", // Alice
                    Status = FriendshipStatus.Accepted,
                    CreatedAt = DateTime.Now.AddDays(-5),
                    RespondedAt = DateTime.Now.AddDays(-4)
                },

                // Mike's friendships (User 15)
                new Friendship
                {
                    Id = 4,
                    RequesterId = "15", // Mike
                    AddresseeId = "17", // David
                    Status = FriendshipStatus.Accepted,
                    CreatedAt = DateTime.Now.AddDays(-12),
                    RespondedAt = DateTime.Now.AddDays(-11)
                },
                new Friendship
                {
                    Id = 5,
                    RequesterId = "18", // Sophia
                    AddresseeId = "15", // Mike
                    Status = FriendshipStatus.Pending, // Mike hasn't accepted yet
                    CreatedAt = DateTime.Now.AddDays(-2),
                    RespondedAt = null
                },

                // Emily's friendships (User 16)
                new Friendship
                {
                    Id = 6,
                    RequesterId = "16", // Emily
                    AddresseeId = "19", // James
                    Status = FriendshipStatus.Accepted,
                    CreatedAt = DateTime.Now.AddDays(-15),
                    RespondedAt = DateTime.Now.AddDays(-14)
                },
                new Friendship
                {
                    Id = 7,
                    RequesterId = "20", // Olivia
                    AddresseeId = "16", // Emily
                    Status = FriendshipStatus.Accepted,
                    CreatedAt = DateTime.Now.AddDays(-7),
                    RespondedAt = DateTime.Now.AddDays(-6)
                },

                // David's friendships (User 17)
                new Friendship
                {
                    Id = 8,
                    RequesterId = "17", // David
                    AddresseeId = "19", // James
                    Status = FriendshipStatus.Accepted,
                    CreatedAt = DateTime.Now.AddDays(-9),
                    RespondedAt = DateTime.Now.AddDays(-8)
                },

                // Sophia's friendships (User 18)
                new Friendship
                {
                    Id = 9,
                    RequesterId = "18", // Sophia
                    AddresseeId = "20", // Olivia
                    Status = FriendshipStatus.Accepted,
                    CreatedAt = DateTime.Now.AddDays(-11),
                    RespondedAt = DateTime.Now.AddDays(-10)
                },

                // James's friendships (User 19)
                new Friendship
                {
                    Id = 10,
                    RequesterId = "19", // James
                    AddresseeId = "20", // Olivia
                    Status = FriendshipStatus.Accepted,
                    CreatedAt = DateTime.Now.AddDays(-6),
                    RespondedAt = DateTime.Now.AddDays(-5)
                }
            );

            // Seed Messages
            builder.Entity<Message>().HasData(
                // Alice and Mike conversation
                new Message
                {
                    Id = 1,
                    SenderId = "14", // Alice
                    ReceiverId = "15", // Mike
                    Content = "Hey Mike! How are you feeling today?",
                    SentAt = DateTime.Now.AddHours(-48),
                    IsRead = true
                },
                new Message
                {
                    Id = 2,
                    SenderId = "15", // Mike
                    ReceiverId = "14", // Alice
                    Content = "Hi Alice! I'm doing okay, just a bit stressed about work. How about you?",
                    SentAt = DateTime.Now.AddHours(-46),
                    IsRead = true
                },
                new Message
                {
                    Id = 3,
                    SenderId = "14", // Alice
                    ReceiverId = "15", // Mike
                    Content = "I understand. Work has been tough for me too. Want to chat about it?",
                    SentAt = DateTime.Now.AddHours(-44),
                    IsRead = true
                },

                // Alice and Emily conversation
                new Message
                {
                    Id = 4,
                    SenderId = "14", // Alice
                    ReceiverId = "16", // Emily
                    Content = "Emily! I saw your mood entry from yesterday. Are you doing better today?",
                    SentAt = DateTime.Now.AddHours(-36),
                    IsRead = true
                },
                new Message
                {
                    Id = 5,
                    SenderId = "16", // Emily
                    ReceiverId = "14", // Alice
                    Content = "Thanks for checking in, Alice. I'm feeling much better today! 😊",
                    SentAt = DateTime.Now.AddHours(-34),
                    IsRead = true
                },

                // Mike and David conversation
                new Message
                {
                    Id = 6,
                    SenderId = "15", // Mike
                    ReceiverId = "17", // David
                    Content = "David, how do you handle stress? I'm really struggling this week.",
                    SentAt = DateTime.Now.AddHours(-72),
                    IsRead = true
                },
                new Message
                {
                    Id = 7,
                    SenderId = "17", // David
                    ReceiverId = "15", // Mike
                    Content = "I've been using the breathing exercises on the app. They really help! Want to try them together?",
                    SentAt = DateTime.Now.AddHours(-70),
                    IsRead = true
                },

                // Emily and James conversation
                new Message
                {
                    Id = 8,
                    SenderId = "16", // Emily
                    ReceiverId = "19", // James
                    Content = "James, I noticed we both had rough days yesterday. Want to support each other today?",
                    SentAt = DateTime.Now.AddHours(-24),
                    IsRead = true
                },
                new Message
                {
                    Id = 9,
                    SenderId = "19", // James
                    ReceiverId = "16", // Emily
                    Content = "That would be great, Emily. It helps to know we're not alone in this.",
                    SentAt = DateTime.Now.AddHours(-22),
                    IsRead = true
                },

                // Sophia and Olivia conversation
                new Message
                {
                    Id = 10,
                    SenderId = "18", // Sophia
                    ReceiverId = "20", // Olivia
                    Content = "Olivia! I'm so proud of your mood streak! 🎉",
                    SentAt = DateTime.Now.AddHours(-12),
                    IsRead = false // Olivia hasn't read it yet
                },

                // David and James conversation
                new Message
                {
                    Id = 11,
                    SenderId = "17", // David
                    ReceiverId = "19", // James
                    Content = "How's your pet doing, James? I've been thinking about you both.",
                    SentAt = DateTime.Now.AddHours(-6),
                    IsRead = false
                },

                // Group support messages
                new Message
                {
                    Id = 12,
                    SenderId = "14", // Alice
                    ReceiverId = "15", // Mike
                    Content = "Remember to use the breathing exercise if you feel overwhelmed!",
                    SentAt = DateTime.Now.AddHours(-3),
                    IsRead = true
                },
                new Message
                {
                    Id = 13,
                    SenderId = "16", // Emily
                    ReceiverId = "14", // Alice
                    Content = "Thanks for being such a good friend, Alice. It means a lot.",
                    SentAt = DateTime.Now.AddHours(-1),
                    IsRead = false
                }
            );

            // Seed Notifications for friend requests and messages
            builder.Entity<Notification>().HasData(
                // Pending friend request notification for Mike
                new Notification
                {
                    NotificationId = 1,
                    UserId = "15", // Mike
                    SenderId = "18", // Sophia
                    Message = "Sophia sent you a friend request",
                    CreatedAt = DateTime.Now.AddDays(-2),
                    IsRead = false
                },

                // Message notifications
                new Notification
                {
                    NotificationId = 2,
                    UserId = "20", // Olivia
                    SenderId = "18", // Sophia
                    Message = "New message from Sophia",
                    CreatedAt = DateTime.Now.AddHours(-12),
                    IsRead = false
                },
                new Notification
                {
                    NotificationId = 3,
                    UserId = "19", // James
                    SenderId = "17", // David
                    Message = "New message from David",
                    CreatedAt = DateTime.Now.AddHours(-6),
                    IsRead = false
                },
                new Notification
                {
                    NotificationId = 4,
                    UserId = "14", // Alice
                    SenderId = "16", // Emily
                    Message = "New message from Emily",
                    CreatedAt = DateTime.Now.AddHours(-1),
                    IsRead = false
                }
            );

           //Sample data for PlannerEvents table.
            builder.Entity<PlannerEvent>().HasData(
         
                new PlannerEvent
                {
                    Id = 1,
                    UserId = "14",
                    Title = "Morning Jog",
                    Description = "Jog in the park for 30 minutes",
                    StartTime = DateTime.Now.Date.AddHours(6),     
                    EndTime = DateTime.Now.Date.AddHours(6).AddMinutes(30),
                    EventType = EventType.Personal,
                    Priority = PriorityLevel.Medium,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now
                },
                new PlannerEvent
                {
                    Id = 2,
                    UserId = "14",
                    Title = "Therapy Session",
                    Description = "Weekly online therapy",
                    StartTime = DateTime.Now.Date.AddDays(1).AddHours(14), 
                    EndTime = DateTime.Now.Date.AddDays(1).AddHours(15),  
                    EventType = EventType.Health,
                    Priority = PriorityLevel.High,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now
                },

              
                new PlannerEvent
                {
                    Id = 3,
                    UserId = "15",
                    Title = "Work Meeting",
                    Description = "Project planning meeting",
                    StartTime = DateTime.Now.Date.AddHours(10),  
                    EndTime = DateTime.Now.Date.AddHours(11),    
                    EventType = EventType.Work,
                    Priority = PriorityLevel.High,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now
                },
                new PlannerEvent
                {
                    Id = 4,
                    UserId = "15",
                    Title = "Evening Walk",
                    Description = "Walk around neighborhood",
                    StartTime = DateTime.Now.Date.AddHours(18),  
                    EndTime = DateTime.Now.Date.AddHours(18).AddMinutes(45),
                    EventType = EventType.Health,
                    Priority = PriorityLevel.Low,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now
                },

   
                new PlannerEvent
                {
                    Id = 5,
                    UserId = "16",
                    Title = "Read a Book",
                    Description = "Read for 1 hour before bed",
                    StartTime = DateTime.Now.Date.AddDays(1).AddHours(20), // Tomorrow 8 PM
                    EndTime = DateTime.Now.Date.AddDays(1).AddHours(21),
                    EventType = EventType.Other,
                    Priority = PriorityLevel.Low,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now
                },

              
                new PlannerEvent
                {
                    Id = 6,
                    UserId = "17",
                    Title = "Gym Session",
                    Description = "Strength training",
                    StartTime = DateTime.Now.Date.AddHours(7),   // Today 7 AM
                    EndTime = DateTime.Now.Date.AddHours(8),
                    EventType = EventType.Health,
                    Priority = PriorityLevel.Medium,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now
                },

               
                new PlannerEvent
                {
                    Id = 7,
                    UserId = "18",
                    Title = "Meditation",
                    Description = "Morning meditation",
                    StartTime = DateTime.Now.Date.AddHours(6).AddMinutes(30), // Today 6:30 AM
                    EndTime = DateTime.Now.Date.AddHours(7),
                    EventType = EventType.Personal,
                    Priority = PriorityLevel.Medium,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now
                },

            
                new PlannerEvent
                {
                    Id = 8,
                    UserId = "19",
                    Title = "Doctor Appointment",
                    Description = "Routine check-up",
                    StartTime = DateTime.Now.Date.AddDays(2).AddHours(9),  // Day after tomorrow 9 AM
                    EndTime = DateTime.Now.Date.AddDays(2).AddHours(10),
                    EventType = EventType.Health,
                    Priority = PriorityLevel.High,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now
                },

           
                new PlannerEvent
                {
                    Id = 9,
                    UserId = "20",
                    Title = "Study Session",
                    Description = "Work on homework",
                    StartTime = DateTime.Now.Date.AddHours(16),  // Today 4 PM
                    EndTime = DateTime.Now.Date.AddHours(18),    // Today 6 PM
                    EventType = EventType.Study,
                    Priority = PriorityLevel.Medium,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now
                }
            );



        }

    }


}