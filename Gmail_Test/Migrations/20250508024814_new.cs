using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
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
                    Age = table.Column<int>(type: "int", nullable: true),
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
                name: "ProductEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductEntities", x => x.Id);
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
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "b5c4e7a4-a86d-48f2-98b9-853e1716b7b2", "admin@example.com", true, "System", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJLCfg6JjAeBCzjua118fVIWqUmXCGP/tb1+fjFH0bAPqhEzwTtpALV01KA23MMSIQ==", null, false, "a706b839-7cea-4601-9cc6-24f9f4060221", false, "admin@example.com" },
                    { "10", 0, null, "9a036680-c88b-4de4-ad6c-a4d915fc4cce", "therapist7@example.com", true, "Thomas", "Moore", false, null, "THERAPIST7@EXAMPLE.COM", "THERAPIST7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB94ufc2/NSQK57bOou9OwDMn+YXYgyfys1ZNGb7fj1zy0cs3d+nBMKCrOchZ9Gtow==", null, false, "8eb419ae-408f-40cf-a66e-e37a84feec5d", false, "therapist7@example.com" },
                    { "11", 0, null, "3aa295dc-67a5-4620-a8c2-84709402821b", "therapist8@example.com", true, "Nancy", "Taylor", false, null, "THERAPIST8@EXAMPLE.COM", "THERAPIST8@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI8soMDl2ZzBI/rIC3JDUOcYdcJiwAMV2kv/twqIipmAFQGqrovu57oTVDg2VxrCUQ==", null, false, "224d4769-547a-4767-8157-de8bdbe01826", false, "therapist8@example.com" },
                    { "12", 0, null, "d23460ea-cef9-45b5-b5b0-4a66d74b2b6a", "therapist9@example.com", true, "Kevin", "Anderson", false, null, "THERAPIST9@EXAMPLE.COM", "THERAPIST9@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHVduO7ZfSYmi3ELsueUjNuCaWU7NZCFnz4WHs3fDi3HpLEL2cyASlBMTrP/jsQ79A==", null, false, "0bc024f5-17e2-43d7-b87f-ceebb1ef0f93", false, "therapist9@example.com" },
                    { "13", 0, null, "51f50eda-5c57-4b81-8aae-386f60bd860f", "therapist10@example.com", true, "Emma", "Thomas", false, null, "THERAPIST10@EXAMPLE.COM", "THERAPIST10@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFqElQNsWRD9jDsBMkQYzuXu2jKZ1kN/7cTFrg9BfKJDdJ4YycxrqE/StjWuUwOuRw==", null, false, "9b8f7977-625a-40fc-93c6-37f4fc271999", false, "therapist10@example.com" },
                    { "14", 0, null, "a7e90eb9-0255-48d8-917c-97252873744d", "patient1@example.com", true, "Alice", "Smith", false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAXP/6cK+IB2akrPTyJe+yV1ii7OfSxSWJ6koUxzoZBHKnW9APKL7ux/4qLKd1Vk/A==", null, false, "65b50dbb-e03e-4e9f-a8ba-9a1e47edeb29", false, "patient1@example.com" },
                    { "15", 0, null, "2c0b13d5-7e4b-443e-9915-5c696abea97d", "patient2@example.com", true, "Mike", "Johnson", false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJQh+tYHjTXwJl9YhYueYhDfqUstkDAJ/jzhs98Ud8s2dQwHuswPodjE8ZkragYljw==", null, false, "083d64f5-a12b-4df8-8bfd-0bac2ba0a9b6", false, "patient2@example.com" },
                    { "16", 0, null, "79b10876-1ae8-47d8-a314-d8f4e86e6296", "patient3@example.com", true, "Emily", "Williams", false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJxw2i0baoUhdALkycjrUQRA3fx87rlhQMIQHdE26FoTe1gCgNr9EZcUXlLq9rLsPQ==", null, false, "280b2495-8226-4e21-bd7e-1cafd60ec214", false, "patient3@example.com" },
                    { "17", 0, null, "7f9e2b95-685c-40e8-9a85-dd7b889669e2", "patient4@example.com", true, "David", "Lee", false, null, "PATIENT4@EXAMPLE.COM", "PATIENT4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJhQXrRba3t0Oi29xfXnC2oigyBwz9UDVA1KGsTtf9JdqgILV2C/cTqFDRLTL6q9Pg==", null, false, "7406776c-1ddc-46d7-b4e7-23c15bfd48bc", false, "patient4@example.com" },
                    { "18", 0, null, "c0ee1fba-a3e4-450c-a234-1a8b9388edc1", "patient5@example.com", true, "Sophia", "Garcia", false, null, "PATIENT5@EXAMPLE.COM", "PATIENT5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIgUtUlW36+XUxOl54zzk+18ffuZK4hhLqVrYwStt9I6KSUYM8f4QSlAEvgYiKEE2g==", null, false, "fef67cb5-dcee-4d75-8f7f-645eca177781", false, "patient5@example.com" },
                    { "19", 0, null, "82379a55-cd80-43ad-8277-17413b201e41", "patient6@example.com", true, "James", "Wilson", false, null, "PATIENT6@EXAMPLE.COM", "PATIENT6@EXAMPLE.COM", "AQAAAAIAAYagAAAAECh06/V4SWojtPTX3GdaYvBzEJaQDqp5QmNWlh3CbOlrcU1Zt0B2MWnmxbDAYDfR2g==", null, false, "77465b80-8980-49e8-9cca-045d04054101", false, "patient6@example.com" },
                    { "2", 0, null, "2399f1a0-fa95-4c61-ae52-c79e95022b90", "admin2@example.com", true, "Second", "Admin", false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIfgBC6Vsv/iXa073h2HHM2mCj1U/23rjfoOw7EnrKEeg00/syDtpkxYwMd1txadTA==", null, false, "49fc208e-fa90-452b-9396-e41bd0f43e52", false, "admin2@example.com" },
                    { "20", 0, null, "090321bf-f05f-4056-a730-d260398b111b", "patient7@example.com", true, "Olivia", "Martinez", false, null, "PATIENT7@EXAMPLE.COM", "PATIENT7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL5v632eJ/7ky5wO5wo/qtzDk5cHs632MylqD4FkHuo7P9ECHmcgG8WJCVMFdn7Rew==", null, false, "597ca571-b42a-4bcc-b0d6-b94a15791310", false, "patient7@example.com" },
                    { "3", 0, null, "e1ec3dad-21d0-4dad-a832-d857855e81e7", "admin3@example.com", true, "Third", "Admin", false, null, "ADMIN3@EXAMPLE.COM", "ADMIN3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOrZ91J7LAonjUvhSIqFApfKp0lhws3N1rfb5CYl8RDupkPHFtamrH2hLXgQyt/hMw==", null, false, "77e054bf-582e-491f-a8ed-29412edf5d52", false, "admin3@example.com" },
                    { "4", 0, null, "4a1ed1ea-d9fe-49f4-b9f7-61b897014ef9", "therapist1@example.com", true, "John", "Doe", false, null, "THERAPIST1@EXAMPLE.COM", "THERAPIST1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBasAilszJit5F50DUk9J5x47gURKmixvUOmHL3QiOpGdBVaUZzEyVRQJ4mD4YANSg==", null, false, "35058ccf-78ef-458a-ba53-5e913abb3053", false, "therapist1@example.com" },
                    { "5", 0, null, "544f4991-1829-4682-b78d-6b4858405882", "therapist2@example.com", true, "Sarah", "Johnson", false, null, "THERAPIST2@EXAMPLE.COM", "THERAPIST2@EXAMPLE.COM", "AQAAAAIAAYagAAAAELIZL6/DkNchkiRllpL4X45bYNSDJb5zQiZl43laIAtSPfwrjeLznbrV3U3WSdpzvA==", null, false, "e9740859-ae3a-4d1d-86d7-81ed33381f61", false, "therapist2@example.com" },
                    { "6", 0, null, "fc61b04b-6e3d-42d5-aff6-4110e19fc0dc", "therapist3@example.com", true, "Michael", "Brown", false, null, "THERAPIST3@EXAMPLE.COM", "THERAPIST3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEImkFfW5dhW2wqiKxRcNOqHgVTAetX5ZcT9h0NTtTUke4YIenqAXX03qRI1rT8S/xw==", null, false, "9f5d3195-9d33-4358-ae76-900eabb419e2", false, "therapist3@example.com" },
                    { "7", 0, null, "f927d19b-b74e-46f0-9efb-1bdd184d9998", "therapist4@example.com", true, "Jennifer", "Davis", false, null, "THERAPIST4@EXAMPLE.COM", "THERAPIST4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF1pTKKqs8PZdQmonkgNV2gBVLUg1rGkVbHi0ykzX1oVBQDc0+HDmbt182JFYp/yIA==", null, false, "cb131fc1-ee9f-4acb-8e9b-0fdded0c354f", false, "therapist4@example.com" },
                    { "8", 0, null, "754538fc-ca83-46e9-9ca9-22e570632848", "therapist5@example.com", true, "Robert", "Miller", false, null, "THERAPIST5@EXAMPLE.COM", "THERAPIST5@EXAMPLE.COM", "AQAAAAIAAYagAAAAECo/70L+k3EiE/IPtLE2tSDcI29xgRY9w64j3H8wRBEGxucgME3hm3F9dUeeTVNBlw==", null, false, "9e35172f-653f-40df-a0f6-64e854c14e66", false, "therapist5@example.com" },
                    { "9", 0, null, "0a8da8b3-4058-414c-88d3-d6681f67e0b9", "therapist6@example.com", true, "Lisa", "Wilson", false, null, "THERAPIST6@EXAMPLE.COM", "THERAPIST6@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMG5ZSAxLUQfCbgQFrpZJX6MZ9451kQfPZ1Af4DtTBk6ZyeYWFo3VR70LNHqzLIriQ==", null, false, "b933fff3-0b11-4509-8a94-606d43816f93", false, "therapist6@example.com" }
                });

            migrationBuilder.InsertData(
                table: "MoodTypes",
                columns: new[] { "MoodTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Happy" },
                    { 2, "Sad" },
                    { 3, "Anxious" },
                    { 4, "Angry" },
                    { 5, "Excited" },
                    { 6, "Calm" },
                    { 7, "Tired" },
                    { 8, "Stressed" },
                    { 9, "Content" },
                    { 10, "Lonely" },
                    { 11, "Confused" },
                    { 12, "Hopeful" }
                });

            migrationBuilder.InsertData(
                table: "Therapists",
                columns: new[] { "TherapistId", "Bio", "Email", "FirstName", "LastName", "PhoneNumber", "Specialization", "UserId" },
                values: new object[,]
                {
                    { 1, "10+ years experience with anxiety disorders", "therapist1@example.com", "John", "Doe", "123-456-7890", "Cognitive Behavioral Therapy", "4" },
                    { 2, "Specializes in relationship counseling", "therapist2@example.com", "Sarah", "Johnson", "234-567-8901", "Family Therapy", "5" },
                    { 3, "Expert in PTSD treatment", "therapist3@example.com", "Michael", "Brown", "345-678-9012", "Trauma Therapy", "6" },
                    { 4, "Works with children and adolescents", "therapist4@example.com", "Jennifer", "Davis", "456-789-0123", "Child Psychology", "7" },
                    { 5, "Substance abuse specialist", "therapist5@example.com", "Robert", "Miller", "567-890-1234", "Addiction Counseling", "8" },
                    { 6, "Helps with body image issues", "therapist6@example.com", "Lisa", "Wilson", "678-901-2345", "Eating Disorders", "9" },
                    { 7, "Relationship expert", "therapist7@example.com", "Thomas", "Moore", "789-012-3456", "Couples Therapy", "10" },
                    { 8, "Creative approaches to healing", "therapist8@example.com", "Nancy", "Taylor", "890-123-4567", "Art Therapy", "11" },
                    { 9, "Performance and mental health", "therapist9@example.com", "Kevin", "Anderson", "901-234-5678", "Sports Psychology", "12" },
                    { 10, "Helping with loss and bereavement", "therapist10@example.com", "Emma", "Thomas", "012-345-6789", "Grief Counseling", "13" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "3", "10" },
                    { "3", "11" },
                    { "3", "12" },
                    { "3", "13" },
                    { "2", "14" },
                    { "2", "15" },
                    { "2", "16" },
                    { "2", "17" },
                    { "2", "18" },
                    { "2", "19" },
                    { "1", "2" },
                    { "2", "20" },
                    { "1", "3" },
                    { "3", "4" },
                    { "3", "5" },
                    { "3", "6" },
                    { "3", "7" },
                    { "3", "8" },
                    { "3", "9" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, "Alice", "Smith", "14" },
                    { 2, "Mike", "Johnson", "15" },
                    { 3, "Emily", "Williams", "16" },
                    { 4, "David", "Lee", "17" },
                    { 5, "Sophia", "Garcia", "18" },
                    { 6, "James", "Wilson", "19" },
                    { 7, "Olivia", "Martinez", "20" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "CreatedAt", "DurationMinutes", "Notes", "PatientId", "Status", "TherapistId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 9, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), 60, "Initial consultation", 1, "Scheduled", 1, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2025, 5, 10, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 45, "Follow-up session", 2, "Scheduled", 1, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2025, 5, 9, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 60, "Family therapy", 3, "Scheduled", 2, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2025, 5, 11, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 90, "Couples counseling", 4, "Canceled", 2, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2025, 5, 10, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), 60, "Trauma session", 5, "Completed", 3, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, new DateTime(2025, 5, 12, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 60, "PTSD follow-up", 6, "Scheduled", 3, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, new DateTime(2025, 5, 9, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 45, "Child therapy evaluation", 7, "Scheduled", 4, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, new DateTime(2025, 5, 13, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 60, "Adolescent counseling", 1, "Scheduled", 4, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, new DateTime(2025, 5, 11, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 90, "Addiction counseling", 2, "Scheduled", 5, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, new DateTime(2025, 5, 14, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), 60, "Substance abuse follow-up", 3, "Rescheduled", 5, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 11, new DateTime(2025, 5, 10, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 60, "Eating disorder support", 4, "Scheduled", 6, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 12, new DateTime(2025, 5, 15, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), 90, "Body image therapy", 5, "Rescheduled", 6, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 13, new DateTime(2025, 5, 12, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), 60, "Couples therapy session", 6, "Scheduled", 7, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 14, new DateTime(2025, 5, 16, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), 60, "Relationship counseling", 7, "Completed", 7, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 15, new DateTime(2025, 5, 11, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 60, "Art therapy introduction", 1, "Scheduled", 8, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 16, new DateTime(2025, 5, 17, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 90, "Creative expression session", 2, "Completed", 8, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 17, new DateTime(2025, 5, 13, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 60, "Sports performance anxiety", 3, "Scheduled", 9, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 18, new DateTime(2025, 5, 18, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), 60, "Competition stress management", 4, "Completed", 9, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 19, new DateTime(2025, 5, 14, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 90, "Grief counseling", 5, "Scheduled", 10, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 20, new DateTime(2025, 5, 19, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 60, "Bereavement support", 6, "Rescheduled", 10, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "MoodEntries",
                columns: new[] { "Id", "Date", "MoodId", "Notes", "PatientId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, "Had a great day with friends", 1, "14" },
                    { 2, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 3, "Work stress is getting to me", 1, "14" },
                    { 3, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 6, "Feeling calm after meditation", 1, "14" },
                    { 4, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), 2, "Feeling down today", 2, "15" },
                    { 5, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), 5, "Excited for upcoming trip", 2, "15" },
                    { 6, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 8, "Stressed about work deadline", 2, "15" },
                    { 7, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), 4, "Angry about argument with friend", 3, "16" },
                    { 8, new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 7, "Exhausted from lack of sleep", 3, "16" },
                    { 9, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), 9, "Content with how things are going", 3, "16" },
                    { 10, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 10, "Feeling lonely this weekend", 4, "17" },
                    { 11, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 12, "Hopeful about therapy progress", 4, "17" },
                    { 12, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 11, "Confused about my feelings", 4, "17" },
                    { 13, new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, "Happy about good news", 5, "18" },
                    { 14, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), 3, "Anxious about upcoming test", 5, "18" },
                    { 15, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), 5, "Excited to see family", 6, "19" },
                    { 16, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 6, "Calm after yoga session", 6, "19" },
                    { 17, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, "Sad about pet being sick", 6, "19" },
                    { 18, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 7, "Tired from work week", 7, "20" },
                    { 19, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), 9, "Content with life right now", 7, "20" },
                    { 20, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 12, "Hopeful about new treatment", 7, "20" }
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
                name: "ProductEntities");

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
