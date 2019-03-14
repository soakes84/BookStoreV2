using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreV2.Migrations
{
    public partial class Genre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("eceb8874-df41-4a64-9b6e-84bf8ce3315e"), "Daniel", "Action", "Silva" },
                    { new Guid("497a5440-588a-47de-9d2d-ee48ed10d110"), "Andrew", "Medicine", "Weil" },
                    { new Guid("d1d36299-029d-4851-8b95-b2bbdfb47254"), "Tom", "Thriller", "Clancy" },
                    { new Guid("0fa36c56-d64b-4858-9c36-852600ccdca1"), "Lee", "Action", "Child" },
                    { new Guid("90dca817-f00f-4db3-95ce-d53f3e8cfe8a"), "Anthony", "Fiction", "Doeer" },
                    { new Guid("19b5bbaf-f279-443f-9a92-f1c5092d4483"), "Clinton", "Military", "Romesha" },
                    { new Guid("f9d15bdc-4773-40af-8008-26c5642e777c"), "Marcus", "Military", "Luttrell" },
                    { new Guid("15557698-99c9-4596-981e-678d1ed0d78a"), "Robert", "Thriller", "Ludlum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("0fa36c56-d64b-4858-9c36-852600ccdca1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("15557698-99c9-4596-981e-678d1ed0d78a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("19b5bbaf-f279-443f-9a92-f1c5092d4483"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("497a5440-588a-47de-9d2d-ee48ed10d110"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("90dca817-f00f-4db3-95ce-d53f3e8cfe8a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("d1d36299-029d-4851-8b95-b2bbdfb47254"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("eceb8874-df41-4a64-9b6e-84bf8ce3315e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("f9d15bdc-4773-40af-8008-26c5642e777c"));

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
    }
}
