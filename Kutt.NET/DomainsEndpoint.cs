using System;
using System.Threading.Tasks;
using Kutt.NET.Domains;
using Kutt.NET.Links;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using static Kutt.NET.Constants;

namespace Kutt.NET
{
    /// <summary>
    /// Domain EndPoints Class
    /// </summary>
    public partial class KuttApi
    {
        /// <summary>
        /// Create Domain
        /// </summary>
        /// <param name="address">address</param>
        /// <param name="homepage">homepage</param>
        public async Task<Domain> CreateDomainAsync(string address, string homepage = "")
        {
            var body = new
            {
                address = address ?? throw new ArgumentNullException(nameof(address)),
                homepage = homepage
            };
            var request = new RestRequest(DOMAINS_ENDPOINT, DataFormat.Json);
            request.AddJsonBody(body);
            var response = await Client.ExecutePostAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<Domain>(content);
        }

        /// <summary>
        /// Delete Domain
        /// </summary>
        /// <param name ="uuid">uuid</param>
        public async Task DeleteDomainAsync(string uuid)
        {
            var request = new RestRequest(DOMAINS_ENDPOINT_WITH_ID, Method.DELETE, DataFormat.Json);
            request.AddUrlSegment("id", uuid ?? throw new ArgumentNullException(nameof(uuid)));
            var response = await Client.ExecuteAsync(request);
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(response.Content)["error"] ?? "").Value<string>()}");
        }
    }
}