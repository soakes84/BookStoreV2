using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreV2.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
