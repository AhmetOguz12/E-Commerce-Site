using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class try2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreateTime" },
                values: new object[,]
                {
                    { new Guid("5576255c-5c4e-429e-962a-5e5d1a929547"), "Bilgisayar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f076fb93-5369-4623-9db0-a6834a2a3374"), "Telefon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ProductName", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("65e9f1ec-32dd-4c7d-b269-e33267845a96"), new Guid("5576255c-5c4e-429e-962a-5e5d1a929547"), "Telefon Sadece 1 Kez Açıldı", "Acer Bilgisayar", 12000.0 },
                    { new Guid("77e9f1ec-32dd-4c7d-b269-e33267845a96"), new Guid("f076fb93-5369-4623-9db0-a6834a2a3374"), "Telefon Sadece 1 Kez Açıldı", "Iphone 3", 8500.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65e9f1ec-32dd-4c7d-b269-e33267845a96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77e9f1ec-32dd-4c7d-b269-e33267845a96"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5576255c-5c4e-429e-962a-5e5d1a929547"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f076fb93-5369-4623-9db0-a6834a2a3374"));

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
