using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class AddNewData : Migration
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "1e5719ca-6f76-4720-a1c7-143d8f5c6d56", null, "admin@example.com", true, "System", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP4C6uGoBOkWc41dUT3nn80SPbKm/GBX00CR0J0JZin6xDlYauZqSdEVFUs5W/g7hQ==", null, false, "e7b45051-3fd7-4586-8856-f3b45fdb5bf1", false, "admin@example.com" },
                    { "10", 0, "60d437a3-1e8e-45ec-9ee4-51cc6ba2d7d8", null, "therapist7@example.com", true, "Thomas", "Moore", false, null, "THERAPIST7@EXAMPLE.COM", "THERAPIST7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJmVazYXmeqkjxd9Jil43qff0nXBXrANE66E6fTBNbJDzSGN2WerfXBz19LMRHd7jQ==", null, false, "87fd5109-2cc0-4327-970c-319b9d59da5c", false, "therapist7@example.com" },
                    { "11", 0, "53196660-1b59-46bd-bec4-2a46bfdefd1f", null, "therapist8@example.com", true, "Nancy", "Taylor", false, null, "THERAPIST8@EXAMPLE.COM", "THERAPIST8@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEuvZQHb+T4NRU1PQpSz4n5hwyrBfrMQozO4QBCfRzO6wgaZ8ipxWQh/zzD0nEP5Tg==", null, false, "be298827-398b-4585-a3c4-910734e2ec65", false, "therapist8@example.com" },
                    { "12", 0, "e685f157-1f02-47e9-a632-65d5ec0dd535", null, "therapist9@example.com", true, "Kevin", "Anderson", false, null, "THERAPIST9@EXAMPLE.COM", "THERAPIST9@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMa60Is/BicXBB2oREkRtkMmszK1y7fpxnoGcwFcPZtK8bz4INiKWR3SBL4mINOUKA==", null, false, "fa340277-53f9-4d95-baf4-51516cde6203", false, "therapist9@example.com" },
                    { "13", 0, "cba7358f-fde2-44d2-9fcf-566a25cac348", null, "therapist10@example.com", true, "Emma", "Thomas", false, null, "THERAPIST10@EXAMPLE.COM", "THERAPIST10@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPBJSfD6sJkvn1ng6q/YzF7n0ZrARdXS0lac+XYSFN24btmTqCPQfkBmbU2NecanBw==", null, false, "d15b42c9-86d1-4c7a-b127-683412925545", false, "therapist10@example.com" },
                    { "14", 0, "189940e0-c344-499e-8548-0bc3fc65616d", null, "patient1@example.com", true, "Alice", "Smith", false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEANxsFcNuSrpnkwGWOKzrjbZ25oDfDDl2Y0WIkiMoAXvLMonLoBXU6jQ2wzDoA3kSQ==", null, false, "95335ac7-6ebc-4b01-93d8-80fe37f4643e", false, "patient1@example.com" },
                    { "15", 0, "65ceead3-99d0-49c5-8627-df554839a6bb", null, "patient2@example.com", true, "Mike", "Johnson", false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGNi3MovsI1pyIDUfaOenCc+AGCYFxSpRSGvYsjot+foFuOEFLRgIGGNOWN0ZCEdKQ==", null, false, "a98daa73-78f8-4a69-8473-a79efcc8c5cc", false, "patient2@example.com" },
                    { "16", 0, "cdd36fc2-efe7-4706-afd0-4f43f7ec4dd1", null, "patient3@example.com", true, "Emily", "Williams", false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKa6r7lz4h7gxroS8rE0cOoav/xtbYPZyfPDH7EAtIvfO4GV/NuxSED7Pp600WkaEg==", null, false, "0c6a3f97-0db6-4214-a36c-4f2a6813d21e", false, "patient3@example.com" },
                    { "17", 0, "eade8162-cae3-4d20-a259-875b070cd121", null, "patient4@example.com", true, "David", "Lee", false, null, "PATIENT4@EXAMPLE.COM", "PATIENT4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOjgCinpxHJoDrtu9AYrJ7EoPyCtibp5OYw4SXuUDSmncASa5CNaXdSw5eGKkaxn7A==", null, false, "38948475-f8e2-45c4-aacc-492a784ac789", false, "patient4@example.com" },
                    { "18", 0, "90412526-1342-4453-872e-8bc1b8fa5043", null, "patient5@example.com", true, "Sophia", "Garcia", false, null, "PATIENT5@EXAMPLE.COM", "PATIENT5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE7FXHEa9rVKoiexo1uXSE0/x2yaSfBUGXTwmtDsZ3UlcPJx3Il3UBZmT+uid0HLwg==", null, false, "b3c4fd81-e001-482d-a664-fe4b2a26f92d", false, "patient5@example.com" },
                    { "19", 0, "82998f1e-68fc-4aee-895b-cb979a830774", null, "patient6@example.com", true, "James", "Wilson", false, null, "PATIENT6@EXAMPLE.COM", "PATIENT6@EXAMPLE.COM", "AQAAAAIAAYagAAAAED288QGz6lXXTJpsK9+k7jHUQU1U0JUqSG+pB61pyMYIRnHOBMla3LS7O3zk5T/PSg==", null, false, "e991eefd-8ee6-4aa5-93b0-9f8fe85d1c90", false, "patient6@example.com" },
                    { "2", 0, "f8751e0e-5ff2-4337-bbe5-3c55f8358ff0", null, "admin2@example.com", true, "Second", "Admin", false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDDgQbtn2ZGnXHJqnmfDdmD302O2y8Qo7XzECEGNf8ZC3FC5EnBvyHAPjz3sTCpVng==", null, false, "319d6081-083d-42d9-b53c-0caeb80239d2", false, "admin2@example.com" },
                    { "20", 0, "a3f76e1d-e3ee-4806-b69a-9e01cbc3732e", null, "patient7@example.com", true, "Olivia", "Martinez", false, null, "PATIENT7@EXAMPLE.COM", "PATIENT7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO2cYCoicEEeyI7eEa/WdOmUe087MWPiohyjB2zvpPY2bmwnXQ1xpAyUEOjhzJBhiQ==", null, false, "4cf4ab2f-b952-4031-a351-86cc2c41179c", false, "patient7@example.com" },
                    { "3", 0, "a7031f7d-c615-4447-b859-4c5eb679eb21", null, "admin3@example.com", true, "Third", "Admin", false, null, "ADMIN3@EXAMPLE.COM", "ADMIN3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAIV+opWINubiIJpWDunPYI1Kw6WT3lamYkxnF//SCZuXMnSnKEO/wGw4Sd1wmMoAQ==", null, false, "60f0dcf4-e7b0-480e-b224-9e6e414af5a7", false, "admin3@example.com" },
                    { "4", 0, "a3176414-86ea-4b99-b6bf-b39a9c5bbec5", null, "therapist1@example.com", true, "John", "Doe", false, null, "THERAPIST1@EXAMPLE.COM", "THERAPIST1@EXAMPLE.COM", "AQAAAAIAAYagAAAAECe8OxoMYQUHfXbXjFZSzU+tVS9yu7wP8mNUPoIW9oVThyuh7jaih9/6rOWsfAIopQ==", null, false, "d85d7f31-3723-4b1b-86e3-8b0ccdba4b94", false, "therapist1@example.com" },
                    { "5", 0, "f46edfd0-4278-49e1-8dce-125932edb130", null, "therapist2@example.com", true, "Sarah", "Johnson", false, null, "THERAPIST2@EXAMPLE.COM", "THERAPIST2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAldvBrgWjwaxYJ+tn7kOGkE1YqGyo3QSb905M2GGALlXK/Ptddz1PxTnSB2PJIUnA==", null, false, "c79701b3-0d95-433e-92fc-02f687b55ec5", false, "therapist2@example.com" },
                    { "6", 0, "4e5801ce-e442-4e17-a773-ad7d51d911c6", null, "therapist3@example.com", true, "Michael", "Brown", false, null, "THERAPIST3@EXAMPLE.COM", "THERAPIST3@EXAMPLE.COM", "AQAAAAIAAYagAAAAECouu/ko/7Kew+ZSXjRHl4Cs6PGvB7yToTIwFRw4Ef7zOlsDRXaZ/3JX9rKceA66Nw==", null, false, "9aad5c88-d761-4f72-a8f9-6cbe5eb282b0", false, "therapist3@example.com" },
                    { "7", 0, "f9578c4c-024a-42e7-b2a0-ca69257bb06d", null, "therapist4@example.com", true, "Jennifer", "Davis", false, null, "THERAPIST4@EXAMPLE.COM", "THERAPIST4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL750AgUQrbuuHimc39hy8Xatrc0f9jafH7uUDYOv96TZ4CwYLsybcGVZXhNxLRzOQ==", null, false, "766f604a-49e7-427d-b9a5-cabac23f0830", false, "therapist4@example.com" },
                    { "8", 0, "addece5d-bb52-496a-bc35-7a7f0ab0e8b0", null, "therapist5@example.com", true, "Robert", "Miller", false, null, "THERAPIST5@EXAMPLE.COM", "THERAPIST5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO7b59yEkbxOYe8fBNnjhWGBhhoBaB07+c1HqcyB+cc66hDbXtoF67QVnEgi1VbVPw==", null, false, "c5839ebb-cd42-44fa-888b-682d96412a77", false, "therapist5@example.com" },
                    { "9", 0, "fd4e4b2e-ff68-4577-843e-e9569b976d81", null, "therapist6@example.com", true, "Lisa", "Wilson", false, null, "THERAPIST6@EXAMPLE.COM", "THERAPIST6@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOKutn2hJMNtNyc+ehEp8KEEQYUSASYAPCQkcTiqzbGXDRFYqOcVfU58uoYoTYKpDA==", null, false, "7b79dc44-e1d6-4063-9cdc-afcce3dea243", false, "therapist6@example.com" }
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
                    { 1, new DateTime(2025, 4, 4, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), 60, "Initial consultation", 1, "Scheduled", 1, new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2025, 4, 5, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 45, "Follow-up session", 2, "Scheduled", 1, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2025, 4, 4, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 60, "Family therapy", 3, "Scheduled", 2, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2025, 4, 6, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 90, "Couples counseling", 4, "Canceled", 2, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2025, 4, 5, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 60, "Trauma session", 5, "Completed", 3, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, new DateTime(2025, 4, 7, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 60, "PTSD follow-up", 6, "Scheduled", 3, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, new DateTime(2025, 4, 4, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 45, "Child therapy evaluation", 7, "Scheduled", 4, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, new DateTime(2025, 4, 8, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 60, "Adolescent counseling", 1, "Scheduled", 4, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, new DateTime(2025, 4, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 90, "Addiction counseling", 2, "Scheduled", 5, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, new DateTime(2025, 4, 9, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), 60, "Substance abuse follow-up", 3, "Rescheduled", 5, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 11, new DateTime(2025, 4, 5, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 60, "Eating disorder support", 4, "Scheduled", 6, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 12, new DateTime(2025, 4, 10, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 90, "Body image therapy", 5, "Rescheduled", 6, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 13, new DateTime(2025, 4, 7, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 60, "Couples therapy session", 6, "Scheduled", 7, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 14, new DateTime(2025, 4, 11, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), 60, "Relationship counseling", 7, "Completed", 7, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 15, new DateTime(2025, 4, 6, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 60, "Art therapy introduction", 1, "Scheduled", 8, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 16, new DateTime(2025, 4, 12, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 90, "Creative expression session", 2, "Completed", 8, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 17, new DateTime(2025, 4, 8, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 60, "Sports performance anxiety", 3, "Scheduled", 9, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 18, new DateTime(2025, 4, 13, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 60, "Competition stress management", 4, "Completed", 9, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 19, new DateTime(2025, 4, 9, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 90, "Grief counseling", 5, "Scheduled", 10, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 20, new DateTime(2025, 4, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 60, "Bereavement support", 6, "Rescheduled", 10, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "MoodEntries",
                columns: new[] { "Id", "Date", "MoodId", "Notes", "PatientId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 1, "Had a great day with friends", 1, "14" },
                    { 2, new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 3, "Work stress is getting to me", 1, "14" },
                    { 3, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, "Feeling calm after meditation", 1, "14" },
                    { 4, new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 2, "Feeling down today", 2, "15" },
                    { 5, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 5, "Excited for upcoming trip", 2, "15" },
                    { 6, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), 8, "Stressed about work deadline", 2, "15" },
                    { 7, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), 4, "Angry about argument with friend", 3, "16" },
                    { 8, new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 7, "Exhausted from lack of sleep", 3, "16" },
                    { 9, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 9, "Content with how things are going", 3, "16" },
                    { 10, new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 10, "Feeling lonely this weekend", 4, "17" },
                    { 11, new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 12, "Hopeful about therapy progress", 4, "17" },
                    { 12, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), 11, "Confused about my feelings", 4, "17" },
                    { 13, new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, "Happy about good news", 5, "18" },
                    { 14, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 3, "Anxious about upcoming test", 5, "18" },
                    { 15, new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 5, "Excited to see family", 6, "19" },
                    { 16, new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 6, "Calm after yoga session", 6, "19" },
                    { 17, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), 2, "Sad about pet being sick", 6, "19" },
                    { 18, new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 7, "Tired from work week", 7, "20" },
                    { 19, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 9, "Content with life right now", 7, "20" },
                    { 20, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), 12, "Hopeful about new treatment", 7, "20" }
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
