namespace web11.Models
{
    //relationship (OneToOne): Country - Capital
    public class Country
    {
        public int Id { get; set; }   //PK
        public string Name { get; set; }
        public int Population { get; set; }
        
        //thuộc tính liên kết
        public Capital Capital { get; set; }
    }
}
