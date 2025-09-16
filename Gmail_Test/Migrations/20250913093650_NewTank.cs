using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class NewTank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "AddresseeId", "CreatedAt", "RequesterId", "RespondedAt", "Status" },
                values: new object[,]
                {
                    { 1, "15", new DateTime(2025, 9, 3, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1882), "14", new DateTime(2025, 9, 4, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1924), 1 },
                    { 2, "16", new DateTime(2025, 9, 5, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1929), "14", new DateTime(2025, 9, 6, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1931), 1 },
                    { 3, "14", new DateTime(2025, 9, 8, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1933), "17", new DateTime(2025, 9, 9, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1934), 1 },
                    { 4, "17", new DateTime(2025, 9, 1, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1938), "15", new DateTime(2025, 9, 2, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1939), 1 },
                    { 5, "15", new DateTime(2025, 9, 11, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1943), "18", null, 0 },
                    { 6, "19", new DateTime(2025, 8, 29, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1945), "16", new DateTime(2025, 8, 30, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1947), 1 },
                    { 7, "16", new DateTime(2025, 9, 6, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1949), "20", new DateTime(2025, 9, 7, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1951), 1 },
                    { 8, "19", new DateTime(2025, 9, 4, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1953), "17", new DateTime(2025, 9, 5, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1954), 1 },
                    { 9, "20", new DateTime(2025, 9, 2, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1957), "18", new DateTime(2025, 9, 3, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1958), 1 },
                    { 10, "20", new DateTime(2025, 9, 7, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1961), "19", new DateTime(2025, 9, 8, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(1962), 1 }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "IsRead", "ReceiverId", "SenderId", "SentAt" },
                values: new object[,]
                {
                    { 1, "Hey Mike! How are you feeling today?", true, "15", "14", new DateTime(2025, 9, 11, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(2000) },
                    { 2, "Hi Alice! I'm doing okay, just a bit stressed about work. How about you?", true, "14", "15", new DateTime(2025, 9, 11, 23, 36, 49, 783, DateTimeKind.Local).AddTicks(2004) },
                    { 3, "I understand. Work has been tough for me too. Want to chat about it?", true, "15", "14", new DateTime(2025, 9, 12, 1, 36, 49, 783, DateTimeKind.Local).AddTicks(2007) },
                    { 4, "Emily! I saw your mood entry from yesterday. Are you doing better today?", true, "16", "14", new DateTime(2025, 9, 12, 9, 36, 49, 783, DateTimeKind.Local).AddTicks(2010) },
                    { 5, "Thanks for checking in, Alice. I'm feeling much better today! 😊", true, "14", "16", new DateTime(2025, 9, 12, 11, 36, 49, 783, DateTimeKind.Local).AddTicks(2013) },
                    { 6, "David, how do you handle stress? I'm really struggling this week.", true, "17", "15", new DateTime(2025, 9, 10, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(2016) },
                    { 7, "I've been using the breathing exercises on the app. They really help! Want to try them together?", true, "15", "17", new DateTime(2025, 9, 10, 23, 36, 49, 783, DateTimeKind.Local).AddTicks(2018) },
                    { 8, "James, I noticed we both had rough days yesterday. Want to support each other today?", true, "19", "16", new DateTime(2025, 9, 12, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(2021) },
                    { 9, "That would be great, Emily. It helps to know we're not alone in this.", true, "16", "19", new DateTime(2025, 9, 12, 23, 36, 49, 783, DateTimeKind.Local).AddTicks(2024) },
                    { 10, "Olivia! I'm so proud of your mood streak! 🎉", false, "20", "18", new DateTime(2025, 9, 13, 9, 36, 49, 783, DateTimeKind.Local).AddTicks(2026) },
                    { 11, "How's your pet doing, James? I've been thinking about you both.", false, "19", "17", new DateTime(2025, 9, 13, 15, 36, 49, 783, DateTimeKind.Local).AddTicks(2029) },
                    { 12, "Remember to use the breathing exercise if you feel overwhelmed!", true, "15", "14", new DateTime(2025, 9, 13, 18, 36, 49, 783, DateTimeKind.Local).AddTicks(2032) },
                    { 13, "Thanks for being such a good friend, Alice. It means a lot.", false, "14", "16", new DateTime(2025, 9, 13, 20, 36, 49, 783, DateTimeKind.Local).AddTicks(2035) }
                });

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

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationId", "ConversationId", "CreatedAt", "IsRead", "Message", "MessageId", "SenderId", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 11, 21, 36, 49, 783, DateTimeKind.Local).AddTicks(2067), false, "Sophia sent you a friend request", null, "18", "15" },
                    { 2, null, new DateTime(2025, 9, 13, 9, 36, 49, 783, DateTimeKind.Local).AddTicks(2070), false, "New message from Sophia", null, "18", "20" },
                    { 3, null, new DateTime(2025, 9, 13, 15, 36, 49, 783, DateTimeKind.Local).AddTicks(2073), false, "New message from David", null, "17", "19" },
                    { 4, null, new DateTime(2025, 9, 13, 20, 36, 49, 783, DateTimeKind.Local).AddTicks(2075), false, "New message from Emily", null, "16", "14" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f21b6e53-294d-4ee9-86d6-7c4d30cd25fa", "AQAAAAIAAYagAAAAEHGtojD/oB5pT+ziUa5NKCK+DjtVM9D/wW2p8dQRT9zT15tnVT6gjWPTGpFUeGWiNg==", "916c7a8e-409b-424a-b6f2-5326dc41dac3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ffc7a95-5fda-460d-8ed1-becff3ad8917", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEMOKel436dU549H+dPm8UNzdeG0VdRtic9eITWBESq8s12WAGA2FH1C5tjyQX99dsw==", "db4fd83c-20f0-41e1-810c-1652b55cd812" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aa94900-a36a-4fa2-96d4-e77fb5aa25c0", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEAsIHeoI/Pk2jf87DWxv+hZV0Rr7N9zuke6yTB/ChBBtrvFtpSPhPc9Di8wa3/vE/w==", "2d206539-6b3f-4270-87f7-2f889a344c13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "995d25d8-3733-48e0-8f99-fecbaa1983b1", new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAENoGHyzN6WmKozf2Utti7faBgrAq28rjmoXB8SW6CLHGknGv4HWBkrxhrfKX3/R74g==", "5cf9537a-d579-4d8c-9605-83dd949d18c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f9cd3eb-0299-4e4c-bf38-bd3aca440e91", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEFZFbP2pFta4EPK80Yls1I7QoNJ4OSjD04uvD3FbA5pqIOYcKTF1Gj+lCHJAEP9+oA==", "274e75ca-00b3-4a09-8060-280629114092" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3915716f-1a28-488b-bcdc-2f12e21d7750", new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEGjpjkltzACuzJtPX2AYF48h7m4VbOBrTm2KJyuKEVWrxiwmvd2cLmnpS4vElSpGcQ==", "d7b676f6-74e0-443e-a0c3-092b1c8a5e7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f0f667b-9fd1-4c45-a6fc-0621fdcf04ae", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEL1DmRAze3z+2dNndkUnql22upHN5+uuxLZS77IuLshy+xm9mcSkektKDTrsPEqb0A==", "ee00e71b-88bf-4f72-a397-8eada711f651" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2b7a345-d691-466b-858a-9ff8c560458d", "AQAAAAIAAYagAAAAEDmpstxecI6BfVQTjP2vjY4f8zWbG9l9s0lPH+vacrB+tkvV/DpEsEl4LcGArRiQ1Q==", "f05c7cbd-2ed2-4735-b46c-b3501a6b0d30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c060ae2-1efd-4a53-90e9-2074d9b14bad", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEAlTFF0KWMDyGCilXgiw3HI5weHyQHf65UT8ytB0WC10SBq/MxBHzK6q+o/x1emLrQ==", "07219d63-9554-4280-96fe-aed744596d1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28369112-6990-447b-a699-c710799cca10", "AQAAAAIAAYagAAAAEJArF24q+PYuPKSAQ/WxQ0dEXc3liYa5TPGfyGdprHtlGCEKhD6yDElCcM43ICMdDw==", "abc29d32-adf9-49f1-80ad-9349b45fa4e4" });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 9, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 9, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 10, 23, 51, 42, 392, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 23, 51, 42, 392, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 23, 51, 42, 392, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 29, 23, 51, 42, 392, DateTimeKind.Local).AddTicks(140));
        }
    }
}
