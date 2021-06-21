using Newtonsoft.Json;

namespace Kutt.NET.Links.LinkStats
{
    public class Stats
    {
        [JsonProperty("browser")]
        public Data[] BrowserStats { get; private set; }

        [JsonProperty("os")]
        public Data[] OsStats { get; private set; }

        [JsonProperty("country")]
        public Data[] CountryStats { get; private set; }

        [JsonProperty("referrer")]
        public Data[] ReferrerStats { get; private set; }
    }
}