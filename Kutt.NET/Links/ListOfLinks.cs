using Newtonsoft.Json;

namespace Kutt.NET.Links
{
    /// <summary>
    /// Json Propeties for ListOfLinks
    /// </summary>
    public class ListOfLinks
    {
        /// <summary>
        /// Query limit
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; private set; }
        
        /// <summary>
        /// Amount of queries to skip
        /// </summary>
        [JsonProperty("skip")]
        public int Skip { get; private set; }
        
        /// <summary>
        /// Total queries
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; private set; }
        
        /// <summary>
        /// Links
        /// </summary>
        [JsonProperty("data")]
        public Link[] Links { get; private set; }
    }
}
