using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class UnVertChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3948b6d2-b353-4798-9d9e-541d24c22231", "AQAAAAIAAYagAAAAEJ4GA8/+zEv5nQ5RxO+Zy+mtEQs7V1/hm9X92r+Owvikq1w0eSBI8zBDVBmV8TETYQ==", "bbf0129b-bc53-4799-8bca-c7c2c7924ad3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1e37989-19c2-47c5-8b69-7f1fa8b25615", "AQAAAAIAAYagAAAAEJ1EwDjCYHmyeUfuXheK6CzFuEPlbDUZ/RWKuqpdH4fPb5H8fdv3ZAtSJAyBHikm4g==", "d52914ac-2c09-4dea-b58f-fe0e4d4df284" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bf9acac-a9d4-470f-88bc-693419db07c4", "AQAAAAIAAYagAAAAEOCxShZikFedTDSJp0FyavTxWX302tjnRpoqQwoHR3WhZGt6ZgQQpMtGyez6DGNbuA==", "752fac20-66d9-48fa-b64e-007b95f13e59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70973b8e-6e61-44a8-8e5e-7fc97adb6112", "AQAAAAIAAYagAAAAEK14h4QGwPyK5Tt2t08mw/UjwHu1YiAD3yAQl7J5pRFwhMW8GGX2sb2etX+O7gbkKA==", "3595eaea-2635-42e8-a1c5-2d105c6f5d16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a514943-72dd-4ea3-bc1c-ecd0dcb6ab3f", "AQAAAAIAAYagAAAAEF8y7WGXqm+2RMyq2UzpZuvJcvAhFVgZ8UKkmNmdlq1d7qpzaXBLKxXBcwUFmGN5JQ==", "45b15b5b-442b-4c75-bc46-90e0bec180e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e4eaa59-14b8-47a7-8eda-bcb2612d0808", "AQAAAAIAAYagAAAAEOn0MU7Bp1oEpKLzxE8ugVhY5gyrlK6ZbD9EcPABhKLbrAUHRo5+bJHjZRE4TSb7DQ==", "c06b27b1-3102-4cfe-a485-78665b9690a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90a1ad91-265b-4ae9-8c4e-c31cd37eada3", "AQAAAAIAAYagAAAAEOlw9aq+UHPnCTksqtnw+3j2TONs6ZyZpVtKdxwhSVcTpiF9LDW+eVOI4PFIQ+OV2A==", "ade07d62-e6b4-45c8-940a-326a344dd16f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b69f4ec-a264-4e11-914e-d7e556198ccc", "AQAAAAIAAYagAAAAEFZBeho+ufUSfa0rDF56x7NoYrNcCCv5hKMWERJQQjycAAictmSdCyMqAX66A4kKvQ==", "f0171cc8-b732-45d7-b355-b0729a556ab4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da4c1b4c-bfd7-4175-b963-2b840e219141", "AQAAAAIAAYagAAAAEMv/27cHQK2/4CIB6CStV7k+7Hmpo8qV3obwZKZHaSavvAZTdUdXKVMQBRvoJJyYEg==", "e34298d6-84b3-4613-aa7b-fd2ed1d045e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cea616cb-964e-4842-b0df-88e8436f3780", "AQAAAAIAAYagAAAAEM/Nm4zH9sHez1oq8edbuufJqWHtw2k6S9wXQNx+D8eTKVv0mFrQXgoaFg4tqZHSPw==", "8ae26389-ba9b-4900-827f-31190aec976c" });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 25, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2803), new DateTime(2025, 9, 26, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 27, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2852), new DateTime(2025, 9, 28, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 30, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2856), new DateTime(2025, 10, 1, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 23, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2861), new DateTime(2025, 9, 24, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 20, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2867), new DateTime(2025, 9, 21, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 28, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2871), new DateTime(2025, 9, 29, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 26, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2875), new DateTime(2025, 9, 27, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 24, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2879), new DateTime(2025, 9, 25, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 29, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2883), new DateTime(2025, 9, 30, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 15, 32, 3, 348, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 17, 32, 3, 348, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 1, 32, 3, 348, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 3, 32, 3, 348, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 15, 32, 3, 348, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 15, 32, 3, 348, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SentAt",
                value: new DateTime(2025, 10, 5, 1, 32, 3, 348, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SentAt",
                value: new DateTime(2025, 10, 5, 7, 32, 3, 348, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SentAt",
                value: new DateTime(2025, 10, 5, 10, 32, 3, 348, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SentAt",
                value: new DateTime(2025, 10, 5, 12, 32, 3, 348, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 1, 32, 3, 348, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 7, 32, 3, 348, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 12, 32, 3, 348, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 29, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 21, 13, 32, 3, 348, DateTimeKind.Local).AddTicks(2749));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d27fb3d-4fd3-4185-bcee-28ea3fdf3bcc", "AQAAAAIAAYagAAAAEISwXH/p/e1IfjSVUvl4y5m+QVBHfPAlN60is9pVngsA0Ush3v1Uuo4fh9cIpgKj/Q==", "2c40b406-59c9-4469-ad06-74b9d91f1238" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1603a184-cfa6-4a33-82c6-beb7e4aeb8d8", "AQAAAAIAAYagAAAAECKIG1zwOzMo1T8oG9Sy1wgzuYZu2S/yqXTdvaHTaPPwnCJsX3uiWY/vnMdFxNk1Tw==", "70469675-cfa1-498d-9e53-2e1560634681" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fdd72d7-afd5-41f2-b00c-c9572c0a0914", "AQAAAAIAAYagAAAAEMj76CNh5+sxCSkke4KAS33U/7CnQFzxiIh9Yb3AmRUaueODsiBVkJE4xCGLHA32sQ==", "bac8817e-2763-4c78-8e61-7feac87fa378" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f5da144-c043-49f9-a49d-b83601e0b972", "AQAAAAIAAYagAAAAEL1mQGPF6s/Po70DtFulMCTElY8ew+z9M2y7VrFgwALsDEX1hqwbPdmhJWZ0a/tGsQ==", "4386cdd2-3cda-4fda-aa33-1b05cd3ee6ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79d9d1c0-96eb-4352-9f2f-2942e068fe88", "AQAAAAIAAYagAAAAEKnJIJYQ7letJt/uBQJHz1jfJl1HF81xWuoHia4qle+MP/Xf8Ow0dPTnmW+ypiqTtg==", "6f963aea-ea25-4eb3-9354-691a991ea3dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9242a20d-2179-4abd-a78d-ea0c7c52da57", "AQAAAAIAAYagAAAAELhnQHbtWh9riAh58ND8MC+V4Pm/UrjFJs02n1dkjn4gFvF9ELlC3j7d5WoqnB4usQ==", "ad1f6be9-6c0e-4d91-bed1-b46391837f11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c91c22ca-a6ad-431d-aaf2-8cfb44749c67", "AQAAAAIAAYagAAAAEICCB4xIruCVljmBXOZziZxh4V0138QdYhKJMs+icV72XDH609Nzg6e4uYN/Rhowhw==", "dd19c96a-dfe4-480a-a636-ee3c14f32dc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07deeef4-31d7-48d5-855e-7cbd83bc346e", "AQAAAAIAAYagAAAAEHjtzTiMz6HXzdKH+ZG0V1s3UU9Bl2/HHL1j2RelqYvzdg967kbTmXNa1TO2QVsg6g==", "3ec75caa-b88f-43d1-b768-6cf589a767b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3530cb6a-2b11-4160-9e8a-3380536cce4d", "AQAAAAIAAYagAAAAEBhScdLRXlGgFpfZQdzBAO+A7RCKFx1oYSgmqJKzakJF1UNqHzoZsHsNKniwloZ47w==", "f056dc04-08a5-4abb-bf56-b8726b2e2be5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd50bfa5-fb51-4e08-9cda-c5fd4066e24d", "AQAAAAIAAYagAAAAEJcgt/VWwt7/wQ1xb48fMazmtkY4Qp7mL2ki2NWvb8S3VcLY1PX9WC87JvKoqyH1OQ==", "fa21ed13-9042-43af-84e3-3bcf97e870df" });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 25, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7941), new DateTime(2025, 9, 26, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 27, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7985), new DateTime(2025, 9, 28, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 30, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7990), new DateTime(2025, 10, 1, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 23, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7994), new DateTime(2025, 9, 24, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 20, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8001), new DateTime(2025, 9, 21, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 28, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8006), new DateTime(2025, 9, 29, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 26, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8010), new DateTime(2025, 9, 27, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 24, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8015), new DateTime(2025, 9, 25, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 29, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8019), new DateTime(2025, 9, 30, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 15, 24, 45, 31, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 17, 24, 45, 31, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 1, 24, 45, 31, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 3, 24, 45, 31, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 15, 24, 45, 31, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SentAt",
                value: new DateTime(2025, 10, 4, 15, 24, 45, 31, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SentAt",
                value: new DateTime(2025, 10, 5, 1, 24, 45, 31, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SentAt",
                value: new DateTime(2025, 10, 5, 7, 24, 45, 31, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SentAt",
                value: new DateTime(2025, 10, 5, 10, 24, 45, 31, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SentAt",
                value: new DateTime(2025, 10, 5, 12, 24, 45, 31, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 1, 24, 45, 31, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 7, 24, 45, 31, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 12, 24, 45, 31, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 24, 45, 32, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 24, 45, 32, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 13, 24, 45, 32, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 29, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 21, 13, 24, 45, 31, DateTimeKind.Local).AddTicks(7895));
        }
    }
}
