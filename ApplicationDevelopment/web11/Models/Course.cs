﻿using System.Collections;
using System.Collections.Generic;

namespace web11.Models
{
    //Relationship (ManyToMany) : Student-Course
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public ICollection<StudentCourse> StudentCourse { get; set; }
        
    }
}
