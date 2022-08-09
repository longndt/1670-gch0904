namespace web11.Models
{
    //relationship (OneToOne): Capital - Country
    public class Capital
    {
        public int Id { get; set; }  //PK
        public string Name { get; set; }

        public float Area { get; set; }

        //set mối quan hệ FK-PK trong bảng của database
        public int CountryId { get; set; }

        //thuộc tính liên kết (dùng truy xuất trong code)
        public Country Country { get; set; }
    }
}
