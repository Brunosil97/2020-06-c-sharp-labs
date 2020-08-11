using System;
using System.Collections.Generic;
using System.Text;

namespace Code_first_hw.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public int? DeveloperId { get; set; }

        public virtual Developer Developer { get; set; }

   
    }
}
