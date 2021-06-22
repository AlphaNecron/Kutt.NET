using System;
using Newtonsoft.Json;

namespace Kutt.NET.Domains
{
    /// <summary>
    /// Json Properties for Domain
    /// </summary>
    public class Domain
    {
        /// <summary>
        /// Domain address
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; private set; }
        
        /// <summary>
        /// Domain status
        /// </summary>
        [JsonProperty("banned")]
        public bool IsBanned { get; private set; }
        
        /// <summary>
        /// Domain unique ID
        /// </summary>
        [JsonProperty("id")]
        public string Uuid { get; private set; }
        
        /// <summary>
        /// Creation date
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; private set; }
        
        /// <summary>
        /// Domain homepage
        /// </summary>
        [JsonProperty("homepage")]
        public string Homepage { get; private set; }
        
        /// <summary>
        /// Update date
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; private set; }
    }
}
