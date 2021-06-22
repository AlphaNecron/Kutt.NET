using System;
using Newtonsoft.Json;

namespace Kutt.NET.Links.LinkStats
{
    /// <summary>
    /// Json Properties for LinkStats.cs
    /// </summary>
    public class LinkStats
    {
        /// <summary>
        /// All Time
        /// </summary>
        [JsonProperty("allTime")]
        public StatsItem AllTime { get; private set; }
        
        /// <summary>
        /// Last Day
        /// </summary>
        [JsonProperty("lastDay")]
        public StatsItem LastDay { get; private set; }
        
        /// <summary>
        /// Last Week
        /// </summary>
        [JsonProperty("lastWeek")]
        public StatsItem LastWeek { get; private set; }
        
        /// <summary>
        /// Last Month
        /// </summary>
        [JsonProperty("lastMonth")]
        public StatsItem LastMonth { get; private set; }
        
        /// <summary>
        /// Updated At
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; private set; }
        
        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; private set; }
        
        /// <summary>
        /// Domain Banned
        /// </summary>
        [JsonProperty("banned")]
        public bool IsBanned { get; private set; }
        
        /// <summary>
        /// CreatedAt
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; private set; }
        
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public string Uuid { get; private set; }
        
        /// <summary>
        /// Password
        /// </summary>
        [JsonProperty("password")]
        public bool HasPassword { get; private set; }
        
        /// <summary>
        /// Target
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; private set; }
        
        /// <summary>
        /// Visit Counts
        /// </summary>
        [JsonProperty("visit_count")]
        public int Clicks { get; private set; }
    }
}
