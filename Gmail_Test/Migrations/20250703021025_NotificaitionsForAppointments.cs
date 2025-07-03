using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class NotificaitionsForAppointments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 5, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 6, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 5, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 7, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 8, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 9, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 10, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 7, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 11, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 6, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 12, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 8, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 13, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 9, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3c82b65-daec-4cfa-a377-247a3cfa91af", "AQAAAAIAAYagAAAAEF9SNNOGs2jZCGkIKARPad1ANAtq9Z+7Aqcxms8wR4HWkbyVawx643xKNCE+L0ovfA==", "a101678d-b801-4177-bbfe-a23cfa1ac008" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5413dd08-099c-4b68-a177-9e05d0fef7d6", "AQAAAAIAAYagAAAAEJSbx96ihCDfBhwBxhleSBA/xIYDYY5KGWK7syT+ZNVPoBZhpKOQifGc5ldItSYX/Q==", "f400681e-4799-4147-90f2-daa6b96e2bb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45330eff-18f2-4c8e-9831-c65eddc2ebc8", "AQAAAAIAAYagAAAAECUkyRC5nEetCfW3c/oZsc0anqrn3vabwC63l2fhkLFZbDdVI/AFi7sChKXH4iXY+A==", "8c65397b-c9a9-49ac-9104-dd1532f2d551" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88a4867f-dd69-4f2e-b771-853f9dea06fd", "AQAAAAIAAYagAAAAECpo5W9L1123rCgqgcSL92ut86Awki0+AAx8Tq0IJt/AeVQf3Dje0vdZlUx/C4FNyQ==", "8e4d5fdf-650a-4f52-b11b-46d1a2721ab9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8056c01c-1077-427b-b251-d82d0156163d", "AQAAAAIAAYagAAAAEEYg9QOEwVIeYGmVEZirt79zDd0Qx0XxDr484DYxwoADsyiB0XtLD3rPRFDAoP2MSw==", "ea7883aa-4727-4b3b-8e20-91083191d2f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec9c161c-4d9b-47c5-9ef9-1142e214a6c9", "AQAAAAIAAYagAAAAEK0QZW99mLnZib3NSvQFj0VGcluIIb1VY0NPLJdsVQzkfjBzZISTnSDxHz57NWOH6Q==", "58b658e2-72b3-4360-b2e5-de67a277848e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72298421-1acf-4fdb-94ac-6be414ace85a", "AQAAAAIAAYagAAAAEL6PjRkCi//lW2Tr0O2guwf6em0yYjeySuetkd3mVkIRrct+5RZ+Sg+Now4bqwbtCw==", "fc9356cb-1763-4c72-95ac-37bc4a6fbdf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db5d8bdb-6dd0-424e-aee2-e94329c1e540", "AQAAAAIAAYagAAAAEM3fvYgCmbwDKmfVbmgYI/0ok7pPPTWzFQjKxqBh+wTtQWvUYaEeS0XegyxdpVxWaA==", "fe5c7934-c260-4c08-a847-d9c1d8449964" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc2b4f41-aef9-4314-9ea8-6aa5da6b7abe", "AQAAAAIAAYagAAAAEGphyBj93aYky8WTLo0tOy9xoCKqO/rVha74kDdBWCPPEexkfPiQkpddFXIut1Rh8A==", "15d452d4-49b3-4123-a2dc-1d29f8890858" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76d34cd2-ff63-486d-9ae2-dfb034b066cd", "AQAAAAIAAYagAAAAECzYJFwnaBim1YFtuGMKHZkNyqleVUFup/iUxgu8++hFJ507jLYqutyILuWofG6Z7w==", "a42f0358-7fef-4c2c-8d2c-59be61dd6569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de2c4fe8-d1a6-48c0-9569-c58a2533df94", "AQAAAAIAAYagAAAAEAvG39LUycJIzn5H4/RcrySlZMLgup+Zim3KYvfdDmBm7ThEQhjmPYQ5++GW3EH0NQ==", "a7afd669-0c95-4d86-ab7f-328d725cfe39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b06a55c-b61e-49d0-ab84-006dde3b554f", "AQAAAAIAAYagAAAAENkliTwdXqFLT8+prc+Y7qtIp3Xe5VID3wXyd3mScPIPGaBbFbcwc2opsOkI6cF5KQ==", "29d396bd-9724-4f6d-9fbf-c48b6dd5a7e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "901e59a1-c547-4d73-8ba7-883140ab36b4", "AQAAAAIAAYagAAAAEJTgGDhNLy7ULIz0HAlC0HVjfWCj7dvWdaBrdHloXMQovFHOesDDKBeWBL2E0TWaxQ==", "512dc1b0-b94a-4b95-9310-cea90b4b3ef7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc25247c-75c6-4db1-9251-aafe5b1773aa", "AQAAAAIAAYagAAAAELyvErKO2zJKYPpWKAMoVA4hxtIqa9O68W7JTi3TDtLSqCa/2TI1gyIim1ezFRyHEg==", "142b4aec-6cd8-40c8-9718-761a8fa4cafc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4645fe35-14d8-4403-a049-b5e3a610a505", "AQAAAAIAAYagAAAAEDVswqtb/H+IBY7Aos6rQ/ipiuk2HBtFHUqnTW0IW45RFG7U3mf6cjjUZnZdFuWvWg==", "f05d8850-12da-40aa-b710-0cf47397d4a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc62c7d7-a6c3-4c71-baaf-4193a203a78c", "AQAAAAIAAYagAAAAEMBR1vBBMrzt1sDfh5stiTt8vsrDvQLlPGeL2YZVBTfg1gyYYcwyAVvo4WwDdJ3FvA==", "379641fc-764a-411d-a589-78a8ca0bda88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76b4fe32-27ce-451e-849b-68f3598f8126", "AQAAAAIAAYagAAAAEAHrE8pERidKkjJvhmYhcFZgqe81p9mEIK6b90byLyqYe/gQX3qaTmaT89g+r6gutA==", "6c02c77d-c6ff-49fc-99c3-4a7c065e641f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae94bf31-2918-4263-8dc9-7205eee4492c", "AQAAAAIAAYagAAAAENTKdfucXwrHpFScN9/ZEBdtB4vRDKo6/zKhnYhKqCjCYxRSfpIH+Tukxrn05jAsCQ==", "287d9384-5d52-4446-96b3-363255bdc347" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e03df6b4-2462-489e-9a4c-ae205b8d1d7b", "AQAAAAIAAYagAAAAEAmaCIW1iRkHwVxPJPIyU6kuCL3x9/rnTkVRVx28aXqEOTzU7N0b+mYgZVd4jELA/g==", "251f7cf2-1a20-49c4-bf34-cd436de29ee8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68888efc-1ed0-4c63-a2e9-667bc2b559fb", "AQAAAAIAAYagAAAAENoEmPf3JXfBR7BNTh1iSpAOh+9PvOIGSCAKO2MDdM8hhA4mlsYlp6dkOUUj2EiwiA==", "0c94401c-2d61-42b0-8fc9-9ad2cbd41a5c" });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 3, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 6, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 3, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 7, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 5, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 8, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 9, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 6, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 10, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 5, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 11, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 7, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 12, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 8, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed113574-ba50-4908-ad5c-600e2d8aa45e", "AQAAAAIAAYagAAAAEK1891LtFxPCIK8RU40sU2qk6TzCkwCAq952Q+P/+qfCNWwe7YjM36C3I4J5dhtCuw==", "948302b3-8b9f-4926-a64c-026f1c9fcba9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2211870b-b41f-4a3e-a6fc-0655d3f6a875", "AQAAAAIAAYagAAAAEAk+iJZLImZrCgpAnq6t0ZrRchi5zua0RPihLl6i6u/Pc1pt69frozArlCbQ/yyNCg==", "077ef2ad-2a04-44f4-9d19-d409a7d454ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e5e06e7-e22c-46b8-a90b-b93bfebea6b8", "AQAAAAIAAYagAAAAEHsGdgjrhM3YLw5/wKdR0n5qvUZh50Ut3TFgZoaFsyN4f4YF2L46bjXW6Fg8z55x/Q==", "40eb2533-2948-4c42-aee6-dd14129fe0ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c857bde-6027-4fc9-8864-0292f065be18", "AQAAAAIAAYagAAAAEEy6iqOTj+SIFXXlrU6SLtNFQTcio8HIbcPCXzbXw/oBFQTCTYpCC804RvMZIPBwtA==", "df5a72e8-356d-4f84-b5af-474478104bfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d5a5760-a215-44d1-baa2-af7b0cee9444", "AQAAAAIAAYagAAAAEB2qzDQ8F2UWULGiX/RfVM/yzzgv7+IUhSQ7XupbrL50oKUaLNls6HplDXaAALEreQ==", "7ff0024a-633f-4228-8168-832121960da9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3868596c-8d25-427e-b7ac-ea1cc8b5047a", "AQAAAAIAAYagAAAAEPBAo2q8ul1Fcehrx2iURpWJ7HoLQ3Q9fz2vLlIGCRWTInPH25kDkQA9XvQR6UwnSw==", "f7f49a4d-38d6-41e1-8947-29a8822fc887" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87bf5282-53a6-451a-b1c9-0f8f072d3edd", "AQAAAAIAAYagAAAAEBFLC74iUsLVdTOz9QTvu3KvMyNpV5tfjFMejo7h9YIs/nKHp5nnEEsuz5HK9HLmWQ==", "6563d2f5-5868-4294-a7b1-96ead94794a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfc809d7-af9d-43f1-a043-d9e70f90ae86", "AQAAAAIAAYagAAAAEFxnbJJ+KrdSFKPU2KGHtifbBq0PnrK80eEcqkl60bms7UgMhqK4wk0s4bJ9Tmk6vg==", "1fdf4529-823f-48df-8838-0321933fd0d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "929243bf-1faf-4225-9db4-b98546b24a31", "AQAAAAIAAYagAAAAECEeoAqHNUOgvT6+wzZsKYLb4fthlebaBtTZ8t4+5lZCsjKIVq2WD8vycDK4GZIgqA==", "57b0b09c-9f70-4c19-88cd-cd95cde42b63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e0e2d62-b89d-4c5b-918e-b87099e1b80a", "AQAAAAIAAYagAAAAEI2bC/D2A3JKQTiybTz3A7C7UAH+rq6FYeQBPtGOZNLTke/C1NaiP0vjncspeGbbPA==", "64cff72d-c661-4bbd-9ded-5c63c5384b50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9fed78c-22cc-4147-ad29-5be69e7ff67c", "AQAAAAIAAYagAAAAEEpf+RxXskOHs0xSlRk5Jm1swhgrjt637DcwnILkGChBNffWuOGw+Pmb/A24TiwLig==", "badc2183-a83a-4e27-8576-d6b64777630f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14535529-7b01-4d98-9fd3-62bef8a4db2e", "AQAAAAIAAYagAAAAEGayb2jg+4pRL/T4SSsj/3nFWEi014rhUolR8HhZxTPK5YPE3lK9ev2bNY5+gUpxZw==", "dd24d935-a8ee-45db-9f89-11f12a4bcc43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82d4e55b-c635-48c2-b0c2-b2e3d46edc7d", "AQAAAAIAAYagAAAAEObasXkoioRW0df0uozrKKBaJMzLicdNTsMFtha8077lDKI0h5unxzD6X4qf/M7NeQ==", "cd281b67-1a89-4b49-852d-37816261b545" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4398e67c-cbfb-4613-bc4d-95263d9154d4", "AQAAAAIAAYagAAAAEELyWnpq0dU7O3dZJ8y30p7tpoY/ZfpXOKxb/rGSQCIXvyrUqls/2nFxbVFFW9k6rA==", "4f042a19-18aa-4661-bafe-4f2a8937a197" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31b36587-2f3f-4e40-832c-9b754d7396ea", "AQAAAAIAAYagAAAAEKOKSzHGGagERMp6t4B2dspndBJfjZtHaA5Gs+oBGrzxF0uG2YPoCCWaaeLOYpoN/Q==", "dcd19979-b1d8-4988-bced-e5510cf755da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14398f8a-1880-48de-86ed-66b866097791", "AQAAAAIAAYagAAAAEJO8rxBIdif254VL/O1jyp1gEi6O399be2J1O2+dNX7nfMRkM0RrN59cI6XTxM2ijQ==", "67ca9785-f277-4961-be7a-a9d7368400f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72afc529-604e-4e2b-9c00-0c8d59b09f02", "AQAAAAIAAYagAAAAEAWKcKyoYbmL0E1Ljfuf0Hn/4304NydqS3e69147V+Qzb272zEN5akhTJFVajkZ6cw==", "290bc8e2-4586-4820-a112-d4e24d0e9524" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19baf65a-1d97-4a76-885d-51e895e4d3ad", "AQAAAAIAAYagAAAAEGGXg1P9aMzpHNnZL5F6x1JbjOn/De8B+AMXZLAbUSLgHuxZy/TzV2Fb69smAwBzoQ==", "0a419ca0-80c2-4014-a9a8-d8f6795f3156" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cb8d3cb-28b3-45f5-a7cc-9a2e3954af7e", "AQAAAAIAAYagAAAAEK1rmZyHXc2L3QHR3dxsl3t36LNVo5eYOUrNh0PuACd09scr4pC/9Uabl+uNb1+AEQ==", "ca8e5645-51f2-45b7-b82a-4ea88600fdb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "277a700a-f8f3-4a13-99e3-a9e53b391559", "AQAAAAIAAYagAAAAEKMB0922HR2OPXmcOleb4D8L6fVhVyLl2RnsUBqr6tJQMqZR7aaIIbYxJsmxb4HJ8Q==", "644fe8dc-041b-4337-9b41-26776365a054" });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
