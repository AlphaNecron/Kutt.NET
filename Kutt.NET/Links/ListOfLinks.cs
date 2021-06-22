using Newtonsoft.Json;

namespace Kutt.NET.Links
{
    /// <summary>
    /// Json Propeties for ListOfLinks
    /// </summary>
    public class ListOfLinks
    {
        /// <summary>
        /// The limit
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; private set; }
        
        /// <summary>
        /// Skips
        /// </summary>
        [JsonProperty("skip")]
        public int Skip { get; private set; }
        
        /// <summary>
        /// Total Amount
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; private set; }
        
        /// <summary>
        /// Datas which content in Link.cs
        /// </summary>
        [JsonProperty("data")]
        public Link[] Links { get; private set; }
    }
}
