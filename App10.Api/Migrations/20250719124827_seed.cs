using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App10.Api.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "Tag" },
                values: new object[,]
                {
                    { 1, "Category 2", "Description for Product 1", "product-1.jpg", "Product 1", 1002.0, "Tag 2" },
                    { 2, "Category 3", "Description for Product 2", "product-2.jpg", "Product 2", 1003.0, "Tag 3" },
                    { 3, "Category 1", "Description for Product 3", "product-3.jpg", "Product 3", 1001.0, "Tag 1" },
                    { 4, "Category 2", "Description for Product 4", "product-4.jpg", "Product 4", 1002.0, "Tag 2" },
                    { 5, "Category 3", "Description for Product 5", "product-5.jpg", "Product 5", 1003.0, "Tag 3" },
                    { 6, "Category 1", "Description for Product 6", "product-6.jpg", "Product 6", 1001.0, "Tag 1" },
                    { 7, "Category 2", "Description for Product 7", "product-7.jpg", "Product 7", 1002.0, "Tag 2" },
                    { 8, "Category 3", "Description for Product 8", "product-8.jpg", "Product 8", 1003.0, "Tag 3" },
                    { 9, "Category 1", "Description for Product 9", "product-9.jpg", "Product 9", 1001.0, "Tag 1" },
                    { 10, "Category 2", "Description for Product 10", "product-10.jpg", "Product 10", 1002.0, "Tag 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
