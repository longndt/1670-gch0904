using System.ComponentModel.DataAnnotations;

namespace web5.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(20, ErrorMessage = "Max length for name is 20 characters")]
        public string Name { get; set; }

        [MinLength(10)]
        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Range(1,1000)]
        public int Quantity { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Color { get; set; }
    }
}
