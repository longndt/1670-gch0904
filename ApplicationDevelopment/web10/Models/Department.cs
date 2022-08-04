using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web10.Models
{
    public class Department
    {
        public int Id { get; set; } //Primary key (auto increment)

        [Required]
        public string Name { get; set; }

        [Url]
        public string Image { get; set; }
        
        public ICollection<Staff> Staffs { get; set; } //dùng để truy xuất sang bảng Staff

        //relationship: One (Department) To Many (Staff)
    }
}