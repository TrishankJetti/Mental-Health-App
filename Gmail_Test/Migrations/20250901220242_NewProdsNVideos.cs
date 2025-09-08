using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class NewProdsNVideos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YouTubeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c923ec72-c655-459b-86dc-8e72e7449edd", "AQAAAAIAAYagAAAAEFSVEfYzTbbFYLwiu1Im371EtsHQaQO+MsmWnxicXvCEzbzpO4YpP4/x+SUpXDiraw==", "ca38092f-c86c-40ad-b473-98649ead29f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0797e09-d0c0-43d4-9b8a-d33bee81ff7c", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEAUrbw0oNssYlD6wSHg4bgUZDIoLckvk8PuyFE3WwrgjJHvmFKQX4vDlEE74hUY0KA==", "52f19ca6-430a-4502-aad8-56a5d1ef6983" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf4dbed7-7b7f-46ab-81c2-5b7528e0352e", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEE5QGggXK415wIBhgjx16dfvoh7ntkY2ES4UX8M4GiwYBHReQFPSRZhjOJAhutGIyg==", "bf4703fc-29f3-4ed9-9c59-51c4e20f4ec1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28cb78e2-e477-4c29-9c66-3b768af88e38", new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEFdM47PnjY2PyG9DwBSJ52qZXk+JYLC+/+LXj3QKZu4ZOSaKm+zKQyqpqjun9RAGng==", "7c7ffa76-86e9-4666-bb3b-f357a1868de2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21543b55-b50e-4ef0-847e-4311e51fe868", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEEMDqfqgcmVCWQFpGtP+Przz9wK7m2XbtJPS9g+e+mW3ybolQwOhrGRyo6VT7U7QKQ==", "b4600905-aeb8-41b3-ae0d-21f5699d2795" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b415751-09e5-405c-b9f7-5f97b96f401b", new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEPgFEII7xfGW9btTzF9RXaALyn6OOEr27VK6GVlP+h243Eg6iKA4ekxSr3/WkIdNZA==", "00bbfffb-71e7-4278-b8ba-d029efae2744" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1538224f-aeb7-480f-b6e7-ee10f1e77684", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEIVHYcnnTllFNeSHAc6UnM6/eDXG/vZTM2lzZhcf/D2q/mYtbeWfIo3tIOV74GBtAA==", "89abe5d1-01fd-47ff-a534-e53c50aba30d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05253a43-72fd-48af-b433-5c0bde52912a", "AQAAAAIAAYagAAAAEPNdkZw0UmO5lxkQbTxYCHuYKli8QTuT6+XLYLCUoSVt/bYuWw8UxWPxqjnOw3p/pQ==", "f361f519-719d-4728-9fb2-8431c90df8de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86ba91b7-1a03-42db-9509-28a7bd11d82a", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEOFYG0TFe+HicJ5Vmde6i1PHrtgzTgILAI90LUGaAOJnZf+t5Kehx35d4/mNWLqIgg==", "faa66c9b-07e9-43bc-9b6a-bdf02dcf658d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a513d6c-e1f8-4d79-abd3-efe5187ba209", "AQAAAAIAAYagAAAAELVi/KFvbxfZprFuBf0R7G8BbaqpCUxmNHo3ExnFwlS5Ky1hGwBTDImLSPemmVHtHA==", "4c949c05-db01-4d08-9621-7dbfafc88a39" });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "IsPrivate", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 6, "Want to support our cause but rock some swag? This is the perfect  choice for you!", "/img/ShantiShirtMerch.png", false, "Shanti Black Tee", 25m },
                    { 2, 6, "Get a fun plushy to be your companion! ", "/img/ShantiPlushy.png", false, "Shanti Plushy", 25m },
                    { 3, 1, "A bestselling book with practical tips for mental wellness.", "/img/Wellbook.png", false, "Wellness Book - 'Calm Your Mind'", 15.49m },
                    { 4, 5, "Includes stress balls, aroma oils, and calming teas.", "/img/stresskit.png", false, "Stress Relief Kit", 29.99m }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Category", "Title", "YouTubeId" },
                values: new object[,]
                {
                    { 1, "Mental Health", "5 Signs You're Emotionally Intelligent", "1nZEdqcGVzo" },
                    { 2, "Relationships", "How to Deal with Toxic People", "Q6v6v6v6v6v" },
                    { 3, "Self-Improvement", "Boost Your Self-Esteem", "2Xc9gXyf2G4" },
                    { 4, "Mental Health", "Understanding Anxiety", "Z8v6v6v6v6v" },
                    { 5, "Relationships", "How to Communicate Better", "3JZ_D3ELwOQ" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d43f009-4113-4182-aa18-5d5f36e81ad6", "AQAAAAIAAYagAAAAENT/rRJGRROtL5IVDLKLpDg4BQHs7NSTVyHP/9kBJwEvrfhxoXeDx/27h53CVlDsVw==", "fc727f4e-3843-4058-9e5e-cc96f63b3aac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2df586e-fd0d-466f-acd6-0cdf1858c25e", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEKpoxbq2uy5bzfxfFNL/QYYC12TyAdz2248dH8ef2nC3mUoKAhSX1W+oEJm/X5rIEA==", "cb8f8269-4435-4499-b7ce-afbf8bc49bba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c51a1f2-7087-4e19-ac49-1ce24c459852", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAECp0Om1nYgyIYiKMgvMGw6iCelbNh85lfCe4WkCsdF3bhZvKEW3ZBqqdXwNZui5Pow==", "f64d3f35-49e4-43ef-8fe4-32d790c3547f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ae42a0b-a27a-4c48-9bb7-fd99c990d17b", new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEGaKquRE6voRVuvvD7g8qDOb/iecczUWaQbFKHS6bsLJ10ZPe9pHDLMBvjax83RJKw==", "81e895d6-fa3a-4b72-a3e8-b3ba19c8acc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9448514a-bc69-4106-a222-9c1fd2ba747e", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEEpJn+adxK1pOTl2EUkFUHtnUjD7OBAUZb4yNZgeXxJhTFlUzp5+/g0yy5EjbL36mA==", "19eff93f-335a-4d2d-9a78-498f1020238f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91e22e8c-5ddf-4100-8250-3d8fff9cb8cf", new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEEj0K8Z7PNk5Ie2ORjUF+VNWLqAQi+zCwzIGGmzdZ4qWD7mZMAH/6uLsR6yHOcRokg==", "3e57c57f-baa0-45f6-b552-01591d6f4174" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1b9d824-b5f1-4185-a1ea-10027a38ff9d", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEN2P6InIvKDW0vhQCHco5FuMZ18Tvzl13Mx6A16kR7DHdPDJbeOSo+tlbIDMvB0qjA==", "aa92d3e3-c5e8-4afb-825b-1c764e2df702" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "527df816-51ed-46ab-9f3c-b40acc66083d", "AQAAAAIAAYagAAAAEHvpSrbrV1Sf0JXbi1hpnyOlIbupKDElWmQiigK/lHAY+WAjHpdhCqVxPoJaXV8SCA==", "cc0b92a3-9cd3-46ff-8e32-af092a1b1f40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33b35e7d-a909-42c7-8902-89b2ddf46ffc", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEFSC3Wr0z2cS8SuvgagHzmjFGkSmAZpX2PbfprITYyekQte4UYRtS9RlZvfrH0xFTQ==", "eb4ab92a-0fef-464a-9799-b1b7e043c0c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cfb2521-e065-4a80-82f8-3b1b916741a0", "AQAAAAIAAYagAAAAEFDPpaJSNXcWKczXMiLLr3qrYoXbc/ByTQVeX2ip9Mr4/yRz9rhKODmSfIhHn9RKIg==", "9bbbeed4-94b2-4f23-b33e-64ac4d0c1c05" });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
