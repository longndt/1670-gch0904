namespace web3.Models
{
    public class Mobile
    {
        public int Id { get; set; }  //Primary key, auto increment
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
    }
}
