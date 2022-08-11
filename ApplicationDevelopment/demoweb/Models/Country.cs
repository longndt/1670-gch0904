﻿using System.Collections.Generic;

namespace demoweb.Models
{
    //Country - Brand: 1 to Many
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Brand> Brands { get; set; }
    }
}