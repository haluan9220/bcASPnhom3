using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class imgnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath2",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath3",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath4",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "PhotoPath2", "PhotoPath3", "PhotoPath4", "thongtin" },
                values: new object[] { "images/dell2.png", "images/dell3.png", "images/dell4.png", "i7, RAM 16GB ,SSD 512GB " });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "PhotoPath2", "PhotoPath3", "PhotoPath4" },
                values: new object[] { "images/asus2.png", "images/asus3.png", "images/asus4.png" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "PhotoPath2", "PhotoPath3", "PhotoPath4" },
                values: new object[] { "images/ms2.jpg", "images/ms3.jpg", "images/ms4.jpg" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "PhotoPath2", "PhotoPath3", "PhotoPath4" },
                values: new object[] { "images/fu2.jpg", "images/fu3.jpg", "images/fu4.jpg" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "PhotoPath2", "PhotoPath3", "PhotoPath4" },
                values: new object[] { "images/hp2.png", "images/hp3.png", "images/hp4.png" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "PhotoPath2", "PhotoPath3", "PhotoPath4" },
                values: new object[] { "images/msi2.jpg", "images/msi3.jpg", "images/msi4.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath2",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhotoPath3",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhotoPath4",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "thongtin",
                value: "i7, RAM 16GB ,SSD 512GB");
        }
    }
}
