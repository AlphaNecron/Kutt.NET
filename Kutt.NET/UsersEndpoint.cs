using System.Threading.Tasks;
using Kutt.NET.Users;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using static Kutt.NET.Constants;

namespace Kutt.NET
{
    /// <summary>
    /// Users EndPoint Class
    /// </summary>
    public partial class KuttApi
    {
        /// <summary>
        /// Get User Info
        /// </summary>
        public async Task<UserInfo> GetUserInfoAsync()
        {
            var request = new RestRequest(USERS_ENDPOINT, DataFormat.Json);
            var response = await Client.ExecuteGetAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<UserInfo>(content);
        }
    }
}