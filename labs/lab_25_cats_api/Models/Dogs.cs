using System;
using System.Collections.Generic;

namespace lab_25_cats_api.Models
{
    public partial class Dogs
    {
        public int DogId { get; set; }
        public string DogName { get; set; }
        public int? Age { get; set; }
        public string DogDescription { get; set; }
    }
}
