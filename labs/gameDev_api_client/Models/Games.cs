using System;
using System.Collections.Generic;
using System.Text;

namespace gameDev_api_client.Models
{
    public partial class Games
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public int? DevId { get; set; }

        public virtual Developer Dev { get; set; }

        public override string ToString()
        {
            return $"{GameName}: {GameDescription}";
        }
    }
}
