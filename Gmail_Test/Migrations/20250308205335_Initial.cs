using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoodTypes",
                columns: table => new
                {
                    MoodTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoodTypes", x => x.MoodTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Therapists",
                columns: table => new
                {
                    TherapistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapists", x => x.TherapistId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TherapistId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Therapists_TherapistId",
                        column: x => x.TherapistId,
                        principalTable: "Therapists",
                        principalColumn: "TherapistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoodEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoodId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoodEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoodEntries_MoodTypes_MoodId",
                        column: x => x.MoodId,
                        principalTable: "MoodTypes",
                        principalColumn: "MoodTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoodEntries_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Patient", "PATIENT" },
                    { "3", null, "Therapist", "THERAPIST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "705136a1-8a5d-4aa7-b8bf-b886a9129d5e", null, "admin@example.com", true, "System", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGV0J+kUY1jLwN0Ctkudp+Mx53i/rfCyUovc/jlu0VVAv/4wDYJJm/U8NoZvfKLYLQ==", null, false, "0d83ca11-6c64-45c2-96d7-21df7a85b555", false, "admin@example.com" },
                    { "2", 0, "5c2f89c5-23f6-4f02-a7a2-7d7a80f290b8", null, "therapist1@example.com", true, "John", "Doe", false, null, "THERAPIST1@EXAMPLE.COM", "THERAPIST1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO9P8wcx25jFu1TnhogQnYS+pb56G1FAvVEmQacimM2w8Y8zH/qJyLUXVWMPOARIyw==", null, false, "56cfa480-d2b2-47bc-a04b-70f04a86c672", false, "therapist1@example.com" },
                    { "3", 0, "3fd22eb4-1ada-48a4-930e-1cad7db3c753", null, "patient1@example.com", true, "Alice", "Smith", false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAECWKmPJA5BZj+D0K93nWdAsd+M6EGgw6edfJ+o/ArNDnjsFylMSLt63CaaDegbNt/Q==", null, false, "7eab8996-13f4-478b-8022-a92f19669d68", false, "patient1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "MoodTypes",
                columns: new[] { "MoodTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Happy" },
                    { 2, "Sad" },
                    { 3, "Anxious" },
                    { 4, "Angry" }
                });

            migrationBuilder.InsertData(
                table: "Therapists",
                columns: new[] { "TherapistId", "Bio", "Email", "FirstName", "LastName", "PhoneNumber", "Specialization", "UserId" },
                values: new object[] { 1, "Experienced CBT therapist.", "therapist1@example.com", "John", "Doe", "123-456-7890", "Cognitive Behavioral Therapy", "2" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, "Alice", "Smith", "1" },
                    { 2, "Jonathan", "Joestar", "2" },
                    { 3, "Yuno", "Kristopher", "3" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "CreatedAt", "DurationMinutes", "Notes", "PatientId", "Status", "TherapistId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 12, 19, 53, 35, 25, DateTimeKind.Local).AddTicks(3166), new DateTime(2025, 3, 9, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3168), 60, "Initial consultation session", 2, "Scheduled", 1, new DateTime(2025, 3, 9, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3170) },
                    { 2, new DateTime(2025, 3, 16, 23, 53, 35, 25, DateTimeKind.Local).AddTicks(3173), new DateTime(2025, 3, 9, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3175), 45, "Follow-up session", 3, "Scheduled", 1, new DateTime(2025, 3, 9, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3176) },
                    { 3, new DateTime(2025, 3, 4, 18, 53, 35, 25, DateTimeKind.Local).AddTicks(3179), new DateTime(2025, 3, 3, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3181), 60, "Discussed progress and next steps", 1, "Completed", 1, new DateTime(2025, 3, 4, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3182) }
                });

            migrationBuilder.InsertData(
                table: "MoodEntries",
                columns: new[] { "Id", "Date", "MoodId", "Notes", "PatientId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 8, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3007), 1, "Feeling great today!", 1, "1" },
                    { 2, new DateTime(2025, 3, 8, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3013), 3, "I have a test tommorow.", 2, "2" },
                    { 3, new DateTime(2025, 3, 8, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3015), 4, "I got fired from my job.", 3, "3" },
                    { 4, new DateTime(2025, 3, 7, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3018), 2, "Missed an important meeting.", 1, "1" },
                    { 5, new DateTime(2025, 3, 6, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3021), 1, "Had a great workout session!", 2, "2" },
                    { 6, new DateTime(2025, 3, 5, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3024), 3, "Feeling nervous about my interview.", 3, "3" },
                    { 7, new DateTime(2025, 3, 9, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3026), 4, "Traffic was terrible today.", 1, "1" },
                    { 8, new DateTime(2025, 3, 4, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3029), 1, "Finally finished my project!", 2, "2" },
                    { 9, new DateTime(2025, 3, 3, 9, 53, 35, 25, DateTimeKind.Local).AddTicks(3031), 2, "Had an argument with a friend.", 3, "3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_TherapistId",
                table: "Appointments",
                column: "TherapistId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MoodEntries_MoodId",
                table: "MoodEntries",
                column: "MoodId");

            migrationBuilder.CreateIndex(
                name: "IX_MoodEntries_PatientId",
                table: "MoodEntries",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserId",
                table: "Patients",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MoodEntries");

            migrationBuilder.DropTable(
                name: "Therapists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "MoodTypes");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
