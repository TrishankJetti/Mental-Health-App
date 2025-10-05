using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "MoodEntries",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffe0e36f-8730-4c13-a116-93792ac922f8", "AQAAAAIAAYagAAAAECqGRk3WeqPIolPRchAsoVMXk37XQCCb3k7JfIh7vKCUXW3q04GsiImrVHzH7qiPDg==", "e80e84a3-54eb-4307-897d-16dcaa74ff5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cfd2768-3297-48af-a4a3-a1d47578698d", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEK2dvVnFwY1c7XZgHG7g0oAppKnIRnn7z+qzmtGfM/ggxa0X+QcBjLgEmxxfjdJqiQ==", "e6abc78d-8a45-4e72-a6a3-27c2506c9601" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c16c07a0-fac8-4a80-b5db-f467b6829a1c", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEFRrQd5Z+82GrvtNL2wdSDyY7e2KjfyCVqSK/gAd4oB1Xu3claZNmQfRuObFeZutJw==", "026d76ca-2ff8-40fb-8eb3-79b1bb588b80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88761cad-2c5a-43b4-a97a-9bf6793f8cd0", new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEFWp6ljtAjc9hqocQm/KwmUOxnAtGcDZC8DlEe0Ly9VLRyeIREmfAcVSaHluwvhE5g==", "ad911836-b7cd-41c1-9e81-ac620aeb295b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2eeb5b8-354b-452b-9c03-8389704c054a", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAELYCmGvpnhHxbCPPIQzkbCn9a0rMtIh7KBtk8R40ngY0jii03surq2OCZMlzMMyjag==", "e919aaef-a785-4a26-88c6-47f53285c28c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be84f680-6112-45c0-9d25-d2752ca28baf", new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEGS6n65QGFUxDGxV90puihDxpm2pFnUdZdprqLaRojUrpbNhxV13EFL173agvf3vTQ==", "534659fd-40ef-4db3-b68f-0f1a2bcc98d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5802ec6-c06d-4c3a-8a12-3cb13805cffe", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEM1OnM2r6WpHwo7ExpTCaKZVwORCtfzfpcBxvhnZ4Qwnm8nVMH+SVS7bgqAUSVq46A==", "666c8248-13ba-4e2a-b8aa-14b713be92f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7874d0c-1b62-4ce2-be9d-750d5c07f06d", "AQAAAAIAAYagAAAAEJPrFm20BboiTo2S60aJWSVE3egISXVFOrBuQ4SnoQV3ybH1GlcVMUEiEV8sSVG3sQ==", "62f399bd-9dcc-40fb-9f92-c5031dea8921" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b32fbd09-bb2c-4b90-8b4c-8ce0b06f3cd2", new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEGdth/TjeOW8bfC02Mg63QAssQoSR8hGawR7GT+I6wGJkOy5Tn5xn7HGieOcVOOeJw==", "301b9383-3e13-4327-975b-87f84cb97426" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "511b045b-83c8-4ec4-9dc2-96f0a0e13809", "AQAAAAIAAYagAAAAEIs7ux5Xipw/VrVp8cjUrUv5qw3xF77EolO5F9PjQGWZxjbnhqOFCSxLhzvfNOug4A==", "45239553-c9af-483d-a59d-d73d0f45663e" });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 25, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6659), new DateTime(2025, 9, 26, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 27, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6692), new DateTime(2025, 9, 28, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 30, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6698), new DateTime(2025, 10, 1, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 23, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6705), new DateTime(2025, 9, 24, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 20, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6716), new DateTime(2025, 9, 21, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 28, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6723), new DateTime(2025, 9, 29, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 26, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6729), new DateTime(2025, 9, 27, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 24, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6736), new DateTime(2025, 9, 25, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 29, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6743), new DateTime(2025, 9, 30, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 3, 31, 34, 146, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 5, 31, 34, 146, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 13, 31, 34, 146, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 15, 31, 34, 146, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 3, 31, 34, 146, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 3, 31, 34, 146, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 13, 31, 34, 146, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 19, 31, 34, 146, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 22, 31, 34, 146, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SentAt",
                value: new DateTime(2025, 10, 5, 0, 31, 34, 146, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 4, 13, 31, 34, 146, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 4, 19, 31, 34, 146, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 0, 31, 34, 146, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7039), new DateTime(2025, 10, 5, 6, 30, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 5, 6, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7048), new DateTime(2025, 10, 6, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 6, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7057), new DateTime(2025, 10, 5, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 5, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7066), new DateTime(2025, 10, 5, 18, 45, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 5, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7075), new DateTime(2025, 10, 6, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 6, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7090), new DateTime(2025, 10, 5, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 5, 7, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7100), new DateTime(2025, 10, 5, 7, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 5, 6, 30, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7109), new DateTime(2025, 10, 7, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 7, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7117), new DateTime(2025, 10, 5, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 5, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 29, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 21, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(6622));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "MoodEntries",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8853f5e0-c4bc-48f5-bafc-d5d9eda66396", "AQAAAAIAAYagAAAAEOU6qdOgDRcsuEoQRs2+P5U9gqF3ls8icNF05vmvV79nZtjbbIObuI6uQ5zdrrWnyQ==", "a492cc69-11fe-4e63-9048-71c9c3c87ae1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "245fdad3-53c9-4689-8d68-f0eaaa92f334", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEKX1xJXmulNskaBSaHERwbPkoAzHRNdvmErRPdUQM3Qd2uXmrsgg2BFRKxcHZMvjgg==", "6b26301a-3fea-4e19-93fd-3a02c8f17c7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5a6250b-9108-4331-be99-34dfc5860b60", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEGVm84AX77vYEqwrYHKpAuLANP8EqtrRKxzLt0us4SVmB2pACk5rxGUtnFmIb1RWlQ==", "6103530a-8883-4f41-a21c-b9e2aa5b26ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb7209c7-8e45-447e-bf4b-cdb1ff6b7ca4", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEPJJ2qFvNjYdBEpoD9lS8DogNbHRSfPbbioecDM9oQgT1Cb4m80Tq363/3MVGTxPug==", "ffd72cb7-ba34-4897-abb8-39d084b6c264" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "956f79d4-2152-437b-be3c-0488251a84f0", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEH9XrRG5nrimUnJPCS5urph0fFfEJ0BvyU0F9c1NZ/O3EKKnUibv6tQF1ELaxrlJsg==", "7306b538-13fc-4efd-a052-6e595098540a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04971103-2f35-4df4-88aa-566b86877fdc", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAELdrrAaPKB72FBAeUApReG1+mvN/t47/wABkOfaO8itt4WB2LzJjWZTcebqPLuHr2g==", "6f80f616-a69a-40b8-90b4-d6f197bde5ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43ec1e15-6250-4c1d-b61a-b78b2cbecd0e", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEAJKXmQ5r8OjrO5Ys0z7HX4sjd9Uwt1iBdvMZ7VFiIRqG5cyDETp3aunasrC0/dCjg==", "b367c491-b1b0-404c-a2d4-a24d51f24844" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "386c384e-23df-4845-b8f1-e63c89e6b9e2", "AQAAAAIAAYagAAAAEOAuQ/wzO++AWGdJP5dglT/u7hWOU5iubrjLrSboboIMiudCfYzFhi11J2cRJChYPA==", "59a718d9-e12c-412b-a16e-a280fb0fb187" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "191fe6ef-7254-40a4-abb9-cb741d117adb", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAENjBJAWK6+zUErYqPlXNFbsg6RPJ3uJi75i7VPTAHATlcNqFtOmAhDXAfE8QiqwlsA==", "48dd14d5-5cc7-41fd-b7d9-7c77ba77e8ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d830571-9f6d-4df4-afc4-b021abb13338", "AQAAAAIAAYagAAAAEFu5AEHV37qkNZAMkcXbLZO1Fye6x3tm2xWZPCFjxPeD7SS1TZxhY8bC6FMNRDgIVA==", "284b0fc6-16d6-4a9e-adc7-002fc206dce4" });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 23, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3102), new DateTime(2025, 9, 24, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 25, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3153), new DateTime(2025, 9, 26, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 28, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3157), new DateTime(2025, 9, 29, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 21, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3162), new DateTime(2025, 9, 22, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 18, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3169), new DateTime(2025, 9, 19, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 26, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3173), new DateTime(2025, 9, 27, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 24, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3177), new DateTime(2025, 9, 25, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 22, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3181), new DateTime(2025, 9, 23, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 27, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3185), new DateTime(2025, 9, 28, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 1, 35, 15, 702, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 3, 35, 15, 702, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 11, 35, 15, 702, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 13, 35, 15, 702, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SentAt",
                value: new DateTime(2025, 9, 30, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 1, 35, 15, 702, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 1, 35, 15, 702, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 11, 35, 15, 702, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 17, 35, 15, 702, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 20, 35, 15, 702, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 22, 35, 15, 702, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 9, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 9, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 11, 35, 15, 702, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 17, 35, 15, 702, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 22, 35, 15, 702, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3349), new DateTime(2025, 10, 3, 6, 30, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 3, 6, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3355), new DateTime(2025, 10, 4, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 4, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3361), new DateTime(2025, 10, 3, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 3, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3366), new DateTime(2025, 10, 3, 18, 45, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 3, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3372), new DateTime(2025, 10, 4, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 4, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3378), new DateTime(2025, 10, 3, 8, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 3, 7, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3385), new DateTime(2025, 10, 3, 7, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 3, 6, 30, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3391), new DateTime(2025, 10, 5, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 5, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3397), new DateTime(2025, 10, 3, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 10, 3, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 27, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 19, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(2989));
        }
    }
}
