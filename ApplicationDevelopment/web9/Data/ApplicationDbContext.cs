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
    }
}
