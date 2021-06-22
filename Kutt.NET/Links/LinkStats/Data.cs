using Newtonsoft.Json;

namespace Kutt.NET.Links.LinkStats
{
    /// <summary>
    /// Json Properties for Data.cs
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
        
        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; private set; }
    }
}
