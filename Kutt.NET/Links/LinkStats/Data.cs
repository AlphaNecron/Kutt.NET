using Newtonsoft.Json;

namespace Kutt.NET.Links.LinkStats
{
    public class Data
    {
        /// <summary>
        ///     Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        ///     Value
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; private set; }
    }
}