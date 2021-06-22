using Newtonsoft.Json;

namespace Kutt.NET.Links.LinkStats
{
    /// <summary>
    /// Json Properties for Domain Stats
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// Browser
        /// </summary>
        [JsonProperty("browser")]
        public Data[] BrowserStats { get; private set; }
        
        /// <summary>
        /// Operating System
        /// </summary>
        [JsonProperty("os")]
        public Data[] OsStats { get; private set; }
        
        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty("country")]
        public Data[] CountryStats { get; private set; }
        
        /// <summary>
        /// Referrer Stats
        /// </summary>
        [JsonProperty("referrer")]
        public Data[] ReferrerStats { get; private set; }
    }
}
