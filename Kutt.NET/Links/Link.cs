using System;
using Newtonsoft.Json;

namespace Kutt.NET.Links
{
    public class Link
    {
        [JsonProperty("address")]
        public string Address { get; private set; }

        [JsonProperty("banned")]
        public bool IsBanned { get; private set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; private set; }

        [JsonProperty("id")]
        public string Uuid { get; private set; }

        [JsonProperty("link")]
        public string ShortUrl { get; private set; }

        [JsonProperty("target")]
        public string LongUrl { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; private set; }

        [JsonProperty("visit_count")]
        public int Clicks { get; private set; }
    }
}