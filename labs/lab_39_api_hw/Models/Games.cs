using System;
using System.Collections.Generic;

namespace gameDev_api.Models
{
    public partial class Games
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public int? DevId { get; set; }

        public virtual Developer Dev { get; set; }
    }
}
