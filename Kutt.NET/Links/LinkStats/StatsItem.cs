using Newtonsoft.Json;

namespace Kutt.NET.Links.LinkStats
{
    /// <summary>
    ///     Json Properties for StatsItem
    /// </summary>
    public class StatsItem
    {
        /// <summary>
        ///     Stats
        /// </summary>
        [JsonProperty("stats")]
        public Stats Stats { get; private set; }

        /// <summary>
        ///     View count
        /// </summary>
        [JsonProperty("views")]
        public int[] Views { get; private set; }
    }
}