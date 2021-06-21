using System;
using Newtonsoft.Json;

namespace Kutt.NET.Links.LinkStats
{
    public class LinkStats
    {
        [JsonProperty("allTime")]
        public StatsItem AllTime { get; private set; }

        [JsonProperty("lastDay")]
        public StatsItem LastDay { get; private set; }

        [JsonProperty("lastWeek")]
        public StatsItem LastWeek { get; private set; }

        [JsonProperty("lastMonth")]
        public StatsItem LastMonth { get; private set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; private set; }

        [JsonProperty("address")]
        public string Address { get; private set; }

        [JsonProperty("banned")]
        public bool IsBanned { get; private set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; private set; }

        [JsonProperty("id")]
        public string Uuid { get; private set; }

        [JsonProperty("password")]
        public bool HasPassword { get; private set; }

        [JsonProperty("target")]
        public string Target { get; private set; }

        [JsonProperty("visit_count")]
        public int Clicks { get; private set; }
    }
}