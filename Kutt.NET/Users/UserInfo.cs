using Kutt.NET.Domains;
using Newtonsoft.Json;

namespace Kutt.NET.Users
{
    public class UserInfo
    {
        [JsonProperty("apikey")]
        public string ApiKey { get; private set; }

        [JsonProperty("email")]
        public string Email { get; private set; }

        [JsonProperty("domains")]
        public Domain[] Domains { get; private set; }
    }
}