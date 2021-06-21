using Newtonsoft.Json;

namespace Kutt.NET.Links.LinkStats
{
    public class Data
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("value")]
        public int Value { get; private set; }
    }
}