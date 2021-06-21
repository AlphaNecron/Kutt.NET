using Newtonsoft.Json;

namespace Kutt.NET.Links
{
    public class ListOfLinks
    {
        [JsonProperty("limit")]
        public int Limit { get; private set; }

        [JsonProperty("skip")]
        public int Skip { get; private set; }

        [JsonProperty("total")]
        public int Total { get; private set; }

        [JsonProperty("data")]
        public Link[] Links { get; private set; }
    }
}