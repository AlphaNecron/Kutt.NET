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
        /// Domain Address
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; private set; }
        
        /// <summary>
        /// Domain Banned
        /// </summary>
        [JsonProperty("banned")]
        public bool IsBanned { get; private set; }

        /// <summary>
        /// Domain CreatedAt
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; private set; }
        
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Uuid { get; private set; }
        
        /// <summary>
        /// Link
        /// </summary>
        [JsonProperty("link")]
        public string ShortUrl { get; private set; }
        
        /// <summary>
        /// Target Domain
        /// </summary>
        [JsonProperty("target")]
        public string LongUrl { get; private set; }
        
        /// <summary>
        /// Description of the link
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        
        /// <summary>
        /// Updated at
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; private set; }
        
        /// <summary>
        /// Visit Count
        /// </summary>
        [JsonProperty("visit_count")]
        public int Clicks { get; private set; }
    }
}
