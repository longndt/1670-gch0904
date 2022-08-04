using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using web9.Models;

namespace web9.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //tự tạo ra bảng Mobile trong DB
        //tương tác với dữ liệu của bảng Mobile thông qua DbSet
        public DbSet<Mobile> Mobile { get; set; }

        //add dữ liệu ban đầu tự động bằng code bằng hàm OnModelCreating
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //add dữ liệu cho bảng Mobile
            //lưu ý: cần phải set dữ liệu cho Id (Primary Key)
            builder.Entity<Mobile>().HasData(
                new Mobile { Id = 1, Name ="iPhone 13 Pro Max", Price = 1299, Quantity = 5, Brand = "Apple",
                    Color = "Black", BestSeller = true, Image = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-13-pro-max-blue-witb-202109_FMT_WHH?wid=560&hei=744&fmt=jpeg&qlt=90&.v=1638577686000",
                    Date = DateTime.Parse("05/06/2022")
                },
                new Mobile { Id = 2, Name ="iPhone 12 Pro Max", Price = 1499, Quantity = 5, Brand = "Apple",
                    Color = "Black", BestSeller = true, Image = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-13-pro-max-blue-witb-202109_FMT_WHH?wid=560&hei=744&fmt=jpeg&qlt=90&.v=1638577686000",
                    Date = DateTime.Now.Date    
                },
                new Mobile { Id = 3, Name ="iPhone 13 Pro Max", Price = 1199, Quantity = 5, Brand = "Apple",
                    Color = "Black", BestSeller = true, Image = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-13-pro-max-blue-witb-202109_FMT_WHH?wid=560&hei=744&fmt=jpeg&qlt=90&.v=1638577686000",
                    Date = DateTime.Today.Date  
                },
                new Mobile { Id = 4, Name ="iPhone Pro Max", Price = 1099, Quantity = 5, Brand = "Apple",
                    Color = "Black", BestSeller = true, Image = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-13-pro-max-blue-witb-202109_FMT_WHH?wid=560&hei=744&fmt=jpeg&qlt=90&.v=1638577686000",
                    Date = DateTime.Now.Date
                },
                new Mobile { Id = 5, Name ="iPhone 11 Pro Max", Price = 1599, Quantity = 5, Brand = "Apple",
                    Color = "Blue", BestSeller = true, Image = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-13-pro-max-blue-witb-202109_FMT_WHH?wid=560&hei=744&fmt=jpeg&qlt=90&.v=1638577686000",
                    Date = DateTime.Now.Date        
                }
            );
        }
    }
}
