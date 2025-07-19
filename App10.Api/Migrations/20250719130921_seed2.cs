using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App10.Api.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 1", 1000.0, "Tag 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 2", 2000.0, "Tag 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 3", 3000.0, "Tag 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 1", 1000.0, "Tag 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 2", 2000.0, "Tag 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 3", 3000.0, "Tag 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 1", 1000.0, "Tag 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 2", 2000.0, "Tag 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 3", 3000.0, "Tag 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 1", 1000.0, "Tag 1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 2", 1002.0, "Tag 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 3", 1003.0, "Tag 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 1", 1001.0, "Tag 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 2", 1002.0, "Tag 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 3", 1003.0, "Tag 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 1", 1001.0, "Tag 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 2", 1002.0, "Tag 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 3", 1003.0, "Tag 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 1", 1001.0, "Tag 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Price", "Tag" },
                values: new object[] { "Category 2", 1002.0, "Tag 2" });
        }
    }
}
