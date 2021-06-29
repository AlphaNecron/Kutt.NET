using System;
using System.Threading.Tasks;
using Kutt.NET.Domains;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using static Kutt.NET.Constants;

namespace Kutt.NET
{
    public partial class KuttApi
    {
        /// <summary>
        ///     Add a new domain to your account
        /// </summary>
        /// <param name="address">Domain address</param>
        /// <param name="homepage">Domain homepage</param>
        /// <returns>Created domain as <see cref="Domain" /></returns>
        public async Task<Domain> CreateDomainAsync(string address, string homepage = "")
        {
            var body = new
            {
                address = address ?? throw new ArgumentNullException(nameof(address)), homepage
            };
            var request = new RestRequest(DOMAINS_ENDPOINT, DataFormat.Json);
            request.AddJsonBody(body);
            var response = await _client.ExecutePostAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<Domain>(content);
        }

        /// <summary>
        ///     Remove a domain from your account
        /// </summary>
        /// <param name="uuid">Domain unique ID</param>
        public async Task DeleteDomainAsync(string uuid)
        {
            var request = new RestRequest(DOMAINS_ENDPOINT_WITH_ID, Method.DELETE, DataFormat.Json);
            request.AddUrlSegment("id", uuid ?? throw new ArgumentNullException(nameof(uuid)));
            var response = await _client.ExecuteAsync(request);
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(response.Content)["error"] ?? "").Value<string>()}");
        }
    }
}