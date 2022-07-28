using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web8.Models
{
    public class Employee
    {
        [StringLength(30)]
        public string Name { get; set; }

        [Range(18,55)]
        public int Age { get; set; }

        [MinLength(5)]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }
        public float Salary { get; set; }

        public string Department { get; set; }

        public List<string> Strength { get; set; }
     
    }
}
