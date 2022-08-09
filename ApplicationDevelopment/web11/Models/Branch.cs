using System.ComponentModel.DataAnnotations;

namespace web11.Models
{
    //Relationship (ManyToOne): Branch - Bank
    public class Branch
    {
        //thuộc tính riêng của model Branch => cột trong bảng Branch
        public int Id { get; set; } //PK
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }

        //set thuộc tính liên kết sang bảng Bank
        public int BankId { get; set; } //FK
        public Bank Bank { get; set; }

        //columns: id, name, address, bankid
    }
}
