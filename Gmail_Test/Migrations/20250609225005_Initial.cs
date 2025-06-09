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
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { "1", 0, null, "25f7beb4-52e1-4e96-92d5-0bbf27e4d3a3", "admin@example.com", true, "System", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEZa4vmLjhAc8fXG5Mz7LdC+SO9q82Cce5sWCC8dij6M4Y4SYtkTTqsqvGymYanE+A==", null, false, "7d8b5cc1-bfff-4df9-8019-dac49e469e54", false, "admin@example.com" },
                    { "10", 0, null, "c73a7d68-0e7d-458c-be7a-b50016820c4c", "therapist7@example.com", true, "Thomas", "Moore", false, null, "THERAPIST7@EXAMPLE.COM", "THERAPIST7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDL8T6ca94nmgTuaRyaDALCjznU7x2K+l9M+nY/Z43RsJQvZJeZ+nQop1u6nCmRO/g==", null, false, "c4ca2b4f-9184-4d14-9930-df460af7a753", false, "therapist7@example.com" },
                    { "11", 0, null, "c4629b5a-9881-4cdb-b18d-0f982d98aa47", "therapist8@example.com", true, "Nancy", "Taylor", false, null, "THERAPIST8@EXAMPLE.COM", "THERAPIST8@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFZaRvnGj202W1d/zY4/Qr88MWAoFPGKLrTIZo9/Y+J44jc1FJOoxdBBdQa8LudUSQ==", null, false, "584ea6ca-803b-4495-ae72-e16b66bd4862", false, "therapist8@example.com" },
                    { "12", 0, null, "b7adf9cf-694c-4f68-ae2f-afbfabcfd76b", "therapist9@example.com", true, "Kevin", "Anderson", false, null, "THERAPIST9@EXAMPLE.COM", "THERAPIST9@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDf71uR+ZmrJizkP1rBp2o4mxwWjvv6IApecfxu3VoG/CjBwYRiJ1zSm+TaZVVWHVg==", null, false, "9a6d0b03-0f9e-4198-a1dc-38221549a189", false, "therapist9@example.com" },
                    { "13", 0, null, "bfcd270d-2411-49cd-b5b6-ec39e28b4ad5", "therapist10@example.com", true, "Emma", "Thomas", false, null, "THERAPIST10@EXAMPLE.COM", "THERAPIST10@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMtwOkMmNS9E5YaGfmLsIo90T8I+smOTq2KIR99v9Jn+tMu0xB207am0SvzHcgDTIA==", null, false, "19587d42-9df7-4ff7-a572-fd67bec2c1c7", false, "therapist10@example.com" },
                    { "14", 0, null, "02126ee0-8972-445b-87b9-4aa4f0927586", "patient1@example.com", true, "Alice", "Smith", false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDboKd+edGE8bL3GGrg4G/dCTs8RRknOE+f/TSpjx/zxHvU4iWQ5KSGZdAMUgH7A/Q==", null, false, "71bab9bf-0a1d-4c45-bfea-1acff24c0f53", false, "patient1@example.com" },
                    { "15", 0, null, "d3b01956-ce0f-412b-b027-ebd7d35319a2", "patient2@example.com", true, "Mike", "Johnson", false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFciPYq1NJcug9Z3H7YJLsseHCKFS3wpT59FR8McAjMorvvTXkRq9cBI1eH5WsfcJA==", null, false, "62cb9bf2-89f7-4d31-b1b1-256d9e02f40a", false, "patient2@example.com" },
                    { "16", 0, null, "6b7ffe42-479c-438b-93ad-87aa7405ba15", "patient3@example.com", true, "Emily", "Williams", false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEYPE+REyJUvIpd5oGLiL1h52I1gDYlH5hd5TEa9zbmyI5vNhN9gY0CTmiUCNyM3uw==", null, false, "f2d83c32-ac51-4c0f-8624-a065c9f9e09e", false, "patient3@example.com" },
                    { "17", 0, null, "787fab5a-b157-4d2d-8dc2-857762d958ed", "patient4@example.com", true, "David", "Lee", false, null, "PATIENT4@EXAMPLE.COM", "PATIENT4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDf/opbUjLr9SQ9fKOAOtiu2gg3guL1topD2igdEmt4YqjGD0MkFuVIPCqBDu+/EWg==", null, false, "d8ae8644-dcd7-4efa-8a50-1d05feb761f8", false, "patient4@example.com" },
                    { "18", 0, null, "8ca94306-cf5a-4cf0-a07d-7828c5f8d8c1", "patient5@example.com", true, "Sophia", "Garcia", false, null, "PATIENT5@EXAMPLE.COM", "PATIENT5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGqOd3/22FFSnzN0IP2mrWEjyIEznkpMHB8O5Kdd8y1EJnW8uD/VuqN5ybah1YdsUg==", null, false, "ea0ae00e-eb2d-4a61-ac83-b0514f5523c0", false, "patient5@example.com" },
                    { "19", 0, null, "a712e0e4-8770-4ce8-9fcd-c6a4540d3118", "patient6@example.com", true, "James", "Wilson", false, null, "PATIENT6@EXAMPLE.COM", "PATIENT6@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO6dKiaEbMf0sb4c4dHNHT9nNDuRvPh0E66u2c2j6x0bs8zZQMCk7CubL6xYJkNBog==", null, false, "a80c921b-22e0-4282-84c7-ef8d5378a30a", false, "patient6@example.com" },
                    { "2", 0, null, "a7902a04-fb69-44ad-9cfb-2e956f859dbe", "admin2@example.com", true, "Second", "Admin", false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDnVwhkufzss8QF1lgrVV8BDxipxVosgeWcKu9o6aP3BHt79rRWTNT1JQdgBTjj5rg==", null, false, "99f81f13-c28b-49f1-a864-05e680f7b9b1", false, "admin2@example.com" },
                    { "20", 0, null, "d858c77a-2bc4-448d-84f7-07ee40398ffd", "patient7@example.com", true, "Olivia", "Martinez", false, null, "PATIENT7@EXAMPLE.COM", "PATIENT7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGYYHvWvQ94BjJL8tZJrvhijsvH1NQuPrAGiuaJPgqMu9vkzIQVMG4FKHdMy7+0ULg==", null, false, "5a2dc4ac-0b9b-418f-a47a-6d64bf1f257a", false, "patient7@example.com" },
                    { "3", 0, null, "ebec60a6-e493-4d06-982a-270c16ea85d1", "admin3@example.com", true, "Third", "Admin", false, null, "ADMIN3@EXAMPLE.COM", "ADMIN3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMeuRIgyN+ApIG/BT7iYEE0bVWGxHG8H+hia3raVpeSmZJIzIw38d+LzKqYH/UphrA==", null, false, "67805fcd-2791-476e-943c-a425c2870f74", false, "admin3@example.com" },
                    { "4", 0, null, "7f007868-61db-4bc9-97c2-42d91b6752de", "therapist1@example.com", true, "John", "Doe", false, null, "THERAPIST1@EXAMPLE.COM", "THERAPIST1@EXAMPLE.COM", "AQAAAAIAAYagAAAAENz+whnDds0OaO26HihawJRMsoYN8qYW+qqJeOx3viBZQmhhTELrICeiJM0/ABVpew==", null, false, "8a363305-7a9c-49da-8215-ee6dafde7f65", false, "therapist1@example.com" },
                    { "5", 0, null, "f69f9391-c291-4ec1-bf4b-4a2f17ca4633", "therapist2@example.com", true, "Sarah", "Johnson", false, null, "THERAPIST2@EXAMPLE.COM", "THERAPIST2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBicOjCjf0Q2gSVB1rrwkoetJ05Xd03iguD+wyU/wBX/ZndEOBDyLHBh5q+U+iTceg==", null, false, "059dcd61-723c-474a-a5cf-b988272dcb29", false, "therapist2@example.com" },
                    { "6", 0, null, "dce8cfff-0a0e-465f-880e-cf67f066b283", "therapist3@example.com", true, "Michael", "Brown", false, null, "THERAPIST3@EXAMPLE.COM", "THERAPIST3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF+CmMYBAst/KIg29n6Hc2lcEtJmtB8mBqHClpaWgtazv7EcxitIfY2oxAYNe1OgYQ==", null, false, "16ac0659-7039-4941-b152-4137c9e3ece0", false, "therapist3@example.com" },
                    { "7", 0, null, "e3319cb6-4db0-47c2-a1b0-7c6d0fc90b90", "therapist4@example.com", true, "Jennifer", "Davis", false, null, "THERAPIST4@EXAMPLE.COM", "THERAPIST4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOGlnCr11OoC2LoRkXTgCS5amT2CbMP2qARj/+4GyjvYvD+r5+nfhD3WdMPoLfcbhQ==", null, false, "8b5bef60-d1f4-4131-b302-cc3d1dcc1c3c", false, "therapist4@example.com" },
                    { "8", 0, null, "a1038812-c620-45e1-b1b1-0568f67900e2", "therapist5@example.com", true, "Robert", "Miller", false, null, "THERAPIST5@EXAMPLE.COM", "THERAPIST5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFnFJRM9TmHYcndPaLh0XU/OOG2qm0wJlgxZgtr8T446oIGgVfqMgX7Hs2R647lXxA==", null, false, "3a95f4e4-f0b0-42fd-93d5-ee9cb51674d5", false, "therapist5@example.com" },
                    { "9", 0, null, "05c6c849-da63-47e5-91f1-d19de7ec6125", "therapist6@example.com", true, "Lisa", "Wilson", false, null, "THERAPIST6@EXAMPLE.COM", "THERAPIST6@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM5dy5dIpRGuWzv4ZYaKF/p7nI/rWgK/oR07+Zv3KPhAp6t3XOaPrubiExWU0nMmKQ==", null, false, "296e4c2a-0fcb-4e72-834d-5ced59a2d896", false, "therapist6@example.com" }
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
                columns: new[] { "TherapistId", "Bio", "Email", "FirstName", "ImageFileName", "LastName", "PhoneNumber", "Specialization", "UserId" },
                values: new object[,]
                {
                    { 1, "10+ years experience with anxiety disorders", "therapist1@example.com", "John", null, "Doe", "123-456-7890", "Cognitive Behavioral Therapy", "4" },
                    { 2, "Specializes in relationship counseling", "therapist2@example.com", "Sarah", null, "Johnson", "234-567-8901", "Family Therapy", "5" },
                    { 3, "Expert in PTSD treatment", "therapist3@example.com", "Michael", null, "Brown", "345-678-9012", "Trauma Therapy", "6" },
                    { 4, "Works with children and adolescents", "therapist4@example.com", "Jennifer", null, "Davis", "456-789-0123", "Child Psychology", "7" },
                    { 5, "Substance abuse specialist", "therapist5@example.com", "Robert", null, "Miller", "567-890-1234", "Addiction Counseling", "8" },
                    { 6, "Helps with body image issues", "therapist6@example.com", "Lisa", null, "Wilson", "678-901-2345", "Eating Disorders", "9" },
                    { 7, "Relationship expert", "therapist7@example.com", "Thomas", null, "Moore", "789-012-3456", "Couples Therapy", "10" },
                    { 8, "Creative approaches to healing", "therapist8@example.com", "Nancy", null, "Taylor", "890-123-4567", "Art Therapy", "11" },
                    { 9, "Performance and mental health", "therapist9@example.com", "Kevin", null, "Anderson", "901-234-5678", "Sports Psychology", "12" },
                    { 10, "Helping with loss and bereavement", "therapist10@example.com", "Emma", null, "Thomas", "012-345-6789", "Grief Counseling", "13" }
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
                    { 1, new DateTime(2025, 6, 11, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 60, "Initial consultation", 1, "Scheduled", 1, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2025, 6, 12, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 45, "Follow-up session", 2, "Scheduled", 1, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2025, 6, 11, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 60, "Family therapy", 3, "Scheduled", 2, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2025, 6, 13, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 90, "Couples counseling", 4, "Canceled", 2, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2025, 6, 12, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 60, "Trauma session", 5, "Completed", 3, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, new DateTime(2025, 6, 14, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 60, "PTSD follow-up", 6, "Scheduled", 3, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, new DateTime(2025, 6, 11, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 45, "Child therapy evaluation", 7, "Scheduled", 4, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, new DateTime(2025, 6, 15, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 60, "Adolescent counseling", 1, "Scheduled", 4, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 90, "Addiction counseling", 2, "Scheduled", 5, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, new DateTime(2025, 6, 16, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 60, "Substance abuse follow-up", 3, "Rescheduled", 5, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 11, new DateTime(2025, 6, 12, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 60, "Eating disorder support", 4, "Scheduled", 6, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 12, new DateTime(2025, 6, 17, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 90, "Body image therapy", 5, "Rescheduled", 6, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 13, new DateTime(2025, 6, 14, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 60, "Couples therapy session", 6, "Scheduled", 7, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 14, new DateTime(2025, 6, 18, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 60, "Relationship counseling", 7, "Completed", 7, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 15, new DateTime(2025, 6, 13, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 60, "Art therapy introduction", 1, "Scheduled", 8, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 16, new DateTime(2025, 6, 19, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 90, "Creative expression session", 2, "Completed", 8, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 17, new DateTime(2025, 6, 15, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 60, "Sports performance anxiety", 3, "Scheduled", 9, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 18, new DateTime(2025, 6, 20, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 60, "Competition stress management", 4, "Completed", 9, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 19, new DateTime(2025, 6, 16, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 90, "Grief counseling", 5, "Scheduled", 10, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 20, new DateTime(2025, 6, 21, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 60, "Bereavement support", 6, "Rescheduled", 10, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "MoodEntries",
                columns: new[] { "Id", "Date", "MoodId", "Notes", "PatientId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, "Had a great day with friends", 1, "14" },
                    { 2, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 3, "Work stress is getting to me", 1, "14" },
                    { 3, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 6, "Feeling calm after meditation", 1, "14" },
                    { 4, new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, "Feeling down today", 2, "15" },
                    { 5, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 5, "Excited for upcoming trip", 2, "15" },
                    { 6, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 8, "Stressed about work deadline", 2, "15" },
                    { 7, new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 4, "Angry about argument with friend", 3, "16" },
                    { 8, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 7, "Exhausted from lack of sleep", 3, "16" },
                    { 9, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 9, "Content with how things are going", 3, "16" },
                    { 10, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 10, "Feeling lonely this weekend", 4, "17" },
                    { 11, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 12, "Hopeful about therapy progress", 4, "17" },
                    { 12, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 11, "Confused about my feelings", 4, "17" },
                    { 13, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, "Happy about good news", 5, "18" },
                    { 14, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 3, "Anxious about upcoming test", 5, "18" },
                    { 15, new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 5, "Excited to see family", 6, "19" },
                    { 16, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 6, "Calm after yoga session", 6, "19" },
                    { 17, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, "Sad about pet being sick", 6, "19" },
                    { 18, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 7, "Tired from work week", 7, "20" },
                    { 19, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 9, "Content with life right now", 7, "20" },
                    { 20, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 12, "Hopeful about new treatment", 7, "20" }
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
