using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DytronCustomers.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "LastName", "LastUpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5282), "customer1@example.com", "First-1", "Last-1", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5292) },
                    { 2, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5296), "customer2@example.com", "First-2", "Last-2", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5296) },
                    { 3, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5298), "customer3@example.com", "First-3", "Last-3", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5298) },
                    { 4, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5300), "customer4@example.com", "First-4", "Last-4", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5301) },
                    { 5, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5302), "customer5@example.com", "First-5", "Last-5", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5303) },
                    { 6, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5304), "customer6@example.com", "First-6", "Last-6", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5305) },
                    { 7, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5306), "customer7@example.com", "First-7", "Last-7", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5307) },
                    { 8, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5308), "customer8@example.com", "First-8", "Last-8", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5308) },
                    { 9, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5310), "customer9@example.com", "First-9", "Last-9", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5310) },
                    { 10, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5313), "customer10@example.com", "First-10", "Last-10", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5313) },
                    { 11, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5315), "customer11@example.com", "First-11", "Last-11", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5315) },
                    { 12, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5317), "customer12@example.com", "First-12", "Last-12", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5318) },
                    { 13, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5319), "customer13@example.com", "First-13", "Last-13", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5319) },
                    { 14, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5321), "customer14@example.com", "First-14", "Last-14", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5321) },
                    { 15, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5322), "customer15@example.com", "First-15", "Last-15", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5322) },
                    { 16, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5324), "customer16@example.com", "First-16", "Last-16", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5324) },
                    { 17, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5325), "customer17@example.com", "First-17", "Last-17", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5326) },
                    { 18, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5327), "customer18@example.com", "First-18", "Last-18", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5328) },
                    { 19, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5329), "customer19@example.com", "First-19", "Last-19", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5329) },
                    { 20, new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5330), "customer20@example.com", "First-20", "Last-20", new DateTime(2024, 10, 26, 3, 50, 46, 840, DateTimeKind.Local).AddTicks(5331) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
