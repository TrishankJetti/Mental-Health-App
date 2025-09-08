using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class ChatroomImprovement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "686cd2a2-4de2-446d-9b68-43080bd9bbec", "AQAAAAIAAYagAAAAEIQTO8UpUKlYPBxjRkIfDNgwBfYrxIjN2EEe6zan4+Cjtp+BKRgoSQZc3JUm4Br/Kg==", "11323e7c-2cb3-45a3-ac21-69fbde43dfe2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42071172-e2bf-4e27-86ef-9afa4b5ad611", "AQAAAAIAAYagAAAAEAhVX6d9GF730c3A427sQK+u9PLt1hjzAQNS7LynbGyHqbrIsIUmmaRf1cRzFJZiAw==", "d83e6eff-efd4-486d-934f-2123a39c728d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "765b1343-13e8-4f8b-89ae-089c402beaec", "AQAAAAIAAYagAAAAEH1SUcgLwCZVQrsMTAGX+6IqQMTAVuVVLl0+r6vVN2QuxKUeGJbIGVnXtcJxfxjXfA==", "0e3d82a3-afc1-4f42-827e-8b4efbe47cd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f0886fd-07c9-4942-9e75-691a481eb813", "AQAAAAIAAYagAAAAEG+ngfyWPQDzpCQT/2CzA0HNdMuFJzXmTcUb9jVhEeAnj5cSSDMSHaGti0IFaErwxw==", "098f1fc5-a276-4764-afdd-beb9d1ad3de2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd1ff095-db04-4209-956f-395831a49ee8", "AQAAAAIAAYagAAAAELQOteIr35iyTChRksqB6Q73nU0/hlW15sIfhk8M5AQergXu1A8t/Ce9fzJs/db7Iw==", "c12788b6-bed1-482b-8c09-9942b68c072a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be2b64f6-3556-4e28-bbdd-731003276231", "AQAAAAIAAYagAAAAEJrvbseNUihXX1mzrs8AqoNgxP2asRAD03oRN1pwxh6aU4NCNCxLnx1L+X0WCxNqtg==", "82a23ca4-e858-40e1-9d50-6c1b6b25b0fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12e89560-5f72-4c4a-b975-e65e255fb3c7", "AQAAAAIAAYagAAAAEC4AY0AW1eHVcpBIEkboOpd6bZyFsQpQUSQSPE4vhTzxPYV/s+xtor8UeHDhOKuV4w==", "e6617ed3-27cb-4d09-8021-6640815a1970" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ff26990-06fe-4164-a328-5731414865ed", "AQAAAAIAAYagAAAAEGSi1HPasAVjL+jziO6mSa5BokfGQUbaV/+ESJpjJUwHosgiDEvCE64HXIRClCW1Ew==", "e905011e-461d-40e5-9f18-a6e0461e58d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c145d1c-c5c6-4135-8774-a0029ace9771", "AQAAAAIAAYagAAAAEJveho3FKa8ZcdDVQhHkgm2iDooLWKiVSuVtyEh/Pr1eo4KdOjS8NN2JGQsPYUPUEg==", "04851771-e50b-4bae-be00-aa43dfc735e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5238dbfb-4aa0-46d9-803e-d6956bf84dee", "AQAAAAIAAYagAAAAELK9FHX2P6NRyqn56G3Cp6B6hmWEhXcgXG1Hk20Tm8QxAVtWsAjciUlYGdSR6gXWJg==", "5d3af32b-2ae4-4078-9206-aeab63ed3f6d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YouTubeId = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0797e09-d0c0-43d4-9b8a-d33bee81ff7c", "AQAAAAIAAYagAAAAEAUrbw0oNssYlD6wSHg4bgUZDIoLckvk8PuyFE3WwrgjJHvmFKQX4vDlEE74hUY0KA==", "52f19ca6-430a-4502-aad8-56a5d1ef6983" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf4dbed7-7b7f-46ab-81c2-5b7528e0352e", "AQAAAAIAAYagAAAAEE5QGggXK415wIBhgjx16dfvoh7ntkY2ES4UX8M4GiwYBHReQFPSRZhjOJAhutGIyg==", "bf4703fc-29f3-4ed9-9c59-51c4e20f4ec1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28cb78e2-e477-4c29-9c66-3b768af88e38", "AQAAAAIAAYagAAAAEFdM47PnjY2PyG9DwBSJ52qZXk+JYLC+/+LXj3QKZu4ZOSaKm+zKQyqpqjun9RAGng==", "7c7ffa76-86e9-4666-bb3b-f357a1868de2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21543b55-b50e-4ef0-847e-4311e51fe868", "AQAAAAIAAYagAAAAEEMDqfqgcmVCWQFpGtP+Przz9wK7m2XbtJPS9g+e+mW3ybolQwOhrGRyo6VT7U7QKQ==", "b4600905-aeb8-41b3-ae0d-21f5699d2795" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b415751-09e5-405c-b9f7-5f97b96f401b", "AQAAAAIAAYagAAAAEPgFEII7xfGW9btTzF9RXaALyn6OOEr27VK6GVlP+h243Eg6iKA4ekxSr3/WkIdNZA==", "00bbfffb-71e7-4278-b8ba-d029efae2744" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1538224f-aeb7-480f-b6e7-ee10f1e77684", "AQAAAAIAAYagAAAAEIVHYcnnTllFNeSHAc6UnM6/eDXG/vZTM2lzZhcf/D2q/mYtbeWfIo3tIOV74GBtAA==", "89abe5d1-01fd-47ff-a534-e53c50aba30d" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86ba91b7-1a03-42db-9509-28a7bd11d82a", "AQAAAAIAAYagAAAAEOFYG0TFe+HicJ5Vmde6i1PHrtgzTgILAI90LUGaAOJnZf+t5Kehx35d4/mNWLqIgg==", "faa66c9b-07e9-43bc-9b6a-bdf02dcf658d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a513d6c-e1f8-4d79-abd3-efe5187ba209", "AQAAAAIAAYagAAAAELVi/KFvbxfZprFuBf0R7G8BbaqpCUxmNHo3ExnFwlS5Ky1hGwBTDImLSPemmVHtHA==", "4c949c05-db01-4d08-9621-7dbfafc88a39" });

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
    }
}
