using Newtonsoft.Json;

namespace Kutt.NET.Links
{
    /// <summary>
    ///     Json Propeties for ListOfLinks
    /// </summary>
    public class ListOfLinks
    {
        /// <summary>
        ///     Query limit
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; private set; }

        /// <summary>
        ///     Amount of links to skip
        /// </summary>
        [JsonProperty("skip")]
        public int Skip { get; private set; }

        /// <summary>
        ///     Total link count
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; private set; }

        /// <summary>
        ///     List of links
        /// </summary>
        [JsonProperty("data")]
        public Link[] Links { get; private set; }
    }
}