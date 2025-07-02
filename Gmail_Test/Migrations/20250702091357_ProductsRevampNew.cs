using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class ProductsRevampNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed113574-ba50-4908-ad5c-600e2d8aa45e", "AQAAAAIAAYagAAAAEK1891LtFxPCIK8RU40sU2qk6TzCkwCAq952Q+P/+qfCNWwe7YjM36C3I4J5dhtCuw==", "948302b3-8b9f-4926-a64c-026f1c9fcba9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2211870b-b41f-4a3e-a6fc-0655d3f6a875", "AQAAAAIAAYagAAAAEAk+iJZLImZrCgpAnq6t0ZrRchi5zua0RPihLl6i6u/Pc1pt69frozArlCbQ/yyNCg==", "077ef2ad-2a04-44f4-9d19-d409a7d454ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e5e06e7-e22c-46b8-a90b-b93bfebea6b8", "AQAAAAIAAYagAAAAEHsGdgjrhM3YLw5/wKdR0n5qvUZh50Ut3TFgZoaFsyN4f4YF2L46bjXW6Fg8z55x/Q==", "40eb2533-2948-4c42-aee6-dd14129fe0ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c857bde-6027-4fc9-8864-0292f065be18", "AQAAAAIAAYagAAAAEEy6iqOTj+SIFXXlrU6SLtNFQTcio8HIbcPCXzbXw/oBFQTCTYpCC804RvMZIPBwtA==", "df5a72e8-356d-4f84-b5af-474478104bfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d5a5760-a215-44d1-baa2-af7b0cee9444", "AQAAAAIAAYagAAAAEB2qzDQ8F2UWULGiX/RfVM/yzzgv7+IUhSQ7XupbrL50oKUaLNls6HplDXaAALEreQ==", "7ff0024a-633f-4228-8168-832121960da9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3868596c-8d25-427e-b7ac-ea1cc8b5047a", "AQAAAAIAAYagAAAAEPBAo2q8ul1Fcehrx2iURpWJ7HoLQ3Q9fz2vLlIGCRWTInPH25kDkQA9XvQR6UwnSw==", "f7f49a4d-38d6-41e1-8947-29a8822fc887" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87bf5282-53a6-451a-b1c9-0f8f072d3edd", "AQAAAAIAAYagAAAAEBFLC74iUsLVdTOz9QTvu3KvMyNpV5tfjFMejo7h9YIs/nKHp5nnEEsuz5HK9HLmWQ==", "6563d2f5-5868-4294-a7b1-96ead94794a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfc809d7-af9d-43f1-a043-d9e70f90ae86", "AQAAAAIAAYagAAAAEFxnbJJ+KrdSFKPU2KGHtifbBq0PnrK80eEcqkl60bms7UgMhqK4wk0s4bJ9Tmk6vg==", "1fdf4529-823f-48df-8838-0321933fd0d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "929243bf-1faf-4225-9db4-b98546b24a31", "AQAAAAIAAYagAAAAECEeoAqHNUOgvT6+wzZsKYLb4fthlebaBtTZ8t4+5lZCsjKIVq2WD8vycDK4GZIgqA==", "57b0b09c-9f70-4c19-88cd-cd95cde42b63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e0e2d62-b89d-4c5b-918e-b87099e1b80a", "AQAAAAIAAYagAAAAEI2bC/D2A3JKQTiybTz3A7C7UAH+rq6FYeQBPtGOZNLTke/C1NaiP0vjncspeGbbPA==", "64cff72d-c661-4bbd-9ded-5c63c5384b50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9fed78c-22cc-4147-ad29-5be69e7ff67c", "AQAAAAIAAYagAAAAEEpf+RxXskOHs0xSlRk5Jm1swhgrjt637DcwnILkGChBNffWuOGw+Pmb/A24TiwLig==", "badc2183-a83a-4e27-8576-d6b64777630f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14535529-7b01-4d98-9fd3-62bef8a4db2e", "AQAAAAIAAYagAAAAEGayb2jg+4pRL/T4SSsj/3nFWEi014rhUolR8HhZxTPK5YPE3lK9ev2bNY5+gUpxZw==", "dd24d935-a8ee-45db-9f89-11f12a4bcc43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82d4e55b-c635-48c2-b0c2-b2e3d46edc7d", "AQAAAAIAAYagAAAAEObasXkoioRW0df0uozrKKBaJMzLicdNTsMFtha8077lDKI0h5unxzD6X4qf/M7NeQ==", "cd281b67-1a89-4b49-852d-37816261b545" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4398e67c-cbfb-4613-bc4d-95263d9154d4", "AQAAAAIAAYagAAAAEELyWnpq0dU7O3dZJ8y30p7tpoY/ZfpXOKxb/rGSQCIXvyrUqls/2nFxbVFFW9k6rA==", "4f042a19-18aa-4661-bafe-4f2a8937a197" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31b36587-2f3f-4e40-832c-9b754d7396ea", "AQAAAAIAAYagAAAAEKOKSzHGGagERMp6t4B2dspndBJfjZtHaA5Gs+oBGrzxF0uG2YPoCCWaaeLOYpoN/Q==", "dcd19979-b1d8-4988-bced-e5510cf755da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14398f8a-1880-48de-86ed-66b866097791", "AQAAAAIAAYagAAAAEJO8rxBIdif254VL/O1jyp1gEi6O399be2J1O2+dNX7nfMRkM0RrN59cI6XTxM2ijQ==", "67ca9785-f277-4961-be7a-a9d7368400f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72afc529-604e-4e2b-9c00-0c8d59b09f02", "AQAAAAIAAYagAAAAEAWKcKyoYbmL0E1Ljfuf0Hn/4304NydqS3e69147V+Qzb272zEN5akhTJFVajkZ6cw==", "290bc8e2-4586-4820-a112-d4e24d0e9524" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19baf65a-1d97-4a76-885d-51e895e4d3ad", "AQAAAAIAAYagAAAAEGGXg1P9aMzpHNnZL5F6x1JbjOn/De8B+AMXZLAbUSLgHuxZy/TzV2Fb69smAwBzoQ==", "0a419ca0-80c2-4014-a9a8-d8f6795f3156" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cb8d3cb-28b3-45f5-a7cc-9a2e3954af7e", "AQAAAAIAAYagAAAAEK1rmZyHXc2L3QHR3dxsl3t36LNVo5eYOUrNh0PuACd09scr4pC/9Uabl+uNb1+AEQ==", "ca8e5645-51f2-45b7-b82a-4ea88600fdb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "277a700a-f8f3-4a13-99e3-a9e53b391559", "AQAAAAIAAYagAAAAEKMB0922HR2OPXmcOleb4D8L6fVhVyLl2RnsUBqr6tJQMqZR7aaIIbYxJsmxb4HJ8Q==", "644fe8dc-041b-4337-9b41-26776365a054" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bec40b0-624a-400a-bf17-4dada32faf9b", "AQAAAAIAAYagAAAAEEnGWGG0qEJ3rxlyylpGnS4rzQkQf9lqWF840HFQB7lw71IUt8JDym+3GbQ//yuWLQ==", "eaedd04d-836c-49fd-964e-daf58e12e765" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61be3261-fa93-46d7-a3e9-94ff3402ab17", "AQAAAAIAAYagAAAAEHaOqKcuXT39ZSPddljFKSEsnqEb0Dt3dwegj9DwWCq48c2Mq8kaNtrS0JnY5KlNeA==", "325aba83-c183-45e5-9f5f-3503101fcd5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfb65849-5ebc-4f86-8980-7e0faa8a2220", "AQAAAAIAAYagAAAAEPZosyFRs4kwVEh/0VCcaYt/aJ8yRxyn23zWtHd3ysF3Jf8n6Urve0tNZhMenuDilA==", "98c2bef7-b970-4edf-9303-72e440eefcd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9437141-c757-4b16-823e-3daab77c0f79", "AQAAAAIAAYagAAAAEMaOeXFTceqsHJ8J1L4eSFM4Bo3GRYF60uQOE/QSw+BaepXBDPInkkYrr/MnYqtn+g==", "20348b17-644b-441c-8b9c-7444d6402e23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5831c2f4-3287-4d02-b467-7ccdeb5702a8", "AQAAAAIAAYagAAAAEM9VOsKIRLgQV/kR1Bq7a5Ksrr1QqM0VWBGKzAHF7/Irt4TIx/IfwepXEIY2fUMIFQ==", "e123686d-6041-412c-a857-e8eee6cce36d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c23eabba-8564-408d-8936-7d84615bf337", "AQAAAAIAAYagAAAAEKH6TS9BA/YoC6Gm8KpcUqWpOa0ERmwZOTiosylRJh+3sYvYpJ4ewjZoIDW+PAia7w==", "9055c1ab-8b37-4f0b-9a92-26a03a0ae4a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6dae05b-8fc3-47df-b250-7fa8d9fc44b7", "AQAAAAIAAYagAAAAEHpCtivRE5ytlNH8gq9Kryqejyurqm7BTu4lFTBFeJgdfn8g/Rhkeo9QhmZEY6gsdg==", "cbda1346-0856-4e6b-875d-b3af14348773" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97daf662-fa3d-48ce-aa2d-3d7f0d0d3350", "AQAAAAIAAYagAAAAEMaIp56kyP47RKyPI7kBVPXa2Zfgy0r6qhBiUc6hbjw9VA7ImpqUbxVj2INB88zi8w==", "d4e08d8f-2f30-47c5-b184-668e8549c9ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bac67619-3f91-4e5b-ac33-fbdc8570ca2b", "AQAAAAIAAYagAAAAEJfCeIDelwjsm+L6hLVbQmxxohTwV5TUbaXgEs56bNRDvGJdlGxvtM4tJR9LRRjQ9g==", "2c2aeced-b0cd-42e7-a81d-de3445987eca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a75781a6-e034-40c5-8f1c-94b4e71bd007", "AQAAAAIAAYagAAAAEMF0WB2qIgFTv9BAugRjLza2Gm+wyso20MA3zD2/gd6dAFl78OgYn1tgr9y9HlaFtA==", "6f4094c2-6d98-46af-a569-e72ed253f8d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7a5f583-ac3e-4269-9089-397cad26d74f", "AQAAAAIAAYagAAAAEIw3PNGz4jAide5+lFDtbfac1HJk/PvTQG/+vHBCNhRU2x/QmrNBUzT2DVSCg1SXKg==", "8c432885-c2f8-43c5-8590-bcec7f0f561d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ee8c25b-2a7c-46ee-bb19-34e53288ec25", "AQAAAAIAAYagAAAAEKz3c2PGLatyeVVNaumMQpZkgABs8NO1SdA6QtuIUIJ0ILEHMv/b9aMU+sidnlOg3A==", "732c8871-87c0-4909-853a-8cfa27abc763" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5dd81bd-f981-4cb3-a715-8fd8abb0a995", "AQAAAAIAAYagAAAAEORRxTdwDRE7FrcM8jnSitWWaorhIQ6RRKYjc/Bo0mX6G5artyKloei1hlUqbZo9mA==", "06816a31-6e08-4135-b41e-b1ce3947bdcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "479e34dc-f5dc-4185-8368-0c9d2fc9d040", "AQAAAAIAAYagAAAAEEk14zi6JIcVwk8N4UPvSQW4djAMs9ky+P52hS7he3sNzCaUT7wWi4pVmLAvI3pdHw==", "8314209d-a2d1-4305-bc2e-675f5dc62527" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fa6b81b-2780-4f1c-8bcf-039e427e863a", "AQAAAAIAAYagAAAAEK35D3ipWiFDfQKTDTO4YSN+Z3VeapuG24w00YVeCKhfBHhXiKDgFhZeMBp2x74Hlg==", "343c201c-fcc4-4a91-9609-1a258e9a54ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "521623b6-fb22-47f8-8b60-267620c8dba3", "AQAAAAIAAYagAAAAEP4PeAwkTNoWYIVimSVRY115KjPzdapYtWDdbQr06+OGBtcfnSAZgsN/iVUH//fjcA==", "a241c4b6-bfc9-4839-8a28-ffb1bed1c14d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75c872d2-a8db-4247-bcd1-6e7ef4f4da76", "AQAAAAIAAYagAAAAECBsSC2bYfhSlj9ovdlLNNqzJfUiDPQku0yfYtOHUyovn8QbyIBcdGjZvNY5VrUDiQ==", "63a40742-5af0-4ce9-96bb-fa1c1a80ef4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36b4aadc-0e4d-47e8-8b3c-07f88ac1821c", "AQAAAAIAAYagAAAAEBx0BPgfApUpRYdHKfCpu2fuHo16i9wZSCij337s5NjqEtRAjQUp6wjfLo6cfk8khw==", "087c4f99-5ac7-432b-b7b3-611c8f42dc73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02280bb1-da37-4bd9-a86f-3883c3d2e96e", "AQAAAAIAAYagAAAAEGKn5YPgFsOtAWJZUD3wMIATmngChsJzFeFXU6u21cn+sqHMP8FQQjWg7o4kH3qjJQ==", "8b2f6b59-bc1a-4121-9b8f-a8957aea39bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "402f7563-658c-4c6a-9505-e4f16a3e1ef9", "AQAAAAIAAYagAAAAEKmYrVFj2SMDC8GpxZeH3jbukTsNjRtSCPfeW3W+Oya8WRKo6zirTOtrLPJHQEWh8g==", "4d6dbaaa-2c42-42ef-a6fe-88c90d273891" });
        }
    }
}
