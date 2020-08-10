﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab_40_entity_code_first.Models
{
    class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime DateOFBirth { get; set; }
        
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
       
    }

}
