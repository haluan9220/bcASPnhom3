﻿// <auto-generated />
using System;
using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagement.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "IT"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "HR"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Payroll"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "Admin"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBrith")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Gia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thongtin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DateOfBrith = new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "David@pragimtech.com",
                            FirstName = "John",
                            Gender = 0,
                            Gia = "23.999.000 VND",
                            LastName = "Dell G3 15 3500B i7 10750H/16GB/512GB/15.6 FHD / NV GTX1660Ti 6GB / Win 10",
                            PhotoPath = "images/1.jpg",
                            PhotoPath2 = "images/dell2.png",
                            PhotoPath3 = "images/dell3.png",
                            PhotoPath4 = "images/dell4.png",
                            thongtin = "i7, RAM 16GB ,SSD 512GB "
                        },
                        new
                        {
                            EmployeeId = 2,
                            DateOfBrith = new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            Email = "Sam@pragimtech.com",
                            FirstName = "Sam",
                            Gender = 0,
                            Gia = "24.999.000 VND",
                            LastName = "Laptop Asus Zenbook UX425EA KI429T i5 1135G7/8GB/512GB SSD/Win 10",
                            PhotoPath = "images/2.jpg",
                            PhotoPath2 = "images/asus2.png",
                            PhotoPath3 = "images/asus3.png",
                            PhotoPath4 = "images/asus4.png",
                            thongtin = "i5, RAM 8GB ,SSD 512GB"
                        },
                        new
                        {
                            EmployeeId = 3,
                            DateOfBrith = new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "mary@pragimtech.com",
                            FirstName = "Mary",
                            Gender = 1,
                            Gia = "23.999.000 VND",
                            LastName = "Laptop MSI Gaming GF65 10UE 286VN i5 10500H/16GB/512GB/15.6FHD/RTX 3060 Max-Q 6Gb/Win 10",
                            PhotoPath = "images/3.jpg",
                            PhotoPath2 = "images/ms2.jpg",
                            PhotoPath3 = "images/ms3.jpg",
                            PhotoPath4 = "images/ms4.jpg",
                            thongtin = "i5, RAM 16GB ,SSD 512GB"
                        },
                        new
                        {
                            EmployeeId = 4,
                            DateOfBrith = new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 3,
                            Email = "sara@pragimtech.com",
                            FirstName = "Sara",
                            Gender = 1,
                            Gia = "23.999.000 VND",
                            LastName = "Laptop Fujitsu CH 9C13A1 i5 1135G7/8GB/512GB/13.3 FHD / Win 10",
                            PhotoPath = "images/4.jpg",
                            PhotoPath2 = "images/fu2.jpg",
                            PhotoPath3 = "images/fu3.jpg",
                            PhotoPath4 = "images/fu4.jpg",
                            thongtin = "i5, RAM 8GB ,SSD 512GB"
                        },
                        new
                        {
                            EmployeeId = 5,
                            DateOfBrith = new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 3,
                            Email = "sara@pragimtech.com",
                            FirstName = "Sala",
                            Gender = 1,
                            Gia = "30.699.000 VND",
                            LastName = "Laptop HP Envy 13 ba1030TU i7 1165G7/8GB/512GB/13.3 FHD / Win 10",
                            PhotoPath = "images/9.jpg",
                            PhotoPath2 = "images/hp2.png",
                            PhotoPath3 = "images/hp3.png",
                            PhotoPath4 = "images/hp4.png",
                            thongtin = "i7, RAM 8GB ,HDD 512GB"
                        },
                        new
                        {
                            EmployeeId = 6,
                            DateOfBrith = new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 3,
                            Email = "sara@pragimtech.com",
                            FirstName = "Sara",
                            Gender = 1,
                            Gia = "29.999.000 VND",
                            LastName = "Laptop MSI Gaming Katana GF66 11UC 641VN i7 11800H/8GB/512GB/RTX 3050 4GB/Win 10",
                            PhotoPath = "images/10.jpg",
                            PhotoPath2 = "images/msi2.jpg",
                            PhotoPath3 = "images/msi3.jpg",
                            PhotoPath4 = "images/msi4.jpg",
                            thongtin = "i7, RAM 8GB ,SSD 512GB"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
