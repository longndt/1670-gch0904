﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using web10.Data;

namespace web10.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("web10.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg",
                            Name = "HR"
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg",
                            Name = "IT"
                        },
                        new
                        {
                            Id = 3,
                            Image = "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg",
                            Name = "Accounting"
                        },
                        new
                        {
                            Id = 4,
                            Image = "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg",
                            Name = "Security"
                        },
                        new
                        {
                            Id = 5,
                            Image = "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg",
                            Name = "Medical"
                        });
                });

            modelBuilder.Entity("web10.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            Id = 10,
                            Address = "Ha Noi - Viet Nam",
                            DepartmentId = 3,
                            Dob = new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "M",
                            Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg",
                            Mobile = "0912345678",
                            Name = "Minh",
                            Salary = 1000f
                        },
                        new
                        {
                            Id = 11,
                            Address = "Ha Noi - Viet Nam",
                            DepartmentId = 2,
                            Dob = new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "M",
                            Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg",
                            Mobile = "0912345678",
                            Name = "Minh",
                            Salary = 1000f
                        },
                        new
                        {
                            Id = 12,
                            Address = "Ha Noi - Viet Nam",
                            DepartmentId = 4,
                            Dob = new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "M",
                            Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg",
                            Mobile = "0912345678",
                            Name = "Minh",
                            Salary = 1000f
                        },
                        new
                        {
                            Id = 13,
                            Address = "Ha Noi - Viet Nam",
                            DepartmentId = 5,
                            Dob = new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "M",
                            Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg",
                            Mobile = "0912345678",
                            Name = "Minh",
                            Salary = 1000f
                        },
                        new
                        {
                            Id = 14,
                            Address = "Ha Noi - Viet Nam",
                            DepartmentId = 3,
                            Dob = new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "M",
                            Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg",
                            Mobile = "0912345678",
                            Name = "Minh",
                            Salary = 1000f
                        },
                        new
                        {
                            Id = 15,
                            Address = "Ha Noi - Viet Nam",
                            DepartmentId = 2,
                            Dob = new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "M",
                            Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg",
                            Mobile = "0912345678",
                            Name = "Minh",
                            Salary = 1000f
                        },
                        new
                        {
                            Id = 16,
                            Address = "Ha Noi - Viet Nam",
                            DepartmentId = 1,
                            Dob = new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "M",
                            Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg",
                            Mobile = "0912345678",
                            Name = "Minh",
                            Salary = 1000f
                        },
                        new
                        {
                            Id = 17,
                            Address = "Ha Noi - Viet Nam",
                            DepartmentId = 2,
                            Dob = new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "M",
                            Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg",
                            Mobile = "0912345678",
                            Name = "Minh",
                            Salary = 1000f
                        },
                        new
                        {
                            Id = 18,
                            Address = "Ha Noi - Viet Nam",
                            DepartmentId = 2,
                            Dob = new DateTime(1996, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "F",
                            Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg",
                            Mobile = "0912345678",
                            Name = "Minh",
                            Salary = 1000f
                        },
                        new
                        {
                            Id = 19,
                            Address = "Ha Noi - Viet Nam",
                            DepartmentId = 3,
                            Dob = new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "M",
                            Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg",
                            Mobile = "0912345678",
                            Name = "Minh",
                            Salary = 1000f
                        },
                        new
                        {
                            Id = 20,
                            Address = "Ha Noi - Viet Nam",
                            DepartmentId = 2,
                            Dob = new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "F",
                            Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg",
                            Mobile = "0912345678",
                            Name = "Minh",
                            Salary = 1000f
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("web10.Models.Staff", b =>
                {
                    b.HasOne("web10.Models.Department", "Department")
                        .WithMany("Staffs")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
