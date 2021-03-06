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
    /// <summary>
    ///     Link Endpoint Class
    /// </summary>
    public partial class KuttApi
    {
        /// <summary>
        ///     Get list of Link
        /// </summary>
        /// <param name="limit">Query limit</param>
        /// <param name="skip">Amount of links to skip</param>
        /// <param name="all">Get all links</param>
        /// <returns>
        ///     <see cref="ListOfLinks" />
        /// </returns>
        public async Task<ListOfLinks> GetListOfLinksAsync(
            int limit = 10,
            int skip = 0,
            bool all = false)
        {
            var request = new RestRequest(LINKS_ENDPOINT, DataFormat.Json);
            request.AddQueryParameter("limit", limit.ToString());
            request.AddQueryParameter("skip", skip.ToString());
            request.AddQueryParameter("all", all.ToString().ToLower());
            var response = await _client.ExecuteGetAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<ListOfLinks>(content);
        }

        /// <summary>
        ///     Delete a link
        /// </summary>
        /// <param name="uuid">UUID</param>
        public async Task DeleteLinkAsync(string uuid)
        {
            var request = new RestRequest(LINKS_ENDPOINT_WITH_ID, Method.DELETE, DataFormat.Json);
            request.AddUrlSegment("id", uuid ?? throw new ArgumentNullException(nameof(uuid)));
            var response = await _client.ExecuteAsync(request);
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(response.Content)["error"] ?? "").Value<string>()}");
        }

        /// <summary>
        ///     Update a link
        /// </summary>
        /// <param name="uuid">UUID</param>
        /// <param name="target">Target</param>
        /// <param name="slug">Slug</param>
        /// <param name="expireIn">2 minutes/hours/days</param>
        /// <param name="description">The Description</param>
        /// <returns>Updated link as <see cref="Link" /></returns>
        public async Task<Link> UpdateLinkAsync(string uuid,
            string target,
            string slug,
            string expireIn = "",
            string description = "")
        {
            var body = new
            {
                target = target ?? throw new ArgumentNullException(nameof(target)),
                address = slug ?? throw new ArgumentNullException(nameof(slug)),
                expire_in = expireIn,
                description
            };
            var request = new RestRequest(LINKS_ENDPOINT_WITH_ID, Method.PATCH, DataFormat.Json);
            request.AddUrlSegment("id", uuid ?? throw new ArgumentNullException(nameof(uuid)));
            request.AddJsonBody(body);
            var response = await _client.ExecuteAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<Link>(content);
        }

        /// <summary>
        ///     Get link stats
        /// </summary>
        /// <param name="uuid">Link unique ID</param>
        /// <returns>
        ///     <see cref="LinkStats" />
        /// </returns>
        public async Task<LinkStats> GetLinkStatsAsync(string uuid)
        {
            var request = new RestRequest(LINK_STATS_ENDPOINT, Method.PATCH, DataFormat.Json);
            request.AddUrlSegment("id", uuid ?? throw new ArgumentNullException(nameof(uuid)));
            var response = await _client.ExecuteAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<LinkStats>(content);
        }

        /// <summary>
        ///     Create Link
        /// </summary>
        /// <param name="longUrl">Long URL</param>
        /// <param name="domain">Domain</param>
        /// <param name="description">Description</param>
        /// <param name="slug">Slug</param>
        /// <param name="reuse">Reuse</param>
        /// <param name="password">Password</param>
        /// <param name="expireIn">2 minutes/hours/days</param>
        /// <returns>Shortened link as <see cref="Link" /></returns>
        public async Task<Link> CreateLinkAsync(
            string longUrl,
            string domain = "",
            string description = "",
            string expireIn = "",
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
                expire_in = expireIn,
                password,
                reuse
            };
            var request = new RestRequest(LINKS_ENDPOINT, DataFormat.Json);
            request.AddJsonBody(body);
            var response = await _client.ExecutePostAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<Link>(content);
        }
    }
}