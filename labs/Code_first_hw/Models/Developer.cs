using System;
using System.Collections.Generic;
using System.Text;

namespace Code_first_hw.Models
{
    public class Developer
    {
        public Developer()
        {
            Games = new HashSet<Game>();
        }

        public int DeveloperId { get; set; }
        public string DevName { get; set; }
        public string DevDescription { get; set; }

        public virtual ICollection<Game> Games { get; set; }

    }
}
