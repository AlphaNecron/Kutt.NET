using System;
using Newtonsoft.Json;

namespace Kutt.NET.Domains
{
    /// <summary>
    /// The Domain Json Properties for KuttAPI
    /// </summary>
    public class Domain
    {
        [JsonProperty("address")]
        public string Address { get; private set; }

        [JsonProperty("banned")]
        public bool IsBanned { get; private set; }

        [JsonProperty("id")]
        public string Uuid { get; private set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; private set; }

        [JsonProperty("homepage")]
        public string Homepage { get; private set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; private set; }
    }
}
