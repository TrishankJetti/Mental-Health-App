using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class Badges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Badge",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CurrentStreak",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LongestStreak",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Badge", "ConcurrencyStamp", "CurrentStreak", "LongestStreak", "PasswordHash", "SecurityStamp" },
                values: new object[] { "None", "f9f9f32c-d2b8-425e-b13d-49f296e80ca8", 0, 0, "AQAAAAIAAYagAAAAEPCr8VMyGJIoXgf1qRKt5Rf/795Qhs/DMquTsEu1uDn1il7jwUuB17V0z2iToIDTJA==", "814a1b09-3496-4167-8871-3c2284668ce9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "Badge", "ConcurrencyStamp", "CurrentStreak", "LastMoodCheckIn", "LongestStreak", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Bronze", "78c63d6f-d427-4b1d-a8db-39a15680eb9c", 1, new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 2, "AQAAAAIAAYagAAAAEOJWfDuznxPqZUO4fSyLF1hTi0tQ+49fa7wAjUgN8V9VQWsBg8K83OciQ6IQDak3tg==", "56fab9ed-cebb-46fc-9d78-46d8bcf94b09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "Badge", "ConcurrencyStamp", "CurrentStreak", "LastMoodCheckIn", "LongestStreak", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Bronze", "5c1d0cc9-ae88-4ea6-b926-e442b67cc929", 1, new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, "AQAAAAIAAYagAAAAEAcOzRDcDJgaXBleLVUhVQXT2N9dxI92Odz2lJz3tMIWUJL6Vn1bExUR5D53AD9iGw==", "016b2d89-78d6-45b1-94e4-19a4c60f4f8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "Badge", "ConcurrencyStamp", "CurrentStreak", "LastMoodCheckIn", "LongestStreak", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Bronze", "f3903cad-5c71-4635-976c-11337d34bac8", 1, new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, "AQAAAAIAAYagAAAAENjxTN3FB0vSJ/PsfNsmTRWTOfegnY2FzUHu3Yws+xvwwf4dqJfsE6hr3qd4w8ImLA==", "ea409b9d-5256-42e6-b736-1e4b86968004" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "Badge", "ConcurrencyStamp", "CurrentStreak", "LastMoodCheckIn", "LongestStreak", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Bronze", "425d4f0a-e19d-430c-b73f-1036a12bcdba", 1, new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, "AQAAAAIAAYagAAAAEFHMvWis+6awRDSaypsv8EQsZerlhS58GFb68L2ReXUP0nKAqXn6RpwRhFoyr+Mgwg==", "16a1e924-7c46-445b-8d06-64ae9f8cbd9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "Badge", "ConcurrencyStamp", "CurrentStreak", "LastMoodCheckIn", "LongestStreak", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Bronze", "8ff402f5-a783-4dc0-9c7a-6fd21e6c0e43", 1, new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, "AQAAAAIAAYagAAAAEDQ0NpH7a3uaBFJCBKraJ18k1mbOizLERQ7KYruWyMqjWAmj+rjWIcSzeFbPQLNSaw==", "176d9f0d-3f3a-4d39-831e-2e57b41d73a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "Badge", "ConcurrencyStamp", "CurrentStreak", "LastMoodCheckIn", "LongestStreak", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Bronze", "45db957c-d4de-4ee4-b11b-5ead4ca9b70e", 1, new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, "AQAAAAIAAYagAAAAEAtKZlvfU34XN+XcMfzqQdlxtpIeGJiK+N2zvkf6bQujZTykAi4yOB1+G0uWsPPsOg==", "151fd924-eccb-4c23-804c-8a1846c64d78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Badge", "ConcurrencyStamp", "CurrentStreak", "LongestStreak", "PasswordHash", "SecurityStamp" },
                values: new object[] { "None", "a4b73dea-7f60-4f29-b664-80016c1da2b8", 0, 0, "AQAAAAIAAYagAAAAEHPqWRw5lLqdPL6AUrZDZ3dbYoJNjHa9PgUgmPC4DWI+sD+M9POboUDQENARa/dj4A==", "314a8cfb-090c-4aa2-9cc5-68b5d9560056" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "Badge", "ConcurrencyStamp", "CurrentStreak", "LastMoodCheckIn", "LongestStreak", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Bronze", "e1701031-6d20-4a4f-8c52-14a8b53b9ac3", 1, new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, "AQAAAAIAAYagAAAAEPaKqycSevhHtmj/1T92gzFd/mjgNrSO51ElA9k8MNzu1waUwd7CCBdKTwqnIXB3ug==", "fd246182-b3f3-493a-b2ad-f9a17de1474e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Badge", "ConcurrencyStamp", "CurrentStreak", "LongestStreak", "PasswordHash", "SecurityStamp" },
                values: new object[] { "None", "09fc4574-d8eb-4f73-baa5-6f29cf4bf97b", 0, 0, "AQAAAAIAAYagAAAAEPBgJ7QHKhDHJzwxywILNrLVYgvbjLDGrjfTCinE6JBgRIYsffsjd0ChrUKV32ZWEA==", "6e29fc28-2a5c-4552-a98c-4ea418316a85" });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Badge",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CurrentStreak",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LongestStreak",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7a51191-12bb-430e-b0eb-0e5ca1d6d6b3", "AQAAAAIAAYagAAAAEKG2UKuPIXqrUaVyMqAkVchZbBbzQgmPvN+hKsemlXMD7K+DA5JHQLPhIXNIE80oAQ==", "b5a61bae-f844-4897-9cd7-3e348c73ba5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79cfe42d-33fb-4cbf-b407-b2af08898122", null, "AQAAAAIAAYagAAAAEBPSaxopIXJEybU/4c9kxk3cxw3+pB+DmXmcmZvKxnUaYBIJqjVR/QE/23/0UuqVSw==", "91fddc6b-9059-47f3-82d2-ed1d81bc3a62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a76c47cb-82db-4ede-a764-02757c96db94", null, "AQAAAAIAAYagAAAAEJ7CTVRUNmeVoXcu5SwCo3QmT/A3jONhB6qkoUj/lbwCNHrxEQfVH9vs9QofnitxYQ==", "5a540f5d-4e6e-42c8-bf83-3f227fbe4ff5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cda54cd6-e87e-4556-9f34-ce9bb8d2b190", null, "AQAAAAIAAYagAAAAEEXDD8jN77KfmrMALGIPti9AbF2UGvJg9Wocwwdr0JNYryN9cJ0mtl0lo1pyyCPhOw==", "3dc16a07-3867-4bd0-bd1e-c82ee699ee7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84b6d338-a015-4c75-b35c-57b352243ee4", null, "AQAAAAIAAYagAAAAENUmOlDvkYHOMVHK4j/AKZ8MPMUn5L3BvdBKX5fUln4cFkV+GBpCROc2u1GvODF7KA==", "2dbb9a9a-ae01-49a8-9ef9-c2e04d8fd5f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b5c5f1a-2ee5-462d-b7d8-c28c09a0c60e", null, "AQAAAAIAAYagAAAAEIWj277v1rgzI12Ozu2dTdV29hHmopROGaeG1agoz/4qiAZvgmNtNQRJYQRYMVpFKQ==", "4721ddf6-9fc8-4ae7-a10c-ede6de42fd83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4ba2846-2b1b-40b5-bad9-0bf7af212745", null, "AQAAAAIAAYagAAAAEDnDs3EGHGHlguCjeKsQ4m3SZXPS5m/DBee37He97fQuINWrsJQ1NMbbjaAijZp+5g==", "f328e72b-a877-41ed-97ab-f2bb705bdb65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "630c6b2f-e7a5-4087-b5c0-6075eb5add50", "AQAAAAIAAYagAAAAEMc+93ivXhNZ9aZCngz1X1XuLGqEhqcb5M+ihqrDn/RDVBubLJmzjTzxv8SyRvv/Sw==", "3551968f-1ee3-4bde-8a26-0a232196e9cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "116aa4b2-fea2-4802-9594-7214a8620edd", null, "AQAAAAIAAYagAAAAEL38YD6AdkvGsfgxH+DKyIJ+ml01C9YVlnEPpITKuiHsCdH1coUaFQjZM5aGlrFUcA==", "82d09dd0-842c-4355-865b-df3ebbcb629e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bb7135c-2e1c-4dae-a771-a15defa5178f", "AQAAAAIAAYagAAAAEGTcVQm6e1vBwvF7+J0C/7vGdXHMzvQTqA/lDCJT4MOGJplHc9qTCnkVHN79s/B22w==", "8eb0b25d-06dc-4fe6-ab3b-f0e85c2db1d5" });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
