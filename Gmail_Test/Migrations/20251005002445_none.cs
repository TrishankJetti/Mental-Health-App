using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class none : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cfd2768-3297-48af-a4a3-a1d47578698d", "AQAAAAIAAYagAAAAEK2dvVnFwY1c7XZgHG7g0oAppKnIRnn7z+qzmtGfM/ggxa0X+QcBjLgEmxxfjdJqiQ==", "e6abc78d-8a45-4e72-a6a3-27c2506c9601" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c16c07a0-fac8-4a80-b5db-f467b6829a1c", "AQAAAAIAAYagAAAAEFRrQd5Z+82GrvtNL2wdSDyY7e2KjfyCVqSK/gAd4oB1Xu3claZNmQfRuObFeZutJw==", "026d76ca-2ff8-40fb-8eb3-79b1bb588b80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88761cad-2c5a-43b4-a97a-9bf6793f8cd0", "AQAAAAIAAYagAAAAEFWp6ljtAjc9hqocQm/KwmUOxnAtGcDZC8DlEe0Ly9VLRyeIREmfAcVSaHluwvhE5g==", "ad911836-b7cd-41c1-9e81-ac620aeb295b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2eeb5b8-354b-452b-9c03-8389704c054a", "AQAAAAIAAYagAAAAELYCmGvpnhHxbCPPIQzkbCn9a0rMtIh7KBtk8R40ngY0jii03surq2OCZMlzMMyjag==", "e919aaef-a785-4a26-88c6-47f53285c28c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be84f680-6112-45c0-9d25-d2752ca28baf", "AQAAAAIAAYagAAAAEGS6n65QGFUxDGxV90puihDxpm2pFnUdZdprqLaRojUrpbNhxV13EFL173agvf3vTQ==", "534659fd-40ef-4db3-b68f-0f1a2bcc98d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5802ec6-c06d-4c3a-8a12-3cb13805cffe", "AQAAAAIAAYagAAAAEM1OnM2r6WpHwo7ExpTCaKZVwORCtfzfpcBxvhnZ4Qwnm8nVMH+SVS7bgqAUSVq46A==", "666c8248-13ba-4e2a-b8aa-14b713be92f0" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b32fbd09-bb2c-4b90-8b4c-8ce0b06f3cd2", "AQAAAAIAAYagAAAAEGdth/TjeOW8bfC02Mg63QAssQoSR8hGawR7GT+I6wGJkOy5Tn5xn7HGieOcVOOeJw==", "301b9383-3e13-4327-975b-87f84cb97426" });

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
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 5, 1, 31, 34, 146, DateTimeKind.Local).AddTicks(7117));

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
    }
}
