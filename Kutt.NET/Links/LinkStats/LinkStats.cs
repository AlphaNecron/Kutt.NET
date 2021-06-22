using System;
using Newtonsoft.Json;

namespace Kutt.NET.Links.LinkStats
{
    /// <summary>
    ///     Json Properties for LinkStats.cs
    /// </summary>
    public class LinkStats
    {
        /// <summary>
        ///     All time stats
        /// </summary>
        [JsonProperty("allTime")]
        public StatsItem AllTime { get; private set; }

        /// <summary>
        ///     Last day's stats
        /// </summary>
        [JsonProperty("lastDay")]
        public StatsItem LastDay { get; private set; }

        /// <summary>
        ///     Last week's stats
        /// </summary>
        [JsonProperty("lastWeek")]
        public StatsItem LastWeek { get; private set; }

        /// <summary>
        ///     Last month's stats
        /// </summary>
        [JsonProperty("lastMonth")]
        public StatsItem LastMonth { get; private set; }

        /// <summary>
        ///     Update date
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        ///     Link's slug, eg: abc123
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; private set; }

        /// <summary>
        ///     Link's status
        /// </summary>
        [JsonProperty("banned")]
        public bool IsBanned { get; private set; }

        /// <summary>
        ///     Link's creation date
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        ///     Link's unique ID
        /// </summary>
        [JsonProperty("id")]
        public string Uuid { get; private set; }

        /// <summary>
        ///     Has password
        /// </summary>
        [JsonProperty("password")]
        public bool HasPassword { get; private set; }

        /// <summary>
        ///     Shortened link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; private set; }

        /// <summary>
        ///     Original link (long)
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; private set; }

        /// <summary>
        ///     Visit Counts
        /// </summary>
        [JsonProperty("visit_count")]
        public int Clicks { get; private set; }
    }
}