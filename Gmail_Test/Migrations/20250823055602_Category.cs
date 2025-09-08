using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adbb0ddd-6025-46fc-a13b-bfdec3bbb54b", "AQAAAAIAAYagAAAAEOc1x7L8PS/mI40GEPu9NkR3mgYA3FQ8mVd2TpSjTYmMnqmclnRCT3kszPZoUWT/Bw==", "c69ae5f7-9583-4a9f-8ee3-0f4204c8f9b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4641b64-7ba7-4435-b209-425c72dbbe0b", "AQAAAAIAAYagAAAAED2be5VMBGsqdWy1RZwuL3EriQH+LFhHANmqRj7Cleke35jklJTydbOHFnjumKlSog==", "ff356751-01e0-4624-b9f7-14f13069beac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9385eeae-9eae-4619-9e94-543a8412d7bc", "AQAAAAIAAYagAAAAEK2INxu+TK2bWrDm3GVHgHhe4smxDSnn3zRRPW/V9nVyrq39+rVExgQFvp5QniBx5w==", "85bed116-0c65-4122-a5d3-d0f7767d97e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9aaa0fd-7c7f-4bb6-b077-1ee88c3f6c73", "AQAAAAIAAYagAAAAEOVhQhoetC/wER/zvlNWltUar6Jc7qMWhSYZPqP9wxLQ+YgufiJ+fWl7QtSxZF+fXQ==", "9315db1a-3eb7-4c67-8471-5bccea4aaee6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83ee8109-62fe-47dc-90eb-5520cb924b13", "AQAAAAIAAYagAAAAEJhdun+cp3RbCM5L16zk/2pZxWb9GQq+aeXhCSWnRZoGPvRXe+Og3yQ2FhkQ1JgD4Q==", "ed6bb780-98f8-4ade-b27f-13a9dfb9bf92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08ad3e43-18aa-479d-b0d4-c7000fb1ea35", "AQAAAAIAAYagAAAAEJKin7myrNiLotUbKQWNeQweg/Chya8jru8lXqox+ru//L1dneWAumKi6oPIeWgNcg==", "05d2de83-95a6-475f-b4bd-a02812b6d21a" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ee3217f-ad35-41ea-a71e-732f7c2bb283", "AQAAAAIAAYagAAAAEJB5SwnL72fyBJvaYuqx1G/MjuTJy1g4KbMH9odcZwOkqI7S1W1l1IHpO1bgCltrWg==", "dfe6c806-a3da-4d52-b9c9-241e7fe628e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51f47c17-755a-4c75-971c-acb24150b25d", "AQAAAAIAAYagAAAAEGnQbebaknR4ZN0tzQ59YMrj2Vi4DYJe0eRuRQ9r+XdcHp7OVVzIJll4JIL4qY+teQ==", "922d233d-a7d2-462b-adf1-67eb3ab2a37c" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "691aefc3-7fea-42b5-abab-ab1e806ec95c", "AQAAAAIAAYagAAAAEKtSNgAVIBV7NFZL6SkfjlYU5TokyWQriVf+MHjVe6/qh16lUCKbql0pg4m5MSdF5g==", "f292d6f5-7934-4993-9fd4-8fe7703c99e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf7a7790-e8aa-4cbc-b41b-b2fd5f257e2b", "AQAAAAIAAYagAAAAEM3DObg+nmv6qRkcghmHzX90+5B4BZc8QY2aPAKlpjLpManUeb3+FustBwXhWkygBA==", "62833691-4244-46de-9545-cfd99ade2afa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbb9697d-b57b-4541-a5cb-3c5c0e2a2e3e", "AQAAAAIAAYagAAAAEAi5TTLIIfPvpJDXwutrV/ybkDrnTzoBxj+F4APe/if5IKIq8ghCY7NfqmozS/rKYA==", "c6e5f5b8-7de7-4a0c-99bc-a968ce359ed0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40088775-4b05-4f20-bb5a-fd5b5a0295aa", "AQAAAAIAAYagAAAAELcYcew0WZ8hQvDEwXJiL9qIs9pFOhV2eFKCe8NLi3hdyH1PgqLyo3VF8gKf5n/sVQ==", "e28faafd-1a96-41d6-a0a4-699c34d3f344" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a9d6f40-62bf-40ec-92e9-749179aea7a9", "AQAAAAIAAYagAAAAEH1eJkQgDbYqosnIpKFSLAOVz7raUpPwAlx3s9etMkc8CShYXfMPCbkLHFA60fLNEA==", "2958d15b-6813-4b8f-ad73-1da48aae2acc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bddede6-6abe-4065-908c-a8e6e94aa4c1", "AQAAAAIAAYagAAAAEK/cN98mK4UCu/XCQ8XSrY20IjG/p6XBhMagUl7qvygIRbX9299/fwKYePYh2b5MSw==", "1d55996f-bf56-4dc3-b25b-5063ebe99bd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c42c0ad1-b913-43c0-8ef8-af557b9ccffa", "AQAAAAIAAYagAAAAEEs6iQ3NUCrPjRSqZsHvSb9C34QgfhPNvCJOzvEj/B1FiHD/jGU/xx4VSAPbxZ+tKw==", "32b49ec0-402b-403e-93f2-cc8474b6709c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "681a7ae0-f2bb-4661-92ac-e766a30760c9", "AQAAAAIAAYagAAAAECyn0QgacRxfkuzs0OtKs5NByW0pnHmhXxrmaUtG1dLkuDTxf5Jm1C4K93LEzeUilQ==", "20700e00-a487-4832-8289-bd4dfa36830d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60529371-b9ad-48fd-adce-a47d81aab123", "AQAAAAIAAYagAAAAEMXC5s6ocp9Payw73bKCreM2GWqg083/r35Vei9ptE+8f9rHTjLuF8vdJYfm7hmoYA==", "0a6786c9-3f69-406e-af3c-f7edc0cc83a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7c87fe5-9baa-4ef7-ae3f-bb4e1fec5e90", "AQAAAAIAAYagAAAAEHm/fBOgzjKuVxQK15257NSHObPcT/aXy1OTeJDpX02hh9nZMl8IQfbTBZmPOjzAVg==", "d37cfe0c-a495-4a2d-b335-2f269a7c07c8" });
        }
    }
}
