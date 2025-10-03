using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class SeededPlannings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "PlannerEvents",
                columns: new[] { "Id", "CreatedAt", "Description", "EndTime", "EventType", "IsCompleted", "Priority", "StartTime", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1698), "Jog in the park for 30 minutes", new DateTime(2025, 10, 3, 6, 30, 0, 0, DateTimeKind.Local), 4, false, 1, new DateTime(2025, 10, 3, 6, 0, 0, 0, DateTimeKind.Local), "Morning Jog", null, "14" },
                    { 2, new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1704), "Weekly online therapy", new DateTime(2025, 10, 4, 15, 0, 0, 0, DateTimeKind.Local), 5, false, 2, new DateTime(2025, 10, 4, 14, 0, 0, 0, DateTimeKind.Local), "Therapy Session", null, "14" },
                    { 3, new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1710), "Project planning meeting", new DateTime(2025, 10, 3, 11, 0, 0, 0, DateTimeKind.Local), 3, false, 2, new DateTime(2025, 10, 3, 10, 0, 0, 0, DateTimeKind.Local), "Work Meeting", null, "15" },
                    { 4, new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1716), "Walk around neighborhood", new DateTime(2025, 10, 3, 18, 45, 0, 0, DateTimeKind.Local), 5, false, 0, new DateTime(2025, 10, 3, 18, 0, 0, 0, DateTimeKind.Local), "Evening Walk", null, "15" },
                    { 5, new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1722), "Read for 1 hour before bed", new DateTime(2025, 10, 4, 21, 0, 0, 0, DateTimeKind.Local), 7, false, 0, new DateTime(2025, 10, 4, 20, 0, 0, 0, DateTimeKind.Local), "Read a Book", null, "16" },
                    { 6, new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1728), "Strength training", new DateTime(2025, 10, 3, 8, 0, 0, 0, DateTimeKind.Local), 5, false, 1, new DateTime(2025, 10, 3, 7, 0, 0, 0, DateTimeKind.Local), "Gym Session", null, "17" },
                    { 7, new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1736), "Morning meditation", new DateTime(2025, 10, 3, 7, 0, 0, 0, DateTimeKind.Local), 4, false, 1, new DateTime(2025, 10, 3, 6, 30, 0, 0, DateTimeKind.Local), "Meditation", null, "18" },
                    { 8, new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1742), "Routine check-up", new DateTime(2025, 10, 5, 10, 0, 0, 0, DateTimeKind.Local), 5, false, 2, new DateTime(2025, 10, 5, 9, 0, 0, 0, DateTimeKind.Local), "Doctor Appointment", null, "19" },
                    { 9, new DateTime(2025, 10, 3, 17, 46, 32, 648, DateTimeKind.Local).AddTicks(1748), "Work on homework", new DateTime(2025, 10, 3, 18, 0, 0, 0, DateTimeKind.Local), 0, false, 1, new DateTime(2025, 10, 3, 16, 0, 0, 0, DateTimeKind.Local), "Study Session", null, "20" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PlannerEvents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cbdee09-1527-4f70-84c4-00a5fa33b3e1", "AQAAAAIAAYagAAAAEMo3pzzbqbBrARNvd9hCrDmtcSI7Z5exczC750DzvIXx5z1vUKXu9y1Ct6IL6AbKyw==", "1ca4e25d-d499-4902-a5dc-f130522b2c6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7afc043d-4f87-449a-bf8b-70ddac4e9dc1", "AQAAAAIAAYagAAAAEDx66lx3EA20WhlgMZhDLg2Vo6sRGmu4zrM1oxVQdXjU3/oCjhE9RJTHI8zaWVtNpg==", "5952202c-cfb6-4c98-aa0c-ade74672ab03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e18850b-1a21-4e9d-82fe-2b7823c65efa", "AQAAAAIAAYagAAAAENUSBGoZTE8J4gBAVw4w5Aim51BEk5sWnGc4UHKDYAmml+g9+zlnEa7KFVyXVPsnzg==", "24240812-0d15-45f7-8c9f-2d7c54ef2aff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da7c201a-636b-42e3-996c-ed1738a4aff9", "AQAAAAIAAYagAAAAEORAcHNvTAJoHkZSNCaU7XkZ0wPNjuF1NQlfIF/MEqm7CsTWL1yGqE1IOei3zmuStw==", "b26a2134-0979-4ae6-b3bc-8f6aca786cbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91be1e0a-e5dc-4e7b-a3c4-057729ef3c44", "AQAAAAIAAYagAAAAEALhXF3gWFzPiZTQyoMl3Z5yhVy6dkxCy3z2XjErwpwKKTCgwgOy0XmDRVbnk9dySg==", "b2f6be4a-c15b-4467-b2dd-c0dd36dda1bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43ea1a1a-b105-4173-947c-a18dc968d434", "AQAAAAIAAYagAAAAEIzbn9lnN/UfSXi3cB6wCbsVQG15VzRMzH2GJXQ2yO+IIn90Nyp4tj/fFOKNseEtFA==", "5ce2fd12-83bf-4ada-a2ee-14ba8a7c0f43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "322842e9-461d-42b8-acb1-2db99c1fdd60", "AQAAAAIAAYagAAAAEC7wOz3CTmywx/GrHkwHEsOy3O17DA3n8hAAPROAvNfSmtjJTIRh6Fw1PCX7vTc0dA==", "79cde222-1b16-4492-bb5c-5e8a369007b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b568e0c9-9294-4fbd-8e3f-2a6baf4d194d", "AQAAAAIAAYagAAAAEBBPodot6NlzZ8k8i8jFW2WiJtFusF9Y99EnytAjhH61Ph5/ze/V9xT96akzSRe1zg==", "dc32535e-2448-447b-a6f9-698ef2bb47ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "470a9db7-8fa6-453a-9cba-5741bce3a0ac", "AQAAAAIAAYagAAAAEHq0cfA4XqQx5NupZDuR/h59oX74WZlT2LkuakEWL98xgBFHiubL6b/+lDTcf2GSJw==", "54b3b290-fc34-4a23-b920-2dc5983ace85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d79ee28-e308-4186-99d2-f80150d7224b", "AQAAAAIAAYagAAAAEIlOCpgFU03pCQUQh0hPTQlfm15oWsYTu4WBXQSepAx0DDk2czgQWpJ0aCraYVT06Q==", "7fec26a8-9146-4c68-973d-b5b7133c82d8" });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 23, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5369), new DateTime(2025, 9, 24, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 25, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5397), new DateTime(2025, 9, 26, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 28, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5404), new DateTime(2025, 9, 29, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 21, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5411), new DateTime(2025, 9, 22, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 18, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5422), new DateTime(2025, 9, 19, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 26, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5430), new DateTime(2025, 9, 27, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 24, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5436), new DateTime(2025, 9, 25, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 22, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5443), new DateTime(2025, 9, 23, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RespondedAt" },
                values: new object[] { new DateTime(2025, 9, 27, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5450), new DateTime(2025, 9, 28, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 16, 47, 37, 689, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2025, 10, 1, 18, 47, 37, 689, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 2, 47, 37, 689, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 4, 47, 37, 689, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SentAt",
                value: new DateTime(2025, 9, 30, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SentAt",
                value: new DateTime(2025, 9, 30, 16, 47, 37, 689, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SentAt",
                value: new DateTime(2025, 10, 2, 16, 47, 37, 689, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 2, 47, 37, 689, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 8, 47, 37, 689, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 11, 47, 37, 689, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SentAt",
                value: new DateTime(2025, 10, 3, 13, 47, 37, 689, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 2, 47, 37, 689, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 8, 47, 37, 689, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 3, 13, 47, 37, 689, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 27, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 19, 14, 47, 37, 689, DateTimeKind.Local).AddTicks(5317));
        }
    }
}
