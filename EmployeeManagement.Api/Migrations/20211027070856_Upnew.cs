using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class Upnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBrith", "DepartmentId", "Email", "FirstName", "Gender", "Gia", "LastName", "PhotoPath", "thongtin" },
                values: new object[] { 5, new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "sara@pragimtech.com", "Sala", 1, "30.699.000 VND", "Laptop HP Envy 13 ba1030TU i7 1165G7/8GB/512GB/13.3 FHD / Win 10", "images/9.jpg", "i7, RAM 8GB ,HDD 512GB" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBrith", "DepartmentId", "Email", "FirstName", "Gender", "Gia", "LastName", "PhotoPath", "thongtin" },
                values: new object[] { 6, new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "sara@pragimtech.com", "Sara", 1, "29.999.000 VND", "Laptop MSI Gaming Katana GF66 11UC 641VN i7 11800H/8GB/512GB/RTX 3050 4GB/Win 10", "images/10.jpg", "i7, RAM 8GB ,SSD 512GB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);
        }
    }
}
