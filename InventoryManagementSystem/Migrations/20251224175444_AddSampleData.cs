using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    public partial class AddSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
    table: "Categories",
    columns: new[] { "CategoryId", "CategoryName" },
    values: new object[] { 1, "Electronics" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Clothing" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Username", "Password", "Email", "Role" },
                values: new object[] { 1, "admin", "admin123", "admin@inventory.com", "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Username", "Password", "Email", "Role" },
                values: new object[] { 2, "user", "user123", "user@inventory.com", "User" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "CategoryId", "UnitPrice", "Quantity", "DateAdded" },
                values: new object[] { 1, "Laptop", 1, 999.99m, 10, DateTime.Now });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
