using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using web10.Models;

namespace web10.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //tạo bảng
        public DbSet<Department> Departments { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        //add dữ liệu vào bảng
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            PopulateDepartment(builder);
            PopulateStaff(builder);
        }

        private void PopulateStaff(ModelBuilder builder)
        {
            builder.Entity<Staff>().HasData(
                new Staff
                {
                    Id = 10,
                    Name = "Minh",
                    Gender = 'M',
                    Mobile = "0912345678",
                    Address = "Ha Noi - Viet Nam",
                    Salary = 1000,
                    Dob = DateTime.Parse("12/09/1996"),
                    DepartmentId = 3,
                    Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg"
                },
                new Staff
                {
                    Id = 11,
                    Name = "Minh",
                    Gender = 'M',
                    Mobile = "0912345678",
                    Address = "Ha Noi - Viet Nam",
                    Salary = 1000,
                    Dob = DateTime.Parse("12/09/1996"),
                    DepartmentId = 2,
                    Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg"
                },
                new Staff
                {
                    Id = 12,
                    Name = "Minh",
                    Gender = 'M',
                    Mobile = "0912345678",
                    Address = "Ha Noi - Viet Nam",
                    Salary = 1000,
                    Dob = DateTime.Parse("12/09/1996"),
                    DepartmentId = 4,
                    Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg"
                },
                new Staff
                {
                    Id = 13,
                    Name = "Minh",
                    Gender = 'M',
                    Mobile = "0912345678",
                    Address = "Ha Noi - Viet Nam",
                    Salary = 1000,
                    Dob = DateTime.Parse("12/09/1996"),
                    DepartmentId = 5,
                    Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg"
                },
                new Staff
                {
                    Id = 14,
                    Name = "Minh",
                    Gender = 'M',
                    Mobile = "0912345678",
                    Address = "Ha Noi - Viet Nam",
                    Salary = 1000,
                    Dob = DateTime.Parse("12/09/1996"),
                    DepartmentId = 3,
                    Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg"
                },
                new Staff
                {
                    Id = 15,
                    Name = "Minh",
                    Gender = 'M',
                    Mobile = "0912345678",
                    Address = "Ha Noi - Viet Nam",
                    Salary = 1000,
                    Dob = DateTime.Parse("12/09/1996"),
                    DepartmentId = 2,
                    Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg"
                },
                new Staff
                {
                    Id = 16,
                    Name = "Minh",
                    Gender = 'M',
                    Mobile = "0912345678",
                    Address = "Ha Noi - Viet Nam",
                    Salary = 1000,
                    Dob = DateTime.Parse("12/09/1996"),
                    DepartmentId = 1,
                    Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg"
                },
                    new Staff
                    {
                        Id = 17,
                        Name = "Minh",
                        Gender = 'M',
                        Mobile = "0912345678",
                        Address = "Ha Noi - Viet Nam",
                        Salary = 1000,
                        Dob = DateTime.Parse("12/09/1996"),
                        DepartmentId = 2,
                        Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg"
                    },
                    new Staff
                    {
                        Id = 18,
                        Name = "Minh",
                        Gender = 'F',
                        Mobile = "0912345678",
                        Address = "Ha Noi - Viet Nam",
                        Salary = 1000,
                        Dob = DateTime.Parse("12/05/1996"),
                        DepartmentId = 2,
                        Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg"
                    },
                    new Staff
                    {
                        Id = 19,
                        Name = "Minh",
                        Gender = 'M',
                        Mobile = "0912345678",
                        Address = "Ha Noi - Viet Nam",
                        Salary = 1000,
                        Dob = DateTime.Parse("12/09/1996"),
                        DepartmentId = 3,
                        Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg"
                    },
                    new Staff
                    {
                        Id = 20,
                        Name = "Minh",
                        Gender = 'F',
                        Mobile = "0912345678",
                        Address = "Ha Noi - Viet Nam",
                        Salary = 1000,
                        Dob = DateTime.Parse("12/09/1996"),
                        DepartmentId = 2,
                        Image = "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg"
                    }
            );
            //throw new NotImplementedException();
        }

        private void PopulateDepartment(ModelBuilder builder)
        {
            builder.Entity<Department>().HasData(
                new Department
                {
                    Id = 1,
                    Name = "HR",
                    Image = "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg"
                },
                 new Department
                 {
                     Id = 2,
                     Name = "IT",
                     Image = "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg"
                 },
                  new Department
                  {
                      Id = 3,
                      Name = "Accounting",
                      Image = "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg"
                  },
                   new Department
                   {
                       Id = 4,
                       Name = "Security",
                       Image = "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg"
                   },
                    new Department
                    {
                        Id = 5,
                        Name = "Medical",
                        Image = "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg"
                    }
                );
            //throw new NotImplementedException();
        }
    }
}
