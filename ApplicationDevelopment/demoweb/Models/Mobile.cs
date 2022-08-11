using System.ComponentModel.DataAnnotations;

namespace demoweb.Models
{
    public enum Color
    {
        Black,
        White,
        Grey,
        Yellow,
        Blue
    }
    //Mobile - Brand : Many to One
    public class Mobile
    {
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "Mobile name must be at least 3 characters")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Range(1, 100)]
        public int Quantity { get; set; }

        public double Price { get; set; }

        [Required]
        public Color Color { get; set; }

        [Url]
        public string Image { get; set; }

        public Brand Brand { get; set; }
        

        [Display(Name = "Brand name")]
        public int BrandId { get; set; }
    }
}
