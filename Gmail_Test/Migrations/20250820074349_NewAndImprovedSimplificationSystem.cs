using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class NewAndImprovedSimplificationSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoodEntries_MoodTypes_MoodId",
                table: "MoodEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_MoodEntries_Patients_PatientId",
                table: "MoodEntries");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "MoodTypes");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Therapists");

            migrationBuilder.DropIndex(
                name: "IX_MoodEntries_MoodId",
                table: "MoodEntries");

            migrationBuilder.DropIndex(
                name: "IX_MoodEntries_PatientId",
                table: "MoodEntries");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "10" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "12" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "13" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "MoodEntries",
                newName: "Mood");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e24503ba-f47f-4a96-9e92-80299dde27ce", "AQAAAAIAAYagAAAAEFG/6LOoWb98Winnjy3BVUKYvryEXbb5+B8zfQYN/1TicrdGI11bihctMUiOaHkAkw==", "69bac645-f4c5-4195-9b46-d89ff029d5e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd8b516d-4790-4d66-9aee-a2b3c19398dd", "AQAAAAIAAYagAAAAENjuHTc4hdxkqDwT3SMIgibxmcJpDlxbVOqbZlPeJi00YoJKrmfTslDEfu4CzNp2tQ==", "43602844-e7c5-4621-9360-b36bc27d7b2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c4d9af3-a778-4e2f-a1d4-2583095a82be", "AQAAAAIAAYagAAAAECBSFdpkGmhx16FsvmwcIklC4/628hT7rGnT8vvOiUADtz+AK55FtIYh8ggW1MHuGw==", "a5ad57e7-0784-478d-b85c-1d8624a3b528" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57b7abd6-5f86-4aa0-ae9e-bcd0e967d418", "AQAAAAIAAYagAAAAEKQ5zhd480gmSXz9xeKVuVn5iOG2BPrwotPNIt/vM9l9U7aX42i4s7cJxsse2JOz+A==", "3493e827-46dc-4fed-97cf-b6307e7f78ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a875fa66-93de-4c03-b8c3-f60de9e78a71", "AQAAAAIAAYagAAAAEE4BWHGdsCTpY3tAC+u6jLTWNvgxIidwSR2775CyI2kWbyTrUx/3xVURiWltTlGCrQ==", "eb535a87-acbf-4ed5-a44b-007798bd399b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d31716cf-58ec-42ae-918d-acc33a75d38b", "AQAAAAIAAYagAAAAEKDP7seHMNfIM5sLe/FqTzwa5Vgo/0y79HSiCIJTj6vBrT+Es9fG7ytYNnS5NkKfKg==", "565b6ab7-d91c-40b7-b741-e9ac47acef2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a35510c7-f342-4323-a8aa-8760fcd2e686", "AQAAAAIAAYagAAAAEGlV25IA1pkno7z9mpgZXYadpHtmyrlM4Spu5ZpewpV9GVocfmDgNz+8cthWXx6X/w==", "dd705dac-72a1-4082-a7b7-2392af8e0a66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b4cf2b8-c281-45f7-a4d7-05166633ed7b", "AQAAAAIAAYagAAAAEK0A5jq/59omDUDd394DCfNRKWILNANPQUVKNJDAp+4mRsekde/eQX6XF3nUPA6xig==", "a7888464-0188-4831-a603-dea327344e5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46b12849-e399-4295-a28e-5419440ab8b7", "AQAAAAIAAYagAAAAEKjwN/+IYD6ywxQMHzTs1bQGVhY51COYtKjJ9narExzzmhNBTS4WrN1IRt+tl5tO5A==", "a0f9ad0d-ed00-4fe2-bcff-648d29676e10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e54aeb0-ddc5-4574-a58d-8f4b7d09635b", "AQAAAAIAAYagAAAAEAlDjiOO5EEL57mTcKInoa95La0Wbd7FFoN9hIMirdVESZCON0MIcbnlZMgMkpZq5Q==", "16199e4c-f5a7-415b-9b6f-19ced6a569e7" });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 0, 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 0, 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 0, 3 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 0, 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 0, 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 0, 2 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 0, 1 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 0, 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 0, 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 0, 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 0, 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 0, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mood",
                table: "MoodEntries",
                newName: "PatientId");

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
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                name: "Therapists",
                columns: table => new
                {
                    TherapistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bio = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapists", x => x.TherapistId);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    TherapistId = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3", null, "Therapist", "THERAPIST" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d08b7e00-1ea2-49bf-8e4b-d5a887061a2c", "AQAAAAIAAYagAAAAEPmonzkPlfjydMSDHlktN9cPjOWDO/Mm6MSe2KOpjNUK/y4/+AlXW75RN5pbbXcm8Q==", "37d27963-5dc8-4a85-915d-a49fdcf06190" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74710891-53a1-4938-9406-845bbbcced82", "AQAAAAIAAYagAAAAEB5qtnFTkPSLICXcpeUaOJClTyMdvYvW7IKIoiFO3sszkgg/ZA8PJdVB8K8DbpePjA==", "d64dca66-0e18-4809-ba1b-0df245260706" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4e73bb3-8134-42c6-992b-c158b21f66cc", "AQAAAAIAAYagAAAAECVW0iygtcmP0BKCszR3buiGqY0ev0MGuTHt8lQIooHjbUnRbdz6yVPid6g/ktaYoQ==", "ee69b49c-7dcd-4f79-9499-906304090abf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0ac028b-15af-4bb6-ab23-4aee030552f6", "AQAAAAIAAYagAAAAEPyQLTimkPVtHAw3J0EjUV4JCTcm6Fml81/HX2edPJN7DexMxScVetHKn6zcL+Lt2w==", "7e45ca34-f6f8-4edd-831c-065e7afd0d09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d909ad0-287d-44fb-89f1-b8d7cd281a9f", "AQAAAAIAAYagAAAAEDX6ha+yMQgVcC37vuRlzw5RJrK98/JhxHIeA4tt1Uy+9adu8rmJ5bLbPF0K0wh0Mg==", "16e7ab99-ffc7-4ab7-8a60-4c00e0e29a88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "035e9e80-aaeb-4c37-b2ad-cff5faca0a24", "AQAAAAIAAYagAAAAEDehFNuPOKZGbXTijeT6BFp+Fm/3H7qTxGWJMQAFWJSfJ+E+q/8rqZpiSDU/ZAjpIw==", "e71f99ac-3a4d-4c29-b0d8-e28d1406fe58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5c1af1a-766a-4f97-af73-75d80131045b", "AQAAAAIAAYagAAAAEK7kXyc2PnsL5PJZ2sOqsWFG1Urv3s8xiGhMn0cww6C5VYty9gfmbtzqWd7ZBPEVfg==", "ef126781-4551-4c06-b8c2-43c64c905049" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f548b4c-b3e7-419c-b6f5-204d276f1500", "AQAAAAIAAYagAAAAELTXWkK8LgJYmw0aGy9zZROESfhzngQvuyD85/HzKcDQtB8XR1A6RyuqwFWD2Fe/GA==", "13844153-79d3-40d2-8496-2d8c871a4bce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff1158df-d01c-4aa4-a30f-3ff15e5adfb6", "AQAAAAIAAYagAAAAELNWXTV+YlIAqYYGoXfSIQ6ZKixFBlWiWjxkJ8bX0etzbUC8+OUzegmsbZRmXDONHw==", "6ed4a95a-b564-4de7-9d55-5677b6feb700" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b01dcc9-e992-401b-b263-bef1a6b8791e", "AQAAAAIAAYagAAAAEB24XePD5wZAdXYaANjQYenaD6R+V8uBLK6jd9bYotm6oK2yH+/NNvXK56riSzK+1w==", "ddd6a1c5-43b9-4929-8436-dc071dc3651b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastMoodCheckIn", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PfpName", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10", 0, "51eeb074-9518-466b-869f-3d169f0cc649", "therapist7@example.com", true, "Thomas", null, "Moore", false, null, "THERAPIST7@EXAMPLE.COM", "THERAPIST7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKrNCAvX1PWy8zP7o8NHEoi4famcoKEj8lfEVD8L4e37P0DLyVcrnoIjZoQZMUH9DA==", null, null, false, "611ad3c8-a9d7-4f26-a50f-d114ba82a3a2", false, "therapist7@example.com" },
                    { "11", 0, "3b80c097-edf2-4123-8c8f-93033f70640d", "therapist8@example.com", true, "Nancy", null, "Taylor", false, null, "THERAPIST8@EXAMPLE.COM", "THERAPIST8@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOSERlyDUrSw0p3mZ/+IfjQxq1MiZU0uUo32on38PspOzhjor/PrQnedU4kSIZrqxw==", null, null, false, "57ccdf53-d154-4612-b6eb-3bcab1c7f15e", false, "therapist8@example.com" },
                    { "12", 0, "ca5abf8c-2794-4ca0-92d1-5c1e01ff8846", "therapist9@example.com", true, "Kevin", null, "Anderson", false, null, "THERAPIST9@EXAMPLE.COM", "THERAPIST9@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKJkmQYk93+Rc+19rZYBPBmfiwilUYDsHj9mZDMLVuNWNMxmMVNVaDAPM489oLzwtw==", null, null, false, "b438e2d6-b448-4898-a0cd-d9c7befc455a", false, "therapist9@example.com" },
                    { "13", 0, "ffe3c3c8-1b81-4ee0-a439-55fe587877a8", "therapist10@example.com", true, "Emma", null, "Thomas", false, null, "THERAPIST10@EXAMPLE.COM", "THERAPIST10@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPCUci6J+bVyq5KyUdhpnt3WB5lShniRy2+2JORDzX3p6NBcEF62I4y1bWnF2MLPoA==", null, null, false, "56b0eadb-2c9f-44f2-a2ab-f53abb7ab2ab", false, "therapist10@example.com" },
                    { "4", 0, "5ceb7d14-fa7c-4632-8eba-ed79f74a8dc7", "therapist1@example.com", true, "John", null, "Doe", false, null, "THERAPIST1@EXAMPLE.COM", "THERAPIST1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI/X25nWazicbmkfEIEc+Umq8o4qmaSi0CflL2JNrCkYTHP1uD3WcOdp/PL4xihJqw==", null, null, false, "0bbf5f7e-0c65-4d4d-bdc2-f33eb5afce79", false, "therapist1@example.com" },
                    { "5", 0, "0d95578f-875b-43df-9a04-0cabdeb90ebf", "therapist2@example.com", true, "Sarah", null, "Johnson", false, null, "THERAPIST2@EXAMPLE.COM", "THERAPIST2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHdvFJeKSzCES/n3haPXycajU/GuoVJRAQUE3+iI3K4vGdbL/2cVfe/jc69P8oZv/g==", null, null, false, "406381a1-0121-4c7b-b6e2-2017c61b776d", false, "therapist2@example.com" },
                    { "6", 0, "863abfb6-913b-4da2-9c5c-31c6a9c928e4", "therapist3@example.com", true, "Michael", null, "Brown", false, null, "THERAPIST3@EXAMPLE.COM", "THERAPIST3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPAmy78ZOUgdca/wf/cjjk3Eef+3PGikOg8RhNGtJ/BNLvCCejVc3R1lr++ghhxRWw==", null, null, false, "aabfd901-3909-49fb-ba52-ad14008d5f98", false, "therapist3@example.com" },
                    { "7", 0, "35a29d9a-c376-4488-b314-11e041084167", "therapist4@example.com", true, "Jennifer", null, "Davis", false, null, "THERAPIST4@EXAMPLE.COM", "THERAPIST4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK9w9tYVTXhz6pmPRHDAJpcGixgKmZcGkHmTe5Teicx0TKTUxEtHLmAETSgghNwWKg==", null, null, false, "bb5ad3f3-60cb-4f17-a297-f4b9130d38ad", false, "therapist4@example.com" },
                    { "8", 0, "e54cbd52-6f58-4bd0-9399-7845847d728b", "therapist5@example.com", true, "Robert", null, "Miller", false, null, "THERAPIST5@EXAMPLE.COM", "THERAPIST5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPDh67vMeRkP0GjbTBiuDeoKiAwftlmFKIsKTpAQn9Vx4g2es5kC7EEKDEfS5nDynw==", null, null, false, "ea9ebc61-3b21-437c-9024-1bf05068497a", false, "therapist5@example.com" },
                    { "9", 0, "9d08767d-f9d0-4011-9f0a-c268d9d42e82", "therapist6@example.com", true, "Lisa", null, "Wilson", false, null, "THERAPIST6@EXAMPLE.COM", "THERAPIST6@EXAMPLE.COM", "AQAAAAIAAYagAAAAECV+LQg3SVuH4kZCngfHxLOyRkIMIaRNaI0jt4aBMzs+91G6ojim25fQIwhB1coO6A==", null, null, false, "00eb59b8-6727-4180-87c0-b5454feb0f6e", false, "therapist6@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "MoodId", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), 3, 1 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 2 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 2 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "MoodId", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 8, 2 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "MoodId", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 4, 3 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "MoodId", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 7, 3 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "MoodId", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 9, 3 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "MoodId", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 10, 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "MoodId", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), 12, 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "MoodId", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 11, 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 5 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "MoodId", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 3, 5 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "MoodId", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 7, 7 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "MoodId", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 9, 7 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "MoodId", "PatientId" },
                values: new object[] { new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 12, 7 });

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
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "CreatedAt", "DurationMinutes", "Notes", "PatientId", "Status", "TherapistId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 27, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 60, "Initial consultation", 1, "Scheduled", 1, new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2025, 7, 28, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 45, "Follow-up session", 2, "Scheduled", 1, new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2025, 7, 27, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 60, "Family therapy", 3, "Scheduled", 2, new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2025, 7, 29, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), 90, "Couples counseling", 4, "Canceled", 2, new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2025, 7, 28, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 60, "Trauma session", 5, "Completed", 3, new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, new DateTime(2025, 7, 30, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 60, "PTSD follow-up", 6, "Scheduled", 3, new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, new DateTime(2025, 7, 27, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 45, "Child therapy evaluation", 7, "Scheduled", 4, new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, new DateTime(2025, 7, 31, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 60, "Adolescent counseling", 1, "Scheduled", 4, new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, new DateTime(2025, 7, 29, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 90, "Addiction counseling", 2, "Scheduled", 5, new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, new DateTime(2025, 8, 1, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 60, "Substance abuse follow-up", 3, "Rescheduled", 5, new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 11, new DateTime(2025, 7, 28, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), 60, "Eating disorder support", 4, "Scheduled", 6, new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 12, new DateTime(2025, 8, 2, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 90, "Body image therapy", 5, "Rescheduled", 6, new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 13, new DateTime(2025, 7, 30, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 60, "Couples therapy session", 6, "Scheduled", 7, new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 14, new DateTime(2025, 8, 3, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 60, "Relationship counseling", 7, "Completed", 7, new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 15, new DateTime(2025, 7, 29, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 60, "Art therapy introduction", 1, "Scheduled", 8, new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 16, new DateTime(2025, 8, 4, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 90, "Creative expression session", 2, "Completed", 8, new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 17, new DateTime(2025, 7, 31, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), 60, "Sports performance anxiety", 3, "Scheduled", 9, new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 18, new DateTime(2025, 8, 5, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 60, "Competition stress management", 4, "Completed", 9, new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 19, new DateTime(2025, 8, 1, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 90, "Grief counseling", 5, "Scheduled", 10, new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 20, new DateTime(2025, 8, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 60, "Bereavement support", 6, "Rescheduled", 10, new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "10" },
                    { "3", "11" },
                    { "3", "12" },
                    { "3", "13" },
                    { "3", "4" },
                    { "3", "5" },
                    { "3", "6" },
                    { "3", "7" },
                    { "3", "8" },
                    { "3", "9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoodEntries_MoodId",
                table: "MoodEntries",
                column: "MoodId");

            migrationBuilder.CreateIndex(
                name: "IX_MoodEntries_PatientId",
                table: "MoodEntries",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_TherapistId",
                table: "Appointments",
                column: "TherapistId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserId",
                table: "Patients",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MoodEntries_MoodTypes_MoodId",
                table: "MoodEntries",
                column: "MoodId",
                principalTable: "MoodTypes",
                principalColumn: "MoodTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoodEntries_Patients_PatientId",
                table: "MoodEntries",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
