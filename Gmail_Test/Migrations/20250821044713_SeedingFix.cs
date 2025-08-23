using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedingFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoodId",
                table: "MoodEntries");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79cfe42d-33fb-4cbf-b407-b2af08898122", "AQAAAAIAAYagAAAAEBPSaxopIXJEybU/4c9kxk3cxw3+pB+DmXmcmZvKxnUaYBIJqjVR/QE/23/0UuqVSw==", "91fddc6b-9059-47f3-82d2-ed1d81bc3a62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a76c47cb-82db-4ede-a764-02757c96db94", "AQAAAAIAAYagAAAAEJ7CTVRUNmeVoXcu5SwCo3QmT/A3jONhB6qkoUj/lbwCNHrxEQfVH9vs9QofnitxYQ==", "5a540f5d-4e6e-42c8-bf83-3f227fbe4ff5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cda54cd6-e87e-4556-9f34-ce9bb8d2b190", "AQAAAAIAAYagAAAAEEXDD8jN77KfmrMALGIPti9AbF2UGvJg9Wocwwdr0JNYryN9cJ0mtl0lo1pyyCPhOw==", "3dc16a07-3867-4bd0-bd1e-c82ee699ee7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84b6d338-a015-4c75-b35c-57b352243ee4", "AQAAAAIAAYagAAAAENUmOlDvkYHOMVHK4j/AKZ8MPMUn5L3BvdBKX5fUln4cFkV+GBpCROc2u1GvODF7KA==", "2dbb9a9a-ae01-49a8-9ef9-c2e04d8fd5f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b5c5f1a-2ee5-462d-b7d8-c28c09a0c60e", "AQAAAAIAAYagAAAAEIWj277v1rgzI12Ozu2dTdV29hHmopROGaeG1agoz/4qiAZvgmNtNQRJYQRYMVpFKQ==", "4721ddf6-9fc8-4ae7-a10c-ede6de42fd83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4ba2846-2b1b-40b5-bad9-0bf7af212745", "AQAAAAIAAYagAAAAEDnDs3EGHGHlguCjeKsQ4m3SZXPS5m/DBee37He97fQuINWrsJQ1NMbbjaAijZp+5g==", "f328e72b-a877-41ed-97ab-f2bb705bdb65" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "116aa4b2-fea2-4802-9594-7214a8620edd", "AQAAAAIAAYagAAAAEL38YD6AdkvGsfgxH+DKyIJ+ml01C9YVlnEPpITKuiHsCdH1coUaFQjZM5aGlrFUcA==", "82d09dd0-842c-4355-865b-df3ebbcb629e" });

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
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 2 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 5 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 3 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 2 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 5 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 2 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 4 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "Mood" },
                values: new object[] { new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MoodId",
                table: "MoodEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 0, 1 });

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
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 0, 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 0, 2 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 0, 5 });

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
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 0, 1 });

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
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 0, 5 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 0, 6 });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "Mood", "MoodId" },
                values: new object[] { new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 0, 2 });

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
    }
}
