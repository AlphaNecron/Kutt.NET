using Newtonsoft.Json;

namespace Kutt.NET.Links.LinkStats
{
    public class StatsItem
    {
        [JsonProperty("stats")]
        public Stats Stats { get; private set; }

        [JsonProperty("views")]
        public int[] Views { get; private set; }
    }
}