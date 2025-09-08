using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class EnumProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Product",
                newName: "Category");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Product",
                newName: "CategoryId");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c54f34db-339d-4d65-a362-a97d940329d2", "AQAAAAIAAYagAAAAECVzeN7Za8/u5FXE5qsvgtXYapSv2y13IwaHF2JTCKVnu96nD6+t9a4zNnBMqxGHlQ==", "a6548f11-524f-4a59-95fe-8fc9542f5147" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adbb0ddd-6025-46fc-a13b-bfdec3bbb54b", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEOc1x7L8PS/mI40GEPu9NkR3mgYA3FQ8mVd2TpSjTYmMnqmclnRCT3kszPZoUWT/Bw==", "c69ae5f7-9583-4a9f-8ee3-0f4204c8f9b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4641b64-7ba7-4435-b209-425c72dbbe0b", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAED2be5VMBGsqdWy1RZwuL3EriQH+LFhHANmqRj7Cleke35jklJTydbOHFnjumKlSog==", "ff356751-01e0-4624-b9f7-14f13069beac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9385eeae-9eae-4619-9e94-543a8412d7bc", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEK2INxu+TK2bWrDm3GVHgHhe4smxDSnn3zRRPW/V9nVyrq39+rVExgQFvp5QniBx5w==", "85bed116-0c65-4122-a5d3-d0f7767d97e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9aaa0fd-7c7f-4bb6-b077-1ee88c3f6c73", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEOVhQhoetC/wER/zvlNWltUar6Jc7qMWhSYZPqP9wxLQ+YgufiJ+fWl7QtSxZF+fXQ==", "9315db1a-3eb7-4c67-8471-5bccea4aaee6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83ee8109-62fe-47dc-90eb-5520cb924b13", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEJhdun+cp3RbCM5L16zk/2pZxWb9GQq+aeXhCSWnRZoGPvRXe+Og3yQ2FhkQ1JgD4Q==", "ed6bb780-98f8-4ade-b27f-13a9dfb9bf92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08ad3e43-18aa-479d-b0d4-c7000fb1ea35", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEJKin7myrNiLotUbKQWNeQweg/Chya8jru8lXqox+ru//L1dneWAumKi6oPIeWgNcg==", "05d2de83-95a6-475f-b4bd-a02812b6d21a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd70cb99-12b8-4458-bdb6-69d88eb3ebd9", "AQAAAAIAAYagAAAAEI1ndEIb7lUhXKTMdXnOs3/Y4Y8wGCX78O5/wLpiKwGGVTBhjqTo9typsTaRo5Gz9A==", "a03468d2-4cb6-45db-871a-870122d4b466" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "LastMoodCheckIn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ee3217f-ad35-41ea-a71e-732f7c2bb283", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "AQAAAAIAAYagAAAAEJB5SwnL72fyBJvaYuqx1G/MjuTJy1g4KbMH9odcZwOkqI7S1W1l1IHpO1bgCltrWg==", "dfe6c806-a3da-4d52-b9c9-241e7fe628e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51f47c17-755a-4c75-971c-acb24150b25d", "AQAAAAIAAYagAAAAEGnQbebaknR4ZN0tzQ59YMrj2Vi4DYJe0eRuRQ9r+XdcHp7OVVzIJll4JIL4qY+teQ==", "922d233d-a7d2-462b-adf1-67eb3ab2a37c" });

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MoodEntries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
