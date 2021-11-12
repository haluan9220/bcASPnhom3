using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class Updatename2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastName",
                value: "Laptop Asus Zenbook UX425EA KI429T i5 1135G7/8GB/512GB SSD/Win 10");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastName",
                value: "Laptop MSI Gaming GF65 10UE 286VN i5 10500H/16GB/512GB/15.6FHD/RTX 3060 Max-Q 6Gb/Win 10");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastName",
                value: "Laptop Fujitsu CH 9C13A1 i5 1135G7/8GB/512GB/13.3 FHD / Win 10");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "LastName",
                value: "Galloway");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "LastName",
                value: "Smith");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "LastName",
                value: "Longway");
        }
    }
}
