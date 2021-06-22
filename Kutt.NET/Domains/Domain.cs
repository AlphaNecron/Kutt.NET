using System;
using Newtonsoft.Json;

namespace Kutt.NET.Domains
{
    /// <summary>
    ///     Json Properties for Domain
    /// </summary>
    public class Domain
    {
        /// <summary>
        ///     Domain's address
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; private set; }

        /// <summary>
        ///     Domain's status
        /// </summary>
        [JsonProperty("banned")]
        public bool IsBanned { get; private set; }

        /// <summary>
        ///     Domain's unique ID
        /// </summary>
        [JsonProperty("id")]
        public string Uuid { get; private set; }

        /// <summary>
        ///     Domain's creation date
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        ///     Domain's homepage
        /// </summary>
        [JsonProperty("homepage")]
        public string Homepage { get; private set; }

        /// <summary>
        ///     Domain's update date
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; private set; }
    }
}