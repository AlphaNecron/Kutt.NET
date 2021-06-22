using System;
using Newtonsoft.Json;

namespace Kutt.NET.Links
{
    public class Link
    {
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
        ///     Shortened link
        /// </summary>
        [JsonProperty("link")]
        public string ShortUrl { get; private set; }

        /// <summary>
        ///     Original link (long)
        /// </summary>
        [JsonProperty("target")]
        public string LongUrl { get; private set; }

        /// <summary>
        ///     Description of the link
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        ///     Link's update date
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        ///     Link's visit count
        /// </summary>
        [JsonProperty("visit_count")]
        public int Clicks { get; private set; }
    }
}