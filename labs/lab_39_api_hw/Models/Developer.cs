using System;
using System.Collections.Generic;

namespace gameDev_api.Models
{
    public partial class Developer
    {
        public Developer()
        {
            Games = new HashSet<Games>();
        }

        public int DevId { get; set; }
        public string DevName { get; set; }
        public string DevDescription { get; set; }

        public virtual ICollection<Games> Games { get; set; }
    }
}
