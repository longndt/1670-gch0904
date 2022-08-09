﻿using System.Collections.Generic;

namespace web11.Models
{
    //relationship (ManyToMany): Student-Course
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Email { get; set; }

        public ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
