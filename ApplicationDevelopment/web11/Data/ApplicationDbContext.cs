using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using web11.Models;

namespace web11.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //tạo bảng từ Model
        //One To Many
        public DbSet<Bank> Bank { get; set; }
        public DbSet<Branch> Branch { get; set; }

        //One To One
        public DbSet<Country> Country { get; set; }
        public DbSet<Capital> Capital { get; set; }

        //Many To Many
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //add dữ liệu ban đầu cho cácbảng
            SeedBank(builder);
            SeedBranch(builder);
            SeedCountry(builder);
            SeedCapital(builder);
            SeedStudent(builder);
            SeedCourse(builder);

            //set key cho bảng StudentCourse  
            builder.Entity<StudentCourse>().HasKey(s => new { s.StudentId, s.CourseId });

            //add dữ liệu cho bảng StudentCourse
            SeedStudentCourse(builder);
        }

        private void SeedCapital(ModelBuilder builder)
        {
            builder.Entity<Capital>().HasData(
                new Capital { Id = 1, Name = "Hà Nội", CountryId = 1 },
                new Capital { Id = 2, Name = "Hà Nội", CountryId = 2 },
                new Capital { Id = 3, Name = "Hà Nội", CountryId = 5 },
                new Capital { Id = 4, Name = "Hà Nội", CountryId = 3 },
                new Capital { Id = 5, Name = "Hà Nội", CountryId = 4 }
                );
        }

        private void SeedStudentCourse(ModelBuilder builder)
        {
            builder.Entity<StudentCourse>().HasData(
                new StudentCourse { StudentId = 1, CourseId = 1 },
                new StudentCourse { StudentId = 2, CourseId = 1 },
                new StudentCourse { StudentId = 3, CourseId = 2 },
                new StudentCourse { StudentId = 4, CourseId = 4 },
                new StudentCourse { StudentId = 3, CourseId = 3 }
               );
        }

        private void SeedCourse(ModelBuilder builder)
        {
            builder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "C#", Description = "C# course" },
                new Course { Id = 2, Name = "C#", Description = "C# course" },
                new Course { Id = 3, Name = "C#", Description = "C# course" },
                new Course { Id = 4, Name = "C#", Description = "C# course" },
                new Course { Id = 5, Name = "C#", Description = "C# course" }
                );
        }

        private void SeedStudent(ModelBuilder builder)
        {
            builder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Minh Tuan", Email = "tuan@fpt.edu.vn" },
                new Student { Id = 2, Name = "Minh Tuan", Email = "tuan@fpt.edu.vn" },
                new Student { Id = 3, Name = "Minh Tuan", Email = "tuan@fpt.edu.vn" },
                new Student { Id = 4, Name = "Minh Tuan", Email = "tuan@fpt.edu.vn" },
                new Student { Id = 5, Name = "Minh Tuan", Email = "tuan@fpt.edu.vn" }
                );
        }

        private void SeedCountry(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Viet Nam", Population = 100000000 },
                new Country { Id = 2, Name = "Viet Nam", Population = 100000000 },
                new Country { Id = 3, Name = "Viet Nam", Population = 100000000 },
                new Country { Id = 4, Name = "Viet Nam", Population = 100000000 },
                new Country { Id = 5, Name = "Viet Nam", Population = 100000000 }
                );
        }

        private void SeedBranch(ModelBuilder builder)
        {
            builder.Entity<Branch>().HasData(
                new Branch { Id = 1, Name = "Cau Giay", Address = "2 Pham Van Bach", BankId = 1 },
                new Branch { Id = 2, Name = "Cau Giay", Address = "2 Pham Van Bach", BankId = 2 },
                new Branch { Id = 3, Name = "Cau Giay", Address = "2 Pham Van Bach", BankId = 3 },
                new Branch { Id = 4, Name = "Cau Giay", Address = "2 Pham Van Bach", BankId = 2 },
                new Branch { Id = 5, Name = "Cau Giay", Address = "2 Pham Van Bach", BankId = 1 }
                );
        }

        private void SeedBank(ModelBuilder builder)
        {
            builder.Entity<Bank>().HasData(
                new Bank { Id = 1, Name = "Vietcombank", Type = "National" },
                new Bank { Id = 2, Name = "Vietcombank", Type = "National" },
                new Bank { Id = 3, Name = "Vietcombank", Type = "National" },
                new Bank { Id = 4, Name = "Vietcombank", Type = "National" },
                new Bank { Id = 5, Name = "Vietcombank", Type = "National" }
                );
        }
    }
}
