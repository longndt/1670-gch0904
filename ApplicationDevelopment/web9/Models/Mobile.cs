using System;
using System.ComponentModel.DataAnnotations;

namespace web9.Models
{
    public enum Color
    {
        Red, 
        Blue,
        Yellow,
        Green,
        White,
        Silver
    }
    public class Mobile
    {
        public int Id { get; set; } //primary key - auto increment (start from 1)

        [MinLength(5, ErrorMessage = "Mobile Name must be at least 5 characters")]
        [MaxLength(30, ErrorMessage = "Mobile Name can not be over 30 characters")]
        public string Name { get; set; }

        [StringLength(20,ErrorMessage = "Max length for brand name is 20 characters",MinimumLength = 3)]
        public string Brand { get; set; }

        public string Color { get; set; }
        
        [Required]
        public decimal Price { get; set; }

        [Url]
        public string Image { get; set; }

        [Range(1, 50)]
        public int Quantity { get; set; }


        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public bool BestSeller { get; set; }
    }
}
