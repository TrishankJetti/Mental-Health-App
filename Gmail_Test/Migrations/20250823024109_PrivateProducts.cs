using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class PrivateProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPrivate",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPrivate",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9f9f32c-d2b8-425e-b13d-49f296e80ca8", "AQAAAAIAAYagAAAAEPCr8VMyGJIoXgf1qRKt5Rf/795Qhs/DMquTsEu1uDn1il7jwUuB17V0z2iToIDTJA==", "814a1b09-3496-4167-8871-3c2284668ce9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78c63d6f-d427-4b1d-a8db-39a15680eb9c", "AQAAAAIAAYagAAAAEOJWfDuznxPqZUO4fSyLF1hTi0tQ+49fa7wAjUgN8V9VQWsBg8K83OciQ6IQDak3tg==", "56fab9ed-cebb-46fc-9d78-46d8bcf94b09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c1d0cc9-ae88-4ea6-b926-e442b67cc929", "AQAAAAIAAYagAAAAEAcOzRDcDJgaXBleLVUhVQXT2N9dxI92Odz2lJz3tMIWUJL6Vn1bExUR5D53AD9iGw==", "016b2d89-78d6-45b1-94e4-19a4c60f4f8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3903cad-5c71-4635-976c-11337d34bac8", "AQAAAAIAAYagAAAAENjxTN3FB0vSJ/PsfNsmTRWTOfegnY2FzUHu3Yws+xvwwf4dqJfsE6hr3qd4w8ImLA==", "ea409b9d-5256-42e6-b736-1e4b86968004" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "425d4f0a-e19d-430c-b73f-1036a12bcdba", "AQAAAAIAAYagAAAAEFHMvWis+6awRDSaypsv8EQsZerlhS58GFb68L2ReXUP0nKAqXn6RpwRhFoyr+Mgwg==", "16a1e924-7c46-445b-8d06-64ae9f8cbd9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ff402f5-a783-4dc0-9c7a-6fd21e6c0e43", "AQAAAAIAAYagAAAAEDQ0NpH7a3uaBFJCBKraJ18k1mbOizLERQ7KYruWyMqjWAmj+rjWIcSzeFbPQLNSaw==", "176d9f0d-3f3a-4d39-831e-2e57b41d73a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45db957c-d4de-4ee4-b11b-5ead4ca9b70e", "AQAAAAIAAYagAAAAEAtKZlvfU34XN+XcMfzqQdlxtpIeGJiK+N2zvkf6bQujZTykAi4yOB1+G0uWsPPsOg==", "151fd924-eccb-4c23-804c-8a1846c64d78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4b73dea-7f60-4f29-b664-80016c1da2b8", "AQAAAAIAAYagAAAAEHPqWRw5lLqdPL6AUrZDZ3dbYoJNjHa9PgUgmPC4DWI+sD+M9POboUDQENARa/dj4A==", "314a8cfb-090c-4aa2-9cc5-68b5d9560056" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1701031-6d20-4a4f-8c52-14a8b53b9ac3", "AQAAAAIAAYagAAAAEPaKqycSevhHtmj/1T92gzFd/mjgNrSO51ElA9k8MNzu1waUwd7CCBdKTwqnIXB3ug==", "fd246182-b3f3-493a-b2ad-f9a17de1474e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09fc4574-d8eb-4f73-baa5-6f29cf4bf97b", "AQAAAAIAAYagAAAAEPBgJ7QHKhDHJzwxywILNrLVYgvbjLDGrjfTCinE6JBgRIYsffsjd0ChrUKV32ZWEA==", "6e29fc28-2a5c-4552-a98c-4ea418316a85" });
        }
    }
}
