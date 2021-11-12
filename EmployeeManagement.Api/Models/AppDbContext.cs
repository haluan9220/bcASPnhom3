using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            // Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Dell G3 15 3500B i7 10750H/16GB/512GB/15.6 FHD / NV GTX1660Ti 6GB / Win 10",
                Email = "David@pragimtech.com",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                Gia = "23.999.000 VND",
                thongtin= "i7, RAM 16GB ,SSD 512GB ",
                PhotoPath = "images/1.jpg",
                PhotoPath2 = "images/dell2.png",
                PhotoPath3 = "images/dell3.png",
                PhotoPath4 = "images/dell4.png"

            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Laptop Asus Zenbook UX425EA KI429T i5 1135G7/8GB/512GB SSD/Win 10",
                Email = "Sam@pragimtech.com",
                DateOfBrith = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 2,
                Gia = "24.999.000 VND",
                thongtin = "i5, RAM 8GB ,SSD 512GB",
                PhotoPath = "images/2.jpg",
               PhotoPath2 = "images/asus2.png",
                PhotoPath3 = "images/asus3.png",
                PhotoPath4 = "images/asus4.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Laptop MSI Gaming GF65 10UE 286VN i5 10500H/16GB/512GB/15.6FHD/RTX 3060 Max-Q 6Gb/Win 10",
                Email = "mary@pragimtech.com",
                DateOfBrith = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                DepartmentId = 1,
                Gia = "23.999.000 VND",
                thongtin = "i5, RAM 16GB ,SSD 512GB",
                PhotoPath = "images/3.jpg",
                PhotoPath2 = "images/ms2.jpg",
                PhotoPath3 = "images/ms3.jpg",
                PhotoPath4 = "images/ms4.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Sara",
                LastName = "Laptop Fujitsu CH 9C13A1 i5 1135G7/8GB/512GB/13.3 FHD / Win 10",
                Email = "sara@pragimtech.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                DepartmentId = 3,
                Gia = "23.999.000 VND",
                thongtin = "i5, RAM 8GB ,SSD 512GB",
                PhotoPath = "images/4.jpg",
                PhotoPath2 = "images/fu2.jpg",
                PhotoPath3 = "images/fu3.jpg",
                PhotoPath4 = "images/fu4.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                FirstName = "Sala",
                LastName = "Laptop HP Envy 13 ba1030TU i7 1165G7/8GB/512GB/13.3 FHD / Win 10",
                Email = "sara@pragimtech.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                DepartmentId = 3,
                Gia = "30.699.000 VND",
                thongtin = "i7, RAM 8GB ,HDD 512GB",
                PhotoPath = "images/9.jpg",
                PhotoPath2 = "images/hp2.png",
                PhotoPath3 = "images/hp3.png",
                PhotoPath4 = "images/hp4.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 6,
                FirstName = "Sara",
                LastName = "Laptop MSI Gaming Katana GF66 11UC 641VN i7 11800H/8GB/512GB/RTX 3050 4GB/Win 10",
                Email = "sara@pragimtech.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                DepartmentId = 3,
                Gia = "29.999.000 VND",
                thongtin = "i7, RAM 8GB ,SSD 512GB",
                PhotoPath = "images/10.jpg",
                PhotoPath2 = "images/msi2.jpg",
                PhotoPath3 = "images/msi3.jpg",
                PhotoPath4 = "images/msi4.jpg"
            });
        }
    }
}
