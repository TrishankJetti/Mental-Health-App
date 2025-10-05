using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class nullableField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PlannerEvents",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8853f5e0-c4bc-48f5-bafc-d5d9eda66396", "AQAAAAIAAYagAAAAEOU6qdOgDRcsuEoQRs2+P5U9gqF3ls8icNF05vmvV79nZtjbbIObuI6uQ5zdrrWnyQ==", "a492cc69-11fe-4e63-9048-71c9c3c87ae1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "245fdad3-53c9-4689-8d68-f0eaaa92f334", "AQAAAAIAAYagAAAAEKX1xJXmulNskaBSaHERwbPkoAzHRNdvmErRPdUQM3Qd2uXmrsgg2BFRKxcHZMvjgg==", "6b26301a-3fea-4e19-93fd-3a02c8f17c7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5a6250b-9108-4331-be99-34dfc5860b60", "AQAAAAIAAYagAAAAEGVm84AX77vYEqwrYHKpAuLANP8EqtrRKxzLt0us4SVmB2pACk5rxGUtnFmIb1RWlQ==", "6103530a-8883-4f41-a21c-b9e2aa5b26ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb7209c7-8e45-447e-bf4b-cdb1ff6b7ca4", "AQAAAAIAAYagAAAAEPJJ2qFvNjYdBEpoD9lS8DogNbHRSfPbbioecDM9oQgT1Cb4m80Tq363/3MVGTxPug==", "ffd72cb7-ba34-4897-abb8-39d084b6c264" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "956f79d4-2152-437b-be3c-0488251a84f0", "AQAAAAIAAYagAAAAEH9XrRG5nrimUnJPCS5urph0fFfEJ0BvyU0F9c1NZ/O3EKKnUibv6tQF1ELaxrlJsg==", "7306b538-13fc-4efd-a052-6e595098540a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04971103-2f35-4df4-88aa-566b86877fdc", "AQAAAAIAAYagAAAAELdrrAaPKB72FBAeUApReG1+mvN/t47/wABkOfaO8itt4WB2LzJjWZTcebqPLuHr2g==", "6f80f616-a69a-40b8-90b4-d6f197bde5ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43ec1e15-6250-4c1d-b61a-b78b2cbecd0e", "AQAAAAIAAYagAAAAEAJKXmQ5r8OjrO5Ys0z7HX4sjd9Uwt1iBdvMZ7VFiIRqG5cyDETp3aunasrC0/dCjg==", "b367c491-b1b0-404c-a2d4-a24d51f24844" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "386c384e-23df-4845-b8f1-e63c89e6b9e2", "AQAAAAIAAYagAAAAEOAuQ/wzO++AWGdJP5dglT/u7hWOU5iubrjLrSboboIMiudCfYzFhi11J2cRJChYPA==", "59a718d9-e12c-412b-a16e-a280fb0fb187" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "191fe6ef-7254-40a4-abb9-cb741d117adb", "AQAAAAIAAYagAAAAENjBJAWK6+zUErYqPlXNFbsg6RPJ3uJi75i7VPTAHATlcNqFtOmAhDXAfE8QiqwlsA==", "48dd14d5-5cc7-41fd-b7d9-7c77ba77e8ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d830571-9f6d-4df4-afc4-b021abb13338", "AQAAAAIAAYagAAAAEFu5AEHV37qkNZAMkcXbLZO1Fye6x3tm2xWZPCFjxPeD7SS1TZxhY8bC6FMNRDgIVA==", "284b0fc6-16d6-4a9e-adc7-002fc206dce4" });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 23, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3102), new DateTime(2025, 9, 24, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 25, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3153), new DateTime(2025, 9, 26, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 28, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3157), new DateTime(2025, 9, 29, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 21, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3162), new DateTime(2025, 9, 22, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 18, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3169), new DateTime(2025, 9, 19, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 26, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3173), new DateTime(2025, 9, 27, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 24, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3177), new DateTime(2025, 9, 25, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 22, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3181), new DateTime(2025, 9, 23, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 27, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3185), new DateTime(2025, 9, 28, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 1, 35, 15, 702, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 3, 35, 15, 702, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 11, 35, 15, 702, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 13, 35, 15, 702, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SentAt",
                value: new DateTime(2025, 9, 30, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 1, 35, 15, 702, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 1, 35, 15, 702, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 11, 35, 15, 702, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 17, 35, 15, 702, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 20, 35, 15, 702, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 22, 35, 15, 702, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 11, 35, 15, 702, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 17, 35, 15, 702, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 22, 35, 15, 702, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 27, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 19, 23, 35, 15, 702, DateTimeKind.Local).AddTicks(2989));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PlannerEvents",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2eee3cc2-f539-45fa-80d9-800e9a8fd33a", "AQAAAAIAAYagAAAAEGLzWYS/x9ZJyYvfzQl6XalaztVhEq2vA9Kx17Q9zbgHOAAdpDV5eQpVwiq+jP7Kgg==", "681303a1-de96-4aa1-bbde-52de884aedbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea175beb-4288-4c40-9a58-aefee8fec09d", "AQAAAAIAAYagAAAAELFcRQ0M80KhDRewBBPhJ7zvSLStYqmrcU8SGDfQFg6ML5o4aQ1AYxFtvIN+9VHJlQ==", "71708d2a-8cb5-4ddf-8bab-e93c98c8a885" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d63cedca-7bcd-4ce3-b5b7-2718ba5b5b1d", "AQAAAAIAAYagAAAAEMgYvQtmHVKYkSRRaVFxthDiKZHBcD4X64MAWKlT/9r0+bGJjpH9Avx1AhzURPiRyw==", "e755af66-cdbd-41ac-b7a5-1cc3a23aca88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57a9bf75-b45f-4f0a-84ef-9b341b72b4f7", "AQAAAAIAAYagAAAAEClSUbiLZxOrhZd4DvpPaLtW5fyA9IfEofpqGo9uodiBwzKyIvUBWHRii33XwlUN1Q==", "5d0742b7-4d9c-426e-b7eb-eb4f1d28efbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1665910b-83ba-400f-b9b7-488745b9fdb0", "AQAAAAIAAYagAAAAENTits5NY/w6LQaZAAwZ6VwnilkzhsQOltpoONMxpdvJ37n8YfHlMMIHaLvYZqER9g==", "eac97c17-32b4-49d3-a9a3-85051ec4d901" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38a4bcc8-4412-4766-8a37-5c33e4c6a107", "AQAAAAIAAYagAAAAECNABAvc0w/gaj39PCK4ydGkSsi2DuhrBEyyYjNHQIHnRBU2RtMWhELVhkuUeZ+Q5g==", "539e534d-276f-4f53-82bd-55568994ef4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e954df5-08ad-4126-8d57-f2980da0a74a", "AQAAAAIAAYagAAAAENhUXzmY6/gGQIVJMCtkqmg4ksanfSr5QpSr+FeLqVbaPNQAS4A4gNP34R3XzArqVg==", "724441da-5436-4e54-bc1b-e8fa6ca1ea5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "312b4bfa-ff6b-4707-a6ab-0aaab1d06e9d", "AQAAAAIAAYagAAAAEIH4j1xVRV9riC0yKjr3fNDMhgw+6ICTOrSf0t0Yehd5hhj/c12xcthdiL1dVAtDaw==", "4ddca804-eedd-497b-bc49-2b1e07efea4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f318088d-99f7-4052-9906-56943a1624bd", "AQAAAAIAAYagAAAAECsGoU+lZ7pJrj09e9uuPdPTe20ezZseQ6njpnVt3xPBQgg9Y6/fzy3p1HzNjGHVWg==", "a1c049d2-294b-4575-8071-0a499b2af522" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4bc47e3-20fe-471b-be4a-3c5fe1fb9cbd", "AQAAAAIAAYagAAAAEH2V+YKXwiaTscX0OTYE1pF8hhQvLeBDHxuJ+WWcd8QjjKZDsoPOCx1Shxr4eDqkGA==", "a649f065-bcef-40e1-bbfa-2ca199fedd5b" });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 23, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1381), new DateTime(2025, 9, 24, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 25, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1430), new DateTime(2025, 9, 26, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 28, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1434), new DateTime(2025, 9, 29, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 21, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1438), new DateTime(2025, 9, 22, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 18, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1445), new DateTime(2025, 9, 19, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 26, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1449), new DateTime(2025, 9, 27, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 24, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1453), new DateTime(2025, 9, 25, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 22, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1458), new DateTime(2025, 9, 23, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 27, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1462), new DateTime(2025, 9, 28, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 19, 46, 32, 648, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 21, 46, 32, 648, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 5, 46, 32, 648, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 7, 46, 32, 648, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SentAt",
                value: new DateTime(2025, 9, 30, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SentAt",
                value: new DateTime(2025, 9, 30, 19, 46, 32, 648, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 19, 46, 32, 648, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 5, 46, 32, 648, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 11, 46, 32, 648, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 14, 46, 32, 648, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 16, 46, 32, 648, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 5, 46, 32, 648, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 11, 46, 32, 648, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 16, 46, 32, 648, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 27, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 19, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1333));
        }
    }
}
