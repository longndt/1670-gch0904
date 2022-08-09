using System.Collections;
using System.Collections.Generic;

namespace web11.Models
{
    //Relationship (OneToMany): Bank - Branch
    public class Bank
    {
        //thuộc tính riêng của model Bank
        public int Id { get; set; } // PK
        public string Name { get; set; }
        public string Type { get; set; }

        //set thuộc tính liên kết sang bảng Branch
        public ICollection<Branch> Branch { get; set; }
    
        //columns: id, name, type
    }
}
