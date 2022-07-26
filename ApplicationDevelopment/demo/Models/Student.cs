using System.ComponentModel.DataAnnotations;

namespace demo.Models
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(30, ErrorMessage = "Max is 30")]
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public string Gender { get; set; }
        
        public bool IsGraduated { get; set; }

    }
}
