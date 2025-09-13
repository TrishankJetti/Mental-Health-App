using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentalHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class Friends : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Notifications",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ConversationId",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "Notifications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "Notifications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequesterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AddresseeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RespondedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friendships_AspNetUsers_AddresseeId",
                        column: x => x.AddresseeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Friendships_AspNetUsers_RequesterId",
                        column: x => x.RequesterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f21b6e53-294d-4ee9-86d6-7c4d30cd25fa", "AQAAAAIAAYagAAAAEHGtojD/oB5pT+ziUa5NKCK+DjtVM9D/wW2p8dQRT9zT15tnVT6gjWPTGpFUeGWiNg==", "916c7a8e-409b-424a-b6f2-5326dc41dac3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ffc7a95-5fda-460d-8ed1-becff3ad8917", "AQAAAAIAAYagAAAAEMOKel436dU549H+dPm8UNzdeG0VdRtic9eITWBESq8s12WAGA2FH1C5tjyQX99dsw==", "db4fd83c-20f0-41e1-810c-1652b55cd812" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aa94900-a36a-4fa2-96d4-e77fb5aa25c0", "AQAAAAIAAYagAAAAEAsIHeoI/Pk2jf87DWxv+hZV0Rr7N9zuke6yTB/ChBBtrvFtpSPhPc9Di8wa3/vE/w==", "2d206539-6b3f-4270-87f7-2f889a344c13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "995d25d8-3733-48e0-8f99-fecbaa1983b1", "AQAAAAIAAYagAAAAENoGHyzN6WmKozf2Utti7faBgrAq28rjmoXB8SW6CLHGknGv4HWBkrxhrfKX3/R74g==", "5cf9537a-d579-4d8c-9605-83dd949d18c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f9cd3eb-0299-4e4c-bf38-bd3aca440e91", "AQAAAAIAAYagAAAAEFZFbP2pFta4EPK80Yls1I7QoNJ4OSjD04uvD3FbA5pqIOYcKTF1Gj+lCHJAEP9+oA==", "274e75ca-00b3-4a09-8060-280629114092" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3915716f-1a28-488b-bcdc-2f12e21d7750", "AQAAAAIAAYagAAAAEGjpjkltzACuzJtPX2AYF48h7m4VbOBrTm2KJyuKEVWrxiwmvd2cLmnpS4vElSpGcQ==", "d7b676f6-74e0-443e-a0c3-092b1c8a5e7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f0f667b-9fd1-4c45-a6fc-0621fdcf04ae", "AQAAAAIAAYagAAAAEL1DmRAze3z+2dNndkUnql22upHN5+uuxLZS77IuLshy+xm9mcSkektKDTrsPEqb0A==", "ee00e71b-88bf-4f72-a397-8eada711f651" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2b7a345-d691-466b-858a-9ff8c560458d", "AQAAAAIAAYagAAAAEDmpstxecI6BfVQTjP2vjY4f8zWbG9l9s0lPH+vacrB+tkvV/DpEsEl4LcGArRiQ1Q==", "f05c7cbd-2ed2-4735-b46c-b3501a6b0d30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c060ae2-1efd-4a53-90e9-2074d9b14bad", "AQAAAAIAAYagAAAAEAlTFF0KWMDyGCilXgiw3HI5weHyQHf65UT8ytB0WC10SBq/MxBHzK6q+o/x1emLrQ==", "07219d63-9554-4280-96fe-aed744596d1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28369112-6990-447b-a699-c710799cca10", "AQAAAAIAAYagAAAAEJArF24q+PYuPKSAQ/WxQ0dEXc3liYa5TPGfyGdprHtlGCEKhD6yDElCcM43ICMdDw==", "abc29d32-adf9-49f1-80ad-9349b45fa4e4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 10, 23, 51, 42, 392, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 23, 51, 42, 392, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 23, 51, 42, 392, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 29, 23, 51, 42, 392, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_SenderId",
                table: "Notifications",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_AddresseeId",
                table: "Friendships",
                column: "AddresseeId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_RequesterId",
                table: "Friendships",
                column: "RequesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_AspNetUsers_SenderId",
                table: "Notifications",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_AspNetUsers_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_AspNetUsers_SenderId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_AspNetUsers_UserId",
                table: "Notifications");

            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_SenderId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "ConversationId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Notifications");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "281ede18-fc5f-46a4-bad4-c34a016f7ab6", "AQAAAAIAAYagAAAAEGLXgQcLX+hmO5Jx2AjXu30Xw93cnzbKiyEngbJkPJUcL8nH16lxMBGCYdVd4qTW5w==", "9af32feb-e22d-4aa6-a550-a2c247addb9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bb20704-8e08-47af-9d89-7ad5ab159338", "AQAAAAIAAYagAAAAEM6bZ+JPWYkiZlS04yAUeC12vKEGdGKoVhgtT2lkHy5bRoHqzMpQOPPTQ32+qucvnQ==", "3eaf5b06-842a-4bef-a61d-0f68fc4c97e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bea05461-968f-4361-9777-dc2777fbd2d5", "AQAAAAIAAYagAAAAEIIxSbZ7ntIZEtYifnXBkIs8+rFcQypzPThvJR6yq6yca2kZLdqyGXRBiq04AbOtNg==", "998cc952-f8a3-4098-80eb-e5519f52f42d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7151f3af-2619-4e32-8b77-609c6c7e22f9", "AQAAAAIAAYagAAAAEEaRbyRLzk9TEg1C0nQm8BdhPXfDH5bNegWBsFytacvXGANm3eywzQdf0IOG6IKf/w==", "63b88e06-ea42-4e26-920f-a1288cffcd47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e861c319-cff9-47f8-b28a-fb1ee0896422", "AQAAAAIAAYagAAAAEPudUdhhXQ5HxAQOuL/Uo5Yc0KP1L63X68OP4bo1IA5G+ssGFSxH1/N2Ptab8oMdcQ==", "07dc22ca-5176-4a51-bf20-b6d9bf1218c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9479b20e-6440-4b08-8fca-ff37b99fc1f8", "AQAAAAIAAYagAAAAEC8/hAYzS3E8mosX6bxuttc90htDBMHHHqaHTkXlXKW43kCry8AcZD62nGzWO2uZ6w==", "c0b38798-4279-4d1d-b7d7-b5f32aa4bc38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e402e0c4-4e9f-45b6-bcfd-db94c64a07e8", "AQAAAAIAAYagAAAAECV9wsz5OfPmUbR/9ImoJOaOJAZi8PQuikLcH5hbkxVTKdqt9RCWpEtDWgMkQ/nvzQ==", "db53a4cb-d972-48cd-85f8-1a545f08f20d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eeeef10-4ecc-4b84-a78c-99584b667cb4", "AQAAAAIAAYagAAAAELFWhKggNgfu9WDm3Iy5mghD+258Ybs8knkBgaDnlXVRjQEmOeEdFh2UCGZbqKcoUg==", "6545027f-5a05-4829-b28a-77094d001aa6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77837703-b428-43fb-b903-3d41f2660d7f", "AQAAAAIAAYagAAAAEM3Muk99yPA1CFWeI+ZvuuApLYydekwEeWFgHXvb4CFz6PdkcFI0dDtWpqIIk05ouQ==", "625d5f84-c5f5-4abc-97d7-1d9409a80918" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5241a06d-39fa-4030-8036-a50e7f122dc2", "AQAAAAIAAYagAAAAEN4s89JVhRCyK/vyekyWAoxTRpxOlQ3zUWbmQ1uMIg6mAzbOwbG3SlQb2lfbmPXzIQ==", "82400680-5469-401c-9ada-9a1b7397b5c4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 10, 18, 51, 39, 336, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 18, 51, 39, 336, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 18, 51, 39, 336, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 29, 18, 51, 39, 336, DateTimeKind.Local).AddTicks(5896));
        }
    }
}
