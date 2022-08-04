using System;
using System.ComponentModel.DataAnnotations;

namespace web10.Models
{
    public class Staff
    {
        public int Id { get; set; }  //Primary key

        [StringLength(30, ErrorMessage = "Max length for name is 30 characters", MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

        [MinLength(5, ErrorMessage = "Address must be at least 5 characters")]
        [MaxLength(50, ErrorMessage = "Address can not be over 50 characters")]
        public string Address { get; set; }

        [Required]
        public char Gender { get; set; }

        [Range(100, 2000)]
        public float Salary { get; set; }

        [MinLength(10)]
        [MaxLength(10)]
        [Phone]
        public string Mobile { get; set; }

        [Url]
        public string Image { get; set; }

        public int DepartmentId { get; set; }  //Foreign key (link to Primary key in table Department)

        public Department Department { get; set; }  //dùng để truy xuất đến dữ liệu của bảng Department
        
        //relationship: Many (Staff) To One (Department)
    }
}
