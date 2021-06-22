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
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public string Uuid { get; private set; }
        
        /// <summary>
        /// Created At
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; private set; }
        
        /// <summary>
        /// Link Homepage
        /// </summary>
        [JsonProperty("homepage")]
        public string Homepage { get; private set; }
        
        /// <summary>
        /// Updated At
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; private set; }
    }
}
