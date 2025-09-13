using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class newFieldProd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "231cf735-6651-4d07-b5bb-64783948cb99", "AQAAAAIAAYagAAAAEPLu4quL+8NTnd+cC4/b01rAzY+Xf5FCaXLabPWjAQBvoXFzVVigKdMrZPYoKo4/tQ==", "41821ee8-fb8f-493c-bb95-8aee2e11a2e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b781f914-f1bc-4261-bb6a-7ffd847730f3", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEKEIf8bX+niNYyYbw+DIrsf5VsFPXIJmVJ64xdsoHNnUwO51YbD0JSAqFOFNlTCnbA==", "ccafc45c-bb56-4560-ad71-d0e577a6d1dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95d6e292-ed3d-401f-a321-563edc604354", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEFLR5aubGpmq1uZ/6KOnKx3eis7JbHZwj17NGhI6Z4udKUEGlnpDSSyMj3m3gVOIuA==", "a3cbb3c0-5b58-4353-9b84-a1bb6234ba4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df178306-1ad1-4f67-a0ff-fcc174841e3f", new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAED7lLvsWR0yl/PWwpT74WP9J7rtoA36BWNfqB7O6W2LHzBfooQPzReIaobkgrbS9OA==", "8527bd85-d516-46a5-b741-7a959c2001b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a08e9749-8056-402d-a10e-7d7fe6ce3971", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEB+hdHqIQwVf6TdRqEr86+zYWP6gevsux5qnXo8EX0xvN+cejWuBaA5fgBTRERxoBA==", "1092a297-8ab9-46fd-b1b5-275106d29ee3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bed50fd-f0ba-4c57-bdeb-5b296ddd685b", new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEMRcIcP4nu6S5/Hzr4DUsHmnaPC2At7t6O8I6pzlCu0flQE3pow7zhJkbaQ/gF3dtw==", "60f365db-65c1-4701-96d8-ec10ae20fcf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea9e1a36-e40b-4a5b-9c5a-b63818ad1d21", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAECmhmvU0PC3XTFSP1NH39VKJWta/KhaSOfH9LIJ7IQ0Kh654z07tvTBbTekNiUujAg==", "a340f9ad-6491-4a9c-b97e-4f3398d8e18d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb761c74-92ba-4f12-bf93-692c1f154786", "AQAAAAIAAYagAAAAEE3KxKIGzTFFs2QhaaNs16vVG6Lr2vtInaBY4ic21pdsWPHsfX5cYKIitlBKanA2hQ==", "a37cc513-8310-45b1-83f6-a86d1210c184" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7069c076-6925-4146-9c48-a3bff2a28c5b", new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEPOmCW0reJHghBLmb7ZuVDJzqlF5innvMN9yKhx4XXtulY6TvVF+DG0WmdFJfMurvw==", "b434ea67-fa12-4885-baa0-a0c292202b8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "676a4900-0b3e-48c4-887d-835d246b0b56", "AQAAAAIAAYagAAAAEMestGIi98RZEXqk2z7MrvFFrPx5JeZbY0UuG8XqUejznHspL+t0kkammq1oB2Mhhw==", "01747189-7ac5-4763-accc-ab7dcaa2e4b2" });

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
                columns: new[] { "CreatedAt", "Description", "ImageUrl" },
                values: new object[] { new DateTime(2025, 9, 10, 12, 15, 42, 546, DateTimeKind.Local).AddTicks(6983), "Want to support our cause but rock some swag? This is the perfect choice for you!", "ShantiShirtMerch.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ImageUrl" },
                values: new object[] { new DateTime(2025, 9, 6, 12, 15, 42, 546, DateTimeKind.Local).AddTicks(6987), "Get a fun plushy to be your companion!", "ShantiPlushy.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 15, 42, 546, DateTimeKind.Local).AddTicks(6992), "Wellbook.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2025, 8, 29, 12, 15, 42, 546, DateTimeKind.Local).AddTicks(7003), "default-product.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42071172-e2bf-4e27-86ef-9afa4b5ad611", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEAhVX6d9GF730c3A427sQK+u9PLt1hjzAQNS7LynbGyHqbrIsIUmmaRf1cRzFJZiAw==", "d83e6eff-efd4-486d-934f-2123a39c728d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "765b1343-13e8-4f8b-89ae-089c402beaec", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEH1SUcgLwCZVQrsMTAGX+6IqQMTAVuVVLl0+r6vVN2QuxKUeGJbIGVnXtcJxfxjXfA==", "0e3d82a3-afc1-4f42-827e-8b4efbe47cd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f0886fd-07c9-4942-9e75-691a481eb813", new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEG+ngfyWPQDzpCQT/2CzA0HNdMuFJzXmTcUb9jVhEeAnj5cSSDMSHaGti0IFaErwxw==", "098f1fc5-a276-4764-afdd-beb9d1ad3de2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd1ff095-db04-4209-956f-395831a49ee8", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAELQOteIr35iyTChRksqB6Q73nU0/hlW15sIfhk8M5AQergXu1A8t/Ce9fzJs/db7Iw==", "c12788b6-bed1-482b-8c09-9942b68c072a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be2b64f6-3556-4e28-bbdd-731003276231", new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEJrvbseNUihXX1mzrs8AqoNgxP2asRAD03oRN1pwxh6aU4NCNCxLnx1L+X0WCxNqtg==", "82a23ca4-e858-40e1-9d50-6c1b6b25b0fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12e89560-5f72-4c4a-b975-e65e255fb3c7", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEC4AY0AW1eHVcpBIEkboOpd6bZyFsQpQUSQSPE4vhTzxPYV/s+xtor8UeHDhOKuV4w==", "e6617ed3-27cb-4d09-8021-6640815a1970" });

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
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c145d1c-c5c6-4135-8774-a0029ace9771", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEJveho3FKa8ZcdDVQhHkgm2iDooLWKiVSuVtyEh/Pr1eo4KdOjS8NN2JGQsPYUPUEg==", "04851771-e50b-4bae-be00-aa43dfc735e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5238dbfb-4aa0-46d9-803e-d6956bf84dee", "AQAAAAIAAYagAAAAELK9FHX2P6NRyqn56G3Cp6B6hmWEhXcgXG1Hk20Tm8QxAVtWsAjciUlYGdSR6gXWJg==", "5d3af32b-2ae4-4078-9206-aeab63ed3f6d" });

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Want to support our cause but rock some swag? This is the perfect  choice for you!", "/img/ShantiShirtMerch.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Get a fun plushy to be your companion! ", "/img/ShantiPlushy.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/img/Wellbook.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/img/stresskit.png");
        }
    }
}
