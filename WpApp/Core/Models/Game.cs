using System.Collections.Generic;

namespace WpApp.Core.Models
{
    public class Game
    {
        public string Id { get; set; }
        public string Opponent { get; set; }
        public string OpponentLogo { get; set; }
        public string GameDate { get; set; }
        public string GameTime { get; set; }
        public string TvNetwork { get; set; }
        public string TeamId { get; set; }

        public Team Team { get; set; }
        public List<Event> Events { get; set; }
    }
}
