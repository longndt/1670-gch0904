using demoweb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace demoweb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //tạo bảng
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Mobile> Mobile { get; set; }
        public DbSet<Country> Country { get; set; }

        //add dữ liệu ban đầu cho bảng
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedCountry(builder);
            SeedBrand(builder);
            SeedMobile(builder);
            //add dữ liệu cho 3 bảng: User, Role, UserRole => Authentication (Login/Logout) + Authorization (Role Assign)
            SeedUser(builder);
            SeedRole(builder);
            SeedUserRole(builder);
        }

        private void SeedCountry(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Korea" },
                new Country { Id = 2, Name = "USA" },
                new Country { Id = 3, Name = "China" }
                );
        }

        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "1"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "2"
                }
            );
        }

        private void SeedRole(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Customer"
                }
            );
        }

        private void SeedUser(ModelBuilder builder)
        {
            //tạo tài khoản test cho admin & customer
            var admin = new IdentityUser
            {
                Id = "1",
                Email = "admin@gmail.com",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com"
            };
            var customer = new IdentityUser
            {
                Id = "2",
                Email = "customer@gmail.com",
                UserName = "customer@gmail.com",
                NormalizedUserName = "customer@gmail.com"
            };

            //khai báo thư viện để mã hóa mật khẩu cho user
            var hasher = new PasswordHasher<IdentityUser>();

            //set mật khẩu đã mã hóa cho từng user
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");

            //add 2 tài khoản test vào bảng User
            builder.Entity<IdentityUser>().HasData(admin, customer);  
        }

        private void SeedMobile(ModelBuilder builder)
        {
            builder.Entity<Mobile>().HasData(
                new Mobile
                {
                    Id = 1,
                    Name = "Galaxy S22 Ultra",
                    Color = Color.Black,
                    Price = 999.99,
                    Quantity = 10,
                    BrandId = 1,
                    Image = "https://images.samsung.com/vn/smartphones/galaxy-s22-ultra/images/galaxy-s22-ultra_jump_models_s.png"
                },
                  new Mobile
                  {
                      Id = 2,
                      Name = "Galaxy S22 Ultra",
                      Color = Color.Black,
                      Price = 999.99,
                      Quantity = 30,
                      BrandId = 1,
                      Image = "https://images.samsung.com/vn/smartphones/galaxy-s22-ultra/images/galaxy-s22-ultra_jump_models_s.png"
                  },
                    new Mobile
                    {
                        Id = 3,
                        Name = "Galaxy S22 Ultra",
                        Color = Color.Black,
                        Price = 999.99,
                        Quantity = 20,
                        BrandId = 1,
                        Image = "https://images.samsung.com/vn/smartphones/galaxy-s22-ultra/images/galaxy-s22-ultra_jump_models_s.png"
                    },
                      new Mobile
                      {
                          Id = 4,
                          Name = "iPhone 13 Pro Max",
                          Color = Color.Blue,
                          Price = 1299.99,
                          Quantity = 50,
                          BrandId = 2,
                          Image = "https://cdn.hoanghamobile.com/i/productlist/dsp/Uploads/2021/09/15/image-removebg-preview-15.png"
                      },
                          new Mobile
                          {
                              Id = 5,
                              Name = "iPhone 13 Pro Max",
                              Color = Color.Blue,
                              Price = 1299.99,
                              Quantity = 40,
                              BrandId = 2,
                              Image = "https://cdn.hoanghamobile.com/i/productlist/dsp/Uploads/2021/09/15/image-removebg-preview-15.png"
                          },
                              new Mobile
                              {
                                  Id = 6,
                                  Name = "iPhone 13 Pro Max",
                                  Color = Color.Blue,
                                  Price = 1299.99,
                                  Quantity = 20,
                                  BrandId = 2,
                                  Image = "https://cdn.hoanghamobile.com/i/productlist/dsp/Uploads/2021/09/15/image-removebg-preview-15.png"
                              }
            );
            //throw new NotImplementedException();
        }

        private void SeedBrand(ModelBuilder builder)
        {
            builder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Samsung" , CountryId = 1},
                new Brand { Id = 2, Name = "Apple" , CountryId = 2 },
                new Brand { Id = 3, Name = "Xiaomi" , CountryId = 3 }
             );
            // throw new NotImplementedException();
        }
    }
}
