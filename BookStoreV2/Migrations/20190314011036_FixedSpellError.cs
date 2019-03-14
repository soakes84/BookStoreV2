using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreV2.Migrations
{
    public partial class FixedSpellError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("a3bd56f7-7a3c-4628-acfc-f39157aa0186"), "Daniel", "Action", "Silva" },
                    { new Guid("69a5a3f8-766a-4b09-9953-5ef77685c7ac"), "Andrew", "Medicine", "Weil" },
                    { new Guid("f1f91ce5-b8d8-45d7-810c-1df66cbd0c1e"), "Tom", "Thriller", "Clancy" },
                    { new Guid("20bdf19c-a105-4389-94b2-24986330f914"), "Lee", "Action", "Child" },
                    { new Guid("06395987-7fe1-42bf-99ab-18185e544b3f"), "Anthony", "Fiction", "Doeer" },
                    { new Guid("067383b1-250f-4b1a-a1dc-f80414cb8ca5"), "Clinton", "Military", "Romesha" },
                    { new Guid("498df901-6252-46d2-b0e6-c6a5f4901950"), "Marcus", "Military", "Luttrell" },
                    { new Guid("23fd84d9-ae2d-4942-95f7-15bec6fdd30a"), "Robert", "Thriller", "Ludlum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("06395987-7fe1-42bf-99ab-18185e544b3f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("067383b1-250f-4b1a-a1dc-f80414cb8ca5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("20bdf19c-a105-4389-94b2-24986330f914"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("23fd84d9-ae2d-4942-95f7-15bec6fdd30a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("498df901-6252-46d2-b0e6-c6a5f4901950"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("69a5a3f8-766a-4b09-9953-5ef77685c7ac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("a3bd56f7-7a3c-4628-acfc-f39157aa0186"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("f1f91ce5-b8d8-45d7-810c-1df66cbd0c1e"));

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
    }
}
