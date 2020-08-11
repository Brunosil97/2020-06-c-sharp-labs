using System;
using System.Collections.Generic;

namespace GameBackend.Models
{
    public partial class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public string Console { get; set; }
        public string ImageUrl { get; set; }
    }
}
