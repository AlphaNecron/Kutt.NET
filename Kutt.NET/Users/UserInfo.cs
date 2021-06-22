using Kutt.NET.Domains;
using Newtonsoft.Json;

namespace Kutt.NET.Users
{
    public class UserInfo
    {
        /// <summary>
        ///     User's API key
        /// </summary>
        [JsonProperty("apikey")]
        public string ApiKey { get; private set; }

        /// <summary>
        ///     User's email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; private set; }

        /// <summary>
        ///     List of domains
        /// </summary>
        [JsonProperty("domains")]
        public Domain[] Domains { get; private set; }
    }
}