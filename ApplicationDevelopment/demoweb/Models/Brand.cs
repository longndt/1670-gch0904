﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace demoweb.Models
{
    //Brand - Mobile : 1 to Many
    public class Brand
    {
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        
        public ICollection<Mobile> Mobiles { get; set; }
    }
}