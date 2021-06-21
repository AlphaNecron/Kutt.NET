using System;
using System.Threading.Tasks;
using Kutt.NET.Links;
using Kutt.NET.Links.LinkStats;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using static Kutt.NET.Constants;

namespace Kutt.NET
{
    public partial class KuttApi
    {
        public async Task<ListOfLinks> GetListOfLinksAsync(
            int limit = 10,
            int skip = 0,
            bool all = false)
        {
            var request = new RestRequest(LINKS_ENDPOINT, DataFormat.Json);
            request.AddQueryParameter("limit", limit.ToString());
            request.AddQueryParameter("skip", skip.ToString());
            request.AddQueryParameter("all", all.ToString().ToLower());
            var response = await Client.ExecuteGetAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<ListOfLinks>(content);
        }

        public async Task DeleteLinkAsync(string uuid)
        {
            var request = new RestRequest(LINKS_ENDPOINT_WITH_ID, Method.DELETE, DataFormat.Json);
            request.AddUrlSegment("id", uuid ?? throw new ArgumentNullException(nameof(uuid)));
            var response = await Client.ExecuteAsync(request);
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(response.Content)["error"] ?? "").Value<string>()}");
        }

        public async Task<Link> UpdateLinkAsync(
            string uuid,
            string target,
            string slug,
            string description = ""
        )
        {
            var body = new
            {
                target = target ?? throw new ArgumentNullException(nameof(target)),
                address = slug ?? throw new ArgumentNullException(nameof(slug)),
                description
            };
            var request = new RestRequest(LINKS_ENDPOINT_WITH_ID, Method.PATCH, DataFormat.Json);
            request.AddUrlSegment("id", uuid ?? throw new ArgumentNullException(nameof(uuid)));
            request.AddJsonBody(body);
            var response = await Client.ExecuteAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<Link>(content);
        }

        public async Task<LinkStats> GetLinkStatsAsync(string uuid)
        {
            var request = new RestRequest(LINK_STATS_ENDPOINT, Method.PATCH, DataFormat.Json);
            request.AddUrlSegment("id", uuid ?? throw new ArgumentNullException(nameof(uuid)));
            var response = await Client.ExecuteAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<LinkStats>(content);
        }

        public async Task<Link> CreateLinkAsync(
            string longUrl,
            string domain = "",
            string description = "",
            string slug = "",
            bool reuse = false,
            string password = "")
        {
            var body = new
            {
                target = longUrl ?? throw new ArgumentNullException(nameof(longUrl)),
                domain,
                customurl = slug,
                description,
                password,
                reuse
            };
            var request = new RestRequest(LINKS_ENDPOINT, DataFormat.Json);
            request.AddJsonBody(body);
            var response = await Client.ExecutePostAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<Link>(content);
        }
    }
}