using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class planner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlannerEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventType = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannerEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlannerEvents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cbdee09-1527-4f70-84c4-00a5fa33b3e1", "AQAAAAIAAYagAAAAEMo3pzzbqbBrARNvd9hCrDmtcSI7Z5exczC750DzvIXx5z1vUKXu9y1Ct6IL6AbKyw==", "1ca4e25d-d499-4902-a5dc-f130522b2c6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7afc043d-4f87-449a-bf8b-70ddac4e9dc1", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEDx66lx3EA20WhlgMZhDLg2Vo6sRGmu4zrM1oxVQdXjU3/oCjhE9RJTHI8zaWVtNpg==", "5952202c-cfb6-4c98-aa0c-ade74672ab03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e18850b-1a21-4e9d-82fe-2b7823c65efa", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAENUSBGoZTE8J4gBAVw4w5Aim51BEk5sWnGc4UHKDYAmml+g9+zlnEa7KFVyXVPsnzg==", "24240812-0d15-45f7-8c9f-2d7c54ef2aff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da7c201a-636b-42e3-996c-ed1738a4aff9", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEORAcHNvTAJoHkZSNCaU7XkZ0wPNjuF1NQlfIF/MEqm7CsTWL1yGqE1IOei3zmuStw==", "b26a2134-0979-4ae6-b3bc-8f6aca786cbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91be1e0a-e5dc-4e7b-a3c4-057729ef3c44", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEALhXF3gWFzPiZTQyoMl3Z5yhVy6dkxCy3z2XjErwpwKKTCgwgOy0XmDRVbnk9dySg==", "b2f6be4a-c15b-4467-b2dd-c0dd36dda1bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43ea1a1a-b105-4173-947c-a18dc968d434", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEIzbn9lnN/UfSXi3cB6wCbsVQG15VzRMzH2GJXQ2yO+IIn90Nyp4tj/fFOKNseEtFA==", "5ce2fd12-83bf-4ada-a2ee-14ba8a7c0f43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "322842e9-461d-42b8-acb1-2db99c1fdd60", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEC7wOz3CTmywx/GrHkwHEsOy3O17DA3n8hAAPROAvNfSmtjJTIRh6Fw1PCX7vTc0dA==", "79cde222-1b16-4492-bb5c-5e8a369007b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b568e0c9-9294-4fbd-8e3f-2a6baf4d194d", "AQAAAAIAAYagAAAAEBBPodot6NlzZ8k8i8jFW2WiJtFusF9Y99EnytAjhH61Ph5/ze/V9xT96akzSRe1zg==", "dc32535e-2448-447b-a6f9-698ef2bb47ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "470a9db7-8fa6-453a-9cba-5741bce3a0ac", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEHq0cfA4XqQx5NupZDuR/h59oX74WZlT2LkuakEWL98xgBFHiubL6b/+lDTcf2GSJw==", "54b3b290-fc34-4a23-b920-2dc5983ace85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d79ee28-e308-4186-99d2-f80150d7224b", "AQAAAAIAAYagAAAAEIlOCpgFU03pCQUQh0hPTQlfm15oWsYTu4WBXQSepAx0DDk2czgQWpJ0aCraYVT06Q==", "7fec26a8-9146-4c68-973d-b5b7133c82d8" });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 23, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5369), new DateTime(2025, 9, 24, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 25, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5397), new DateTime(2025, 9, 26, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 28, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5404), new DateTime(2025, 9, 29, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 21, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5411), new DateTime(2025, 9, 22, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 18, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5422), new DateTime(2025, 9, 19, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 26, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5430), new DateTime(2025, 9, 27, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 24, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5436), new DateTime(2025, 9, 25, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 22, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5443), new DateTime(2025, 9, 23, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 27, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5450), new DateTime(2025, 9, 28, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 16, 47, 37, 689, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 18, 47, 37, 689, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 2, 47, 37, 689, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 4, 47, 37, 689, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SentAt",
                value: new DateTime(2025, 9, 30, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SentAt",
                value: new DateTime(2025, 9, 30, 16, 47, 37, 689, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 16, 47, 37, 689, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 2, 47, 37, 689, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 8, 47, 37, 689, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 11, 47, 37, 689, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 13, 47, 37, 689, DateTimeKind.Local).AddTicks(5559));

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
                value: new DateTime(2025, 10, 1, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 2, 47, 37, 689, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 8, 47, 37, 689, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 13, 47, 37, 689, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 27, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 19, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.CreateIndex(
                name: "IX_PlannerEvents_UserId",
                table: "PlannerEvents",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlannerEvents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8cbf4b1-0d2f-4094-8229-d1bcc0e3024e", "AQAAAAIAAYagAAAAEFodUDZNRZJRuhI4EB7R7B595DfGXqv8F5oA0rpOfs8noCoDynQ4c0Xtwe5YRO8b+Q==", "12749e79-0205-4cd2-a717-7702cfeda15f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a9190e0-a752-4dfa-81e3-a144c3976065", new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEFIzwUY/RFTQyhWY3c2Q91tKtTrlr4LIjpYNfyBwUlk4sUui4iJ/LoWSgl/9QfEBmQ==", "01eae5ea-70f4-4155-a8a8-3aca3437891b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2891322a-7cf0-4c31-a867-1b817ea7b25b", new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEBE55KxmgcQDyOg+ELUQGH0Tz0LwsFQIjuufw4Y6zlfbX8kGAKHqJiqHecboAYW0dg==", "75b07aa6-c291-4892-9d5c-27725db2d44a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9409b1b3-a388-4cf7-86d4-9e2c7d11f3ea", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEOMBhVtwn11T2hvF6TE+4o5MquP7VUPBQ7GSnKyfPi5QqCvelN4psh7gzLQrVcRaMQ==", "d04c6b04-9aeb-4217-96ad-a54ec8d5d590" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2c5b668-efe0-411a-8468-4aa51bd4f72f", new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEAbiu59yQxMn65pLOwYIYE0Wgy8+ReYxEMGnpBLmAXp/xPk8rcBHns9ATA9S2Ditzg==", "4e731e08-642d-4ec7-95fd-4cbd2ffd37be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db2443df-c2d3-44cd-b0ea-581fde5bf183", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEMlWgbtGcSQJLQWPrDH4zyWkGyQMge4mLlyHjmakOFc/17T9OviYqB7sFBkG8Zq6uQ==", "4c7bb592-523c-4b9d-a468-fc29c2580e10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dab2ce39-86f2-421c-a6b3-48b856d3afa7", new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEC8i5+4Ff7lo9YgjuU++AmjVs+BMW2s76ikYVdvlclHrZ+rzXktyoGRVWK7elaK4oA==", "2f01d30c-1d88-462d-80c5-5a5961080ed2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14081d5d-ffb0-4e27-9cc7-b46d5985ee40", "AQAAAAIAAYagAAAAEGfLBRRZrS6v9FtwfWMs+60Anl93X3ca6Wz5bpck8KV9j6+Y5JUXT81RIo+PIOZPJQ==", "ea5918ba-7f80-451e-bc51-9cf2ef1bc537" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "790b6c61-816d-470f-b45d-16f0cfaa05a8", new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEASPs7nrMXVybDK8rUjIu3qDpnY2filzVt6GCjsBcOHsV7kBBqgHDk5lsB6k9NUlRQ==", "cc025c71-9c04-40eb-8f37-7d802fd26377" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d639ef4e-b194-414a-b685-14a15ae1de32", "AQAAAAIAAYagAAAAEELqfyDbPHSDaiJib5WYcqlmluhvl/S5C2pDLx/6RQDqr532uoiWQBQp1lvjukEC/w==", "ce275c9c-7687-4d88-84e5-ca0f4be49016" });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 3, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1882), new DateTime(2025, 9, 4, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 5, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1929), new DateTime(2025, 9, 6, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 8, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1933), new DateTime(2025, 9, 9, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 1, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1938), new DateTime(2025, 9, 2, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 11, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 8, 29, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1945), new DateTime(2025, 8, 30, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 6, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1949), new DateTime(2025, 9, 7, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 4, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1953), new DateTime(2025, 9, 5, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 2, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1957), new DateTime(2025, 9, 3, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 7, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1961), new DateTime(2025, 9, 8, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 9, 11, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2025, 9, 11, 23, 36, 49, 783, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2025, 9, 12, 1, 36, 49, 783, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SentAt",
                value: new DateTime(2025, 9, 12, 9, 36, 49, 783, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SentAt",
                value: new DateTime(2025, 9, 12, 11, 36, 49, 783, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SentAt",
                value: new DateTime(2025, 9, 10, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SentAt",
                value: new DateTime(2025, 9, 10, 23, 36, 49, 783, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SentAt",
                value: new DateTime(2025, 9, 12, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SentAt",
                value: new DateTime(2025, 9, 12, 23, 36, 49, 783, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SentAt",
                value: new DateTime(2025, 9, 13, 9, 36, 49, 783, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SentAt",
                value: new DateTime(2025, 9, 13, 15, 36, 49, 783, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SentAt",
                value: new DateTime(2025, 9, 13, 18, 36, 49, 783, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SentAt",
                value: new DateTime(2025, 9, 13, 20, 36, 49, 783, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 9, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 9, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 11, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 13, 9, 36, 49, 783, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 13, 15, 36, 49, 783, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 13, 20, 36, 49, 783, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 11, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 7, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 30, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1834));
        }
    }
}
