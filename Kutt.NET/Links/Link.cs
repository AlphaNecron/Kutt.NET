using System;
using Newtonsoft.Json;

namespace Kutt.NET.Links
{
    /// <summary>
    /// Link Json Properties
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Link slug, eg: abc123
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; private set; }
        
        /// <summary>
        /// Link status
        /// </summary>
        [JsonProperty("banned")]
        public bool IsBanned { get; private set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; private set; }
        
        /// <summary>
        /// Link unique ID
        /// </summary>
        [JsonProperty("id")]
        public string Uuid { get; private set; }
        
        /// <summary>
        /// Shortened link
        /// </summary>
        [JsonProperty("link")]
        public string ShortUrl { get; private set; }
        
        /// <summary>
        /// Original link
        /// </summary>
        [JsonProperty("target")]
        public string LongUrl { get; private set; }
        
        /// <summary>
        /// Description of the link
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        
        /// <summary>
        /// Update date
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; private set; }
        
        /// <summary>
        /// Visit count
        /// </summary>
        [JsonProperty("visit_count")]
        public int Clicks { get; private set; }
    }
}
