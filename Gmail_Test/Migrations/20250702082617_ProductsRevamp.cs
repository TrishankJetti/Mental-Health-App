using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class ProductsRevamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductEntities");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastMoodCheckIn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

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
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bec40b0-624a-400a-bf17-4dada32faf9b", null, "AQAAAAIAAYagAAAAEEnGWGG0qEJ3rxlyylpGnS4rzQkQf9lqWF840HFQB7lw71IUt8JDym+3GbQ//yuWLQ==", "eaedd04d-836c-49fd-964e-daf58e12e765" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61be3261-fa93-46d7-a3e9-94ff3402ab17", null, "AQAAAAIAAYagAAAAEHaOqKcuXT39ZSPddljFKSEsnqEb0Dt3dwegj9DwWCq48c2Mq8kaNtrS0JnY5KlNeA==", "325aba83-c183-45e5-9f5f-3503101fcd5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfb65849-5ebc-4f86-8980-7e0faa8a2220", null, "AQAAAAIAAYagAAAAEPZosyFRs4kwVEh/0VCcaYt/aJ8yRxyn23zWtHd3ysF3Jf8n6Urve0tNZhMenuDilA==", "98c2bef7-b970-4edf-9303-72e440eefcd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9437141-c757-4b16-823e-3daab77c0f79", null, "AQAAAAIAAYagAAAAEMaOeXFTceqsHJ8J1L4eSFM4Bo3GRYF60uQOE/QSw+BaepXBDPInkkYrr/MnYqtn+g==", "20348b17-644b-441c-8b9c-7444d6402e23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5831c2f4-3287-4d02-b467-7ccdeb5702a8", null, "AQAAAAIAAYagAAAAEM9VOsKIRLgQV/kR1Bq7a5Ksrr1QqM0VWBGKzAHF7/Irt4TIx/IfwepXEIY2fUMIFQ==", "e123686d-6041-412c-a857-e8eee6cce36d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c23eabba-8564-408d-8936-7d84615bf337", null, "AQAAAAIAAYagAAAAEKH6TS9BA/YoC6Gm8KpcUqWpOa0ERmwZOTiosylRJh+3sYvYpJ4ewjZoIDW+PAia7w==", "9055c1ab-8b37-4f0b-9a92-26a03a0ae4a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6dae05b-8fc3-47df-b250-7fa8d9fc44b7", null, "AQAAAAIAAYagAAAAEHpCtivRE5ytlNH8gq9Kryqejyurqm7BTu4lFTBFeJgdfn8g/Rhkeo9QhmZEY6gsdg==", "cbda1346-0856-4e6b-875d-b3af14348773" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97daf662-fa3d-48ce-aa2d-3d7f0d0d3350", null, "AQAAAAIAAYagAAAAEMaIp56kyP47RKyPI7kBVPXa2Zfgy0r6qhBiUc6hbjw9VA7ImpqUbxVj2INB88zi8w==", "d4e08d8f-2f30-47c5-b184-668e8549c9ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bac67619-3f91-4e5b-ac33-fbdc8570ca2b", null, "AQAAAAIAAYagAAAAEJfCeIDelwjsm+L6hLVbQmxxohTwV5TUbaXgEs56bNRDvGJdlGxvtM4tJR9LRRjQ9g==", "2c2aeced-b0cd-42e7-a81d-de3445987eca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a75781a6-e034-40c5-8f1c-94b4e71bd007", null, "AQAAAAIAAYagAAAAEMF0WB2qIgFTv9BAugRjLza2Gm+wyso20MA3zD2/gd6dAFl78OgYn1tgr9y9HlaFtA==", "6f4094c2-6d98-46af-a569-e72ed253f8d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7a5f583-ac3e-4269-9089-397cad26d74f", null, "AQAAAAIAAYagAAAAEIw3PNGz4jAide5+lFDtbfac1HJk/PvTQG/+vHBCNhRU2x/QmrNBUzT2DVSCg1SXKg==", "8c432885-c2f8-43c5-8590-bcec7f0f561d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ee8c25b-2a7c-46ee-bb19-34e53288ec25", null, "AQAAAAIAAYagAAAAEKz3c2PGLatyeVVNaumMQpZkgABs8NO1SdA6QtuIUIJ0ILEHMv/b9aMU+sidnlOg3A==", "732c8871-87c0-4909-853a-8cfa27abc763" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5dd81bd-f981-4cb3-a715-8fd8abb0a995", null, "AQAAAAIAAYagAAAAEORRxTdwDRE7FrcM8jnSitWWaorhIQ6RRKYjc/Bo0mX6G5artyKloei1hlUqbZo9mA==", "06816a31-6e08-4135-b41e-b1ce3947bdcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "479e34dc-f5dc-4185-8368-0c9d2fc9d040", null, "AQAAAAIAAYagAAAAEEk14zi6JIcVwk8N4UPvSQW4djAMs9ky+P52hS7he3sNzCaUT7wWi4pVmLAvI3pdHw==", "8314209d-a2d1-4305-bc2e-675f5dc62527" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fa6b81b-2780-4f1c-8bcf-039e427e863a", null, "AQAAAAIAAYagAAAAEK35D3ipWiFDfQKTDTO4YSN+Z3VeapuG24w00YVeCKhfBHhXiKDgFhZeMBp2x74Hlg==", "343c201c-fcc4-4a91-9609-1a258e9a54ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "521623b6-fb22-47f8-8b60-267620c8dba3", null, "AQAAAAIAAYagAAAAEP4PeAwkTNoWYIVimSVRY115KjPzdapYtWDdbQr06+OGBtcfnSAZgsN/iVUH//fjcA==", "a241c4b6-bfc9-4839-8a28-ffb1bed1c14d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75c872d2-a8db-4247-bcd1-6e7ef4f4da76", null, "AQAAAAIAAYagAAAAECBsSC2bYfhSlj9ovdlLNNqzJfUiDPQku0yfYtOHUyovn8QbyIBcdGjZvNY5VrUDiQ==", "63a40742-5af0-4ce9-96bb-fa1c1a80ef4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36b4aadc-0e4d-47e8-8b3c-07f88ac1821c", null, "AQAAAAIAAYagAAAAEBx0BPgfApUpRYdHKfCpu2fuHo16i9wZSCij337s5NjqEtRAjQUp6wjfLo6cfk8khw==", "087c4f99-5ac7-432b-b7b3-611c8f42dc73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02280bb1-da37-4bd9-a86f-3883c3d2e96e", null, "AQAAAAIAAYagAAAAEGKn5YPgFsOtAWJZUD3wMIATmngChsJzFeFXU6u21cn+sqHMP8FQQjWg7o4kH3qjJQ==", "8b2f6b59-bc1a-4121-9b8f-a8957aea39bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "402f7563-658c-4c6a-9505-e4f16a3e1ef9", null, "AQAAAAIAAYagAAAAEKmYrVFj2SMDC8GpxZeH3jbukTsNjRtSCPfeW3W+Oya8WRKo6zirTOtrLPJHQEWh8g==", "4d6dbaaa-2c42-42ef-a6fe-88c90d273891" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropColumn(
                name: "LastMoodCheckIn",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "ProductEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    Rate = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductEntities", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 11, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 12, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 11, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 13, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 12, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 14, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 11, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 15, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 16, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 12, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 17, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 14, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 18, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 13, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 19, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 15, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 16, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 6, 21, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25f7beb4-52e1-4e96-92d5-0bbf27e4d3a3", "AQAAAAIAAYagAAAAEEZa4vmLjhAc8fXG5Mz7LdC+SO9q82Cce5sWCC8dij6M4Y4SYtkTTqsqvGymYanE+A==", "7d8b5cc1-bfff-4df9-8019-dac49e469e54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c73a7d68-0e7d-458c-be7a-b50016820c4c", "AQAAAAIAAYagAAAAEDL8T6ca94nmgTuaRyaDALCjznU7x2K+l9M+nY/Z43RsJQvZJeZ+nQop1u6nCmRO/g==", "c4ca2b4f-9184-4d14-9930-df460af7a753" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4629b5a-9881-4cdb-b18d-0f982d98aa47", "AQAAAAIAAYagAAAAEFZaRvnGj202W1d/zY4/Qr88MWAoFPGKLrTIZo9/Y+J44jc1FJOoxdBBdQa8LudUSQ==", "584ea6ca-803b-4495-ae72-e16b66bd4862" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7adf9cf-694c-4f68-ae2f-afbfabcfd76b", "AQAAAAIAAYagAAAAEDf71uR+ZmrJizkP1rBp2o4mxwWjvv6IApecfxu3VoG/CjBwYRiJ1zSm+TaZVVWHVg==", "9a6d0b03-0f9e-4198-a1dc-38221549a189" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfcd270d-2411-49cd-b5b6-ec39e28b4ad5", "AQAAAAIAAYagAAAAEMtwOkMmNS9E5YaGfmLsIo90T8I+smOTq2KIR99v9Jn+tMu0xB207am0SvzHcgDTIA==", "19587d42-9df7-4ff7-a572-fd67bec2c1c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02126ee0-8972-445b-87b9-4aa4f0927586", "AQAAAAIAAYagAAAAEDboKd+edGE8bL3GGrg4G/dCTs8RRknOE+f/TSpjx/zxHvU4iWQ5KSGZdAMUgH7A/Q==", "71bab9bf-0a1d-4c45-bfea-1acff24c0f53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3b01956-ce0f-412b-b027-ebd7d35319a2", "AQAAAAIAAYagAAAAEFciPYq1NJcug9Z3H7YJLsseHCKFS3wpT59FR8McAjMorvvTXkRq9cBI1eH5WsfcJA==", "62cb9bf2-89f7-4d31-b1b1-256d9e02f40a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b7ffe42-479c-438b-93ad-87aa7405ba15", "AQAAAAIAAYagAAAAEEYPE+REyJUvIpd5oGLiL1h52I1gDYlH5hd5TEa9zbmyI5vNhN9gY0CTmiUCNyM3uw==", "f2d83c32-ac51-4c0f-8624-a065c9f9e09e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "787fab5a-b157-4d2d-8dc2-857762d958ed", "AQAAAAIAAYagAAAAEDf/opbUjLr9SQ9fKOAOtiu2gg3guL1topD2igdEmt4YqjGD0MkFuVIPCqBDu+/EWg==", "d8ae8644-dcd7-4efa-8a50-1d05feb761f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ca94306-cf5a-4cf0-a07d-7828c5f8d8c1", "AQAAAAIAAYagAAAAEGqOd3/22FFSnzN0IP2mrWEjyIEznkpMHB8O5Kdd8y1EJnW8uD/VuqN5ybah1YdsUg==", "ea0ae00e-eb2d-4a61-ac83-b0514f5523c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a712e0e4-8770-4ce8-9fcd-c6a4540d3118", "AQAAAAIAAYagAAAAEO6dKiaEbMf0sb4c4dHNHT9nNDuRvPh0E66u2c2j6x0bs8zZQMCk7CubL6xYJkNBog==", "a80c921b-22e0-4282-84c7-ef8d5378a30a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7902a04-fb69-44ad-9cfb-2e956f859dbe", "AQAAAAIAAYagAAAAEDnVwhkufzss8QF1lgrVV8BDxipxVosgeWcKu9o6aP3BHt79rRWTNT1JQdgBTjj5rg==", "99f81f13-c28b-49f1-a864-05e680f7b9b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d858c77a-2bc4-448d-84f7-07ee40398ffd", "AQAAAAIAAYagAAAAEGYYHvWvQ94BjJL8tZJrvhijsvH1NQuPrAGiuaJPgqMu9vkzIQVMG4FKHdMy7+0ULg==", "5a2dc4ac-0b9b-418f-a47a-6d64bf1f257a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebec60a6-e493-4d06-982a-270c16ea85d1", "AQAAAAIAAYagAAAAEMeuRIgyN+ApIG/BT7iYEE0bVWGxHG8H+hia3raVpeSmZJIzIw38d+LzKqYH/UphrA==", "67805fcd-2791-476e-943c-a425c2870f74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f007868-61db-4bc9-97c2-42d91b6752de", "AQAAAAIAAYagAAAAENz+whnDds0OaO26HihawJRMsoYN8qYW+qqJeOx3viBZQmhhTELrICeiJM0/ABVpew==", "8a363305-7a9c-49da-8215-ee6dafde7f65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f69f9391-c291-4ec1-bf4b-4a2f17ca4633", "AQAAAAIAAYagAAAAEBicOjCjf0Q2gSVB1rrwkoetJ05Xd03iguD+wyU/wBX/ZndEOBDyLHBh5q+U+iTceg==", "059dcd61-723c-474a-a5cf-b988272dcb29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dce8cfff-0a0e-465f-880e-cf67f066b283", "AQAAAAIAAYagAAAAEF+CmMYBAst/KIg29n6Hc2lcEtJmtB8mBqHClpaWgtazv7EcxitIfY2oxAYNe1OgYQ==", "16ac0659-7039-4941-b152-4137c9e3ece0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3319cb6-4db0-47c2-a1b0-7c6d0fc90b90", "AQAAAAIAAYagAAAAEOGlnCr11OoC2LoRkXTgCS5amT2CbMP2qARj/+4GyjvYvD+r5+nfhD3WdMPoLfcbhQ==", "8b5bef60-d1f4-4131-b302-cc3d1dcc1c3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1038812-c620-45e1-b1b1-0568f67900e2", "AQAAAAIAAYagAAAAEFnFJRM9TmHYcndPaLh0XU/OOG2qm0wJlgxZgtr8T446oIGgVfqMgX7Hs2R647lXxA==", "3a95f4e4-f0b0-42fd-93d5-ee9cb51674d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05c6c849-da63-47e5-91f1-d19de7ec6125", "AQAAAAIAAYagAAAAEM5dy5dIpRGuWzv4ZYaKF/p7nI/rWgK/oR07+Zv3KPhAp6t3XOaPrubiExWU0nMmKQ==", "296e4c2a-0fcb-4e72-834d-5ced59a2d896" });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
