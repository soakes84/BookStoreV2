using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreV2.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("20c825de-7482-4c7d-a440-6bf5f67f1458"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("6b9e4325-aa5c-4a22-bb59-4c1ba0f1014c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("e739c64e-0fa7-4b4f-8353-47f84a134016"));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "Genre", "LastName" },
                values: new object[,]
                {
                    { new Guid("e663678a-5c14-4fbb-a74e-fe6fa4e500b8"), "Daniel", "Action", "Silva" },
                    { new Guid("25cbb71c-ded8-457e-82bc-22f3e2823b74"), "Andrew", "Medicine", "Weil" },
                    { new Guid("c0f576e9-3949-40ad-abba-1d289a9702d3"), "Tom", "Thriller", "Clancy" },
                    { new Guid("3a2cd1f0-6900-4784-854a-ad4bf4ada625"), "Lee", "Action", "Child" },
                    { new Guid("2c355d64-e95a-4827-9638-81fd67abfc16"), "Anthony", "Fiction", "Doeer" },
                    { new Guid("f0be5e74-3537-478e-b4e1-9350be978195"), "Clinton", "Military", "Romesha" },
                    { new Guid("f4ab2d70-c04d-481c-b689-2c3e2c3c2297"), "Marcus", "Military", "Luttrell" },
                    { new Guid("524c5d54-ce07-4447-9ed1-38bd4e959c53"), "Robert", "Thriller", "Ludlum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("25cbb71c-ded8-457e-82bc-22f3e2823b74"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("2c355d64-e95a-4827-9638-81fd67abfc16"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("3a2cd1f0-6900-4784-854a-ad4bf4ada625"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("524c5d54-ce07-4447-9ed1-38bd4e959c53"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("c0f576e9-3949-40ad-abba-1d289a9702d3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("e663678a-5c14-4fbb-a74e-fe6fa4e500b8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("f0be5e74-3537-478e-b4e1-9350be978195"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("f4ab2d70-c04d-481c-b689-2c3e2c3c2297"));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "Genre", "LastName" },
                values: new object[] { new Guid("e739c64e-0fa7-4b4f-8353-47f84a134016"), "Daniel", "Action", "Silva" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "Genre", "LastName" },
                values: new object[] { new Guid("20c825de-7482-4c7d-a440-6bf5f67f1458"), "Andrew", "Medicine", "Weil" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "Genre", "LastName" },
                values: new object[] { new Guid("6b9e4325-aa5c-4a22-bb59-4c1ba0f1014c"), "Tom", "Thriller", "Clancy" });
        }
    }
}
