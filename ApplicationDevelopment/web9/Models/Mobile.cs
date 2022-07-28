namespace web9.Models
{
    public class Mobile
    {
        public int Id { get; set; } //primary key - auto increment (start from 1)
        public string Name { get; set; }
        
        public string Brand { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }
    }
}
