using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class Pfp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkUrl",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "PfpName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 27, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 28, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 27, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 29, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 28, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 27, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 31, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 29, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 1, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 28, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 2, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 30, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 3, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 29, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 4, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 31, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 5, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 1, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 8, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "d08b7e00-1ea2-49bf-8e4b-d5a887061a2c", "AQAAAAIAAYagAAAAEPmonzkPlfjydMSDHlktN9cPjOWDO/Mm6MSe2KOpjNUK/y4/+AlXW75RN5pbbXcm8Q==", null, "37d27963-5dc8-4a85-915d-a49fdcf06190" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "51eeb074-9518-466b-869f-3d169f0cc649", "AQAAAAIAAYagAAAAEKrNCAvX1PWy8zP7o8NHEoi4famcoKEj8lfEVD8L4e37P0DLyVcrnoIjZoQZMUH9DA==", null, "611ad3c8-a9d7-4f26-a50f-d114ba82a3a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "3b80c097-edf2-4123-8c8f-93033f70640d", "AQAAAAIAAYagAAAAEOSERlyDUrSw0p3mZ/+IfjQxq1MiZU0uUo32on38PspOzhjor/PrQnedU4kSIZrqxw==", null, "57ccdf53-d154-4612-b6eb-3bcab1c7f15e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "ca5abf8c-2794-4ca0-92d1-5c1e01ff8846", "AQAAAAIAAYagAAAAEKJkmQYk93+Rc+19rZYBPBmfiwilUYDsHj9mZDMLVuNWNMxmMVNVaDAPM489oLzwtw==", null, "b438e2d6-b448-4898-a0cd-d9c7befc455a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "ffe3c3c8-1b81-4ee0-a439-55fe587877a8", "AQAAAAIAAYagAAAAEPCUci6J+bVyq5KyUdhpnt3WB5lShniRy2+2JORDzX3p6NBcEF62I4y1bWnF2MLPoA==", null, "56b0eadb-2c9f-44f2-a2ab-f53abb7ab2ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "74710891-53a1-4938-9406-845bbbcced82", "AQAAAAIAAYagAAAAEB5qtnFTkPSLICXcpeUaOJClTyMdvYvW7IKIoiFO3sszkgg/ZA8PJdVB8K8DbpePjA==", null, "d64dca66-0e18-4809-ba1b-0df245260706" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "f4e73bb3-8134-42c6-992b-c158b21f66cc", "AQAAAAIAAYagAAAAECVW0iygtcmP0BKCszR3buiGqY0ev0MGuTHt8lQIooHjbUnRbdz6yVPid6g/ktaYoQ==", null, "ee69b49c-7dcd-4f79-9499-906304090abf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "c0ac028b-15af-4bb6-ab23-4aee030552f6", "AQAAAAIAAYagAAAAEPyQLTimkPVtHAw3J0EjUV4JCTcm6Fml81/HX2edPJN7DexMxScVetHKn6zcL+Lt2w==", null, "7e45ca34-f6f8-4edd-831c-065e7afd0d09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "5d909ad0-287d-44fb-89f1-b8d7cd281a9f", "AQAAAAIAAYagAAAAEDX6ha+yMQgVcC37vuRlzw5RJrK98/JhxHIeA4tt1Uy+9adu8rmJ5bLbPF0K0wh0Mg==", null, "16e7ab99-ffc7-4ab7-8a60-4c00e0e29a88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "035e9e80-aaeb-4c37-b2ad-cff5faca0a24", "AQAAAAIAAYagAAAAEDehFNuPOKZGbXTijeT6BFp+Fm/3H7qTxGWJMQAFWJSfJ+E+q/8rqZpiSDU/ZAjpIw==", null, "e71f99ac-3a4d-4c29-b0d8-e28d1406fe58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "e5c1af1a-766a-4f97-af73-75d80131045b", "AQAAAAIAAYagAAAAEK7kXyc2PnsL5PJZ2sOqsWFG1Urv3s8xiGhMn0cww6C5VYty9gfmbtzqWd7ZBPEVfg==", null, "ef126781-4551-4c06-b8c2-43c64c905049" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "3f548b4c-b3e7-419c-b6f5-204d276f1500", "AQAAAAIAAYagAAAAELTXWkK8LgJYmw0aGy9zZROESfhzngQvuyD85/HzKcDQtB8XR1A6RyuqwFWD2Fe/GA==", null, "13844153-79d3-40d2-8496-2d8c871a4bce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "ff1158df-d01c-4aa4-a30f-3ff15e5adfb6", "AQAAAAIAAYagAAAAELNWXTV+YlIAqYYGoXfSIQ6ZKixFBlWiWjxkJ8bX0etzbUC8+OUzegmsbZRmXDONHw==", null, "6ed4a95a-b564-4de7-9d55-5677b6feb700" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "0b01dcc9-e992-401b-b263-bef1a6b8791e", "AQAAAAIAAYagAAAAEB24XePD5wZAdXYaANjQYenaD6R+V8uBLK6jd9bYotm6oK2yH+/NNvXK56riSzK+1w==", null, "ddd6a1c5-43b9-4929-8436-dc071dc3651b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "5ceb7d14-fa7c-4632-8eba-ed79f74a8dc7", "AQAAAAIAAYagAAAAEI/X25nWazicbmkfEIEc+Umq8o4qmaSi0CflL2JNrCkYTHP1uD3WcOdp/PL4xihJqw==", null, "0bbf5f7e-0c65-4d4d-bdc2-f33eb5afce79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "0d95578f-875b-43df-9a04-0cabdeb90ebf", "AQAAAAIAAYagAAAAEHdvFJeKSzCES/n3haPXycajU/GuoVJRAQUE3+iI3K4vGdbL/2cVfe/jc69P8oZv/g==", null, "406381a1-0121-4c7b-b6e2-2017c61b776d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "863abfb6-913b-4da2-9c5c-31c6a9c928e4", "AQAAAAIAAYagAAAAEPAmy78ZOUgdca/wf/cjjk3Eef+3PGikOg8RhNGtJ/BNLvCCejVc3R1lr++ghhxRWw==", null, "aabfd901-3909-49fb-ba52-ad14008d5f98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "35a29d9a-c376-4488-b314-11e041084167", "AQAAAAIAAYagAAAAEK9w9tYVTXhz6pmPRHDAJpcGixgKmZcGkHmTe5Teicx0TKTUxEtHLmAETSgghNwWKg==", null, "bb5ad3f3-60cb-4f17-a297-f4b9130d38ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "e54cbd52-6f58-4bd0-9399-7845847d728b", "AQAAAAIAAYagAAAAEPDh67vMeRkP0GjbTBiuDeoKiAwftlmFKIsKTpAQn9Vx4g2es5kC7EEKDEfS5nDynw==", null, "ea9ebc61-3b21-437c-9024-1bf05068497a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PfpName", "SecurityStamp" },
                values: new object[] { "9d08767d-f9d0-4011-9f0a-c268d9d42e82", "AQAAAAIAAYagAAAAECV+LQg3SVuH4kZCngfHxLOyRkIMIaRNaI0jt4aBMzs+91G6ojim25fQIwhB1coO6A==", null, "00eb59b8-6727-4180-87c0-b5454feb0f6e" });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PfpName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "LinkUrl",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 5, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 6, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 5, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 7, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 4, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 8, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 9, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 10, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 7, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 11, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 6, 9, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 12, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 8, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 13, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 9, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "e3c82b65-daec-4cfa-a377-247a3cfa91af", "AQAAAAIAAYagAAAAEF9SNNOGs2jZCGkIKARPad1ANAtq9Z+7Aqcxms8wR4HWkbyVawx643xKNCE+L0ovfA==", "a101678d-b801-4177-bbfe-a23cfa1ac008" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "5413dd08-099c-4b68-a177-9e05d0fef7d6", "AQAAAAIAAYagAAAAEJSbx96ihCDfBhwBxhleSBA/xIYDYY5KGWK7syT+ZNVPoBZhpKOQifGc5ldItSYX/Q==", "f400681e-4799-4147-90f2-daa6b96e2bb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "45330eff-18f2-4c8e-9831-c65eddc2ebc8", "AQAAAAIAAYagAAAAECUkyRC5nEetCfW3c/oZsc0anqrn3vabwC63l2fhkLFZbDdVI/AFi7sChKXH4iXY+A==", "8c65397b-c9a9-49ac-9104-dd1532f2d551" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "88a4867f-dd69-4f2e-b771-853f9dea06fd", "AQAAAAIAAYagAAAAECpo5W9L1123rCgqgcSL92ut86Awki0+AAx8Tq0IJt/AeVQf3Dje0vdZlUx/C4FNyQ==", "8e4d5fdf-650a-4f52-b11b-46d1a2721ab9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "8056c01c-1077-427b-b251-d82d0156163d", "AQAAAAIAAYagAAAAEEYg9QOEwVIeYGmVEZirt79zDd0Qx0XxDr484DYxwoADsyiB0XtLD3rPRFDAoP2MSw==", "ea7883aa-4727-4b3b-8e20-91083191d2f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "ec9c161c-4d9b-47c5-9ef9-1142e214a6c9", "AQAAAAIAAYagAAAAEK0QZW99mLnZib3NSvQFj0VGcluIIb1VY0NPLJdsVQzkfjBzZISTnSDxHz57NWOH6Q==", "58b658e2-72b3-4360-b2e5-de67a277848e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "72298421-1acf-4fdb-94ac-6be414ace85a", "AQAAAAIAAYagAAAAEL6PjRkCi//lW2Tr0O2guwf6em0yYjeySuetkd3mVkIRrct+5RZ+Sg+Now4bqwbtCw==", "fc9356cb-1763-4c72-95ac-37bc4a6fbdf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "db5d8bdb-6dd0-424e-aee2-e94329c1e540", "AQAAAAIAAYagAAAAEM3fvYgCmbwDKmfVbmgYI/0ok7pPPTWzFQjKxqBh+wTtQWvUYaEeS0XegyxdpVxWaA==", "fe5c7934-c260-4c08-a847-d9c1d8449964" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "dc2b4f41-aef9-4314-9ea8-6aa5da6b7abe", "AQAAAAIAAYagAAAAEGphyBj93aYky8WTLo0tOy9xoCKqO/rVha74kDdBWCPPEexkfPiQkpddFXIut1Rh8A==", "15d452d4-49b3-4123-a2dc-1d29f8890858" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "76d34cd2-ff63-486d-9ae2-dfb034b066cd", "AQAAAAIAAYagAAAAECzYJFwnaBim1YFtuGMKHZkNyqleVUFup/iUxgu8++hFJ507jLYqutyILuWofG6Z7w==", "a42f0358-7fef-4c2c-8d2c-59be61dd6569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "de2c4fe8-d1a6-48c0-9569-c58a2533df94", "AQAAAAIAAYagAAAAEAvG39LUycJIzn5H4/RcrySlZMLgup+Zim3KYvfdDmBm7ThEQhjmPYQ5++GW3EH0NQ==", "a7afd669-0c95-4d86-ab7f-328d725cfe39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "9b06a55c-b61e-49d0-ab84-006dde3b554f", "AQAAAAIAAYagAAAAENkliTwdXqFLT8+prc+Y7qtIp3Xe5VID3wXyd3mScPIPGaBbFbcwc2opsOkI6cF5KQ==", "29d396bd-9724-4f6d-9fbf-c48b6dd5a7e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "901e59a1-c547-4d73-8ba7-883140ab36b4", "AQAAAAIAAYagAAAAEJTgGDhNLy7ULIz0HAlC0HVjfWCj7dvWdaBrdHloXMQovFHOesDDKBeWBL2E0TWaxQ==", "512dc1b0-b94a-4b95-9310-cea90b4b3ef7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "fc25247c-75c6-4db1-9251-aafe5b1773aa", "AQAAAAIAAYagAAAAELyvErKO2zJKYPpWKAMoVA4hxtIqa9O68W7JTi3TDtLSqCa/2TI1gyIim1ezFRyHEg==", "142b4aec-6cd8-40c8-9718-761a8fa4cafc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "4645fe35-14d8-4403-a049-b5e3a610a505", "AQAAAAIAAYagAAAAEDVswqtb/H+IBY7Aos6rQ/ipiuk2HBtFHUqnTW0IW45RFG7U3mf6cjjUZnZdFuWvWg==", "f05d8850-12da-40aa-b710-0cf47397d4a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "fc62c7d7-a6c3-4c71-baaf-4193a203a78c", "AQAAAAIAAYagAAAAEMBR1vBBMrzt1sDfh5stiTt8vsrDvQLlPGeL2YZVBTfg1gyYYcwyAVvo4WwDdJ3FvA==", "379641fc-764a-411d-a589-78a8ca0bda88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "76b4fe32-27ce-451e-849b-68f3598f8126", "AQAAAAIAAYagAAAAEAHrE8pERidKkjJvhmYhcFZgqe81p9mEIK6b90byLyqYe/gQX3qaTmaT89g+r6gutA==", "6c02c77d-c6ff-49fc-99c3-4a7c065e641f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "ae94bf31-2918-4263-8dc9-7205eee4492c", "AQAAAAIAAYagAAAAENTKdfucXwrHpFScN9/ZEBdtB4vRDKo6/zKhnYhKqCjCYxRSfpIH+Tukxrn05jAsCQ==", "287d9384-5d52-4446-96b3-363255bdc347" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "e03df6b4-2462-489e-9a4c-ae205b8d1d7b", "AQAAAAIAAYagAAAAEAmaCIW1iRkHwVxPJPIyU6kuCL3x9/rnTkVRVx28aXqEOTzU7N0b+mYgZVd4jELA/g==", "251f7cf2-1a20-49c4-bf34-cd436de29ee8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "68888efc-1ed0-4c63-a2e9-667bc2b559fb", "AQAAAAIAAYagAAAAENoEmPf3JXfBR7BNTh1iSpAOh+9PvOIGSCAKO2MDdM8hhA4mlsYlp6dkOUUj2EiwiA==", "0c94401c-2d61-42b0-8fc9-9ad2cbd41a5c" });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
