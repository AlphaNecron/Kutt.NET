using System;
using System.Threading.Tasks;
using Kutt.NET.Links;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using static Kutt.NET.Constants;

namespace Kutt.NET.Fluent
{
    public class LinkCreationRequest
    {
        public LinkCreationRequest(string apiKey, string target)
        {
            ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            Target = target ?? throw new ArgumentNullException(nameof(target));
        }

        internal string ApiKey { get; }
        public string Target { get; private set; }
        public string Domain { get; private set; }
        public string Expiration { get; private set; }
        public string Password { get; private set; }
        public bool Reuse { get; private set; }
        public string Slug { get; private set; }
        public string Description { get; private set; }

        public LinkCreationRequest WithPassword(string password)
        {
            Password = password;
            return this;
        }

        public LinkCreationRequest ToggleReuse()
        {
            Reuse = true;
            return this;
        }

        public LinkCreationRequest WithDescription(string description)
        {
            Description = description;
            return this;
        }

        public LinkCreationRequest WithCustomSlug(string slug)
        {
            Slug = slug;
            return this;
        }

        public LinkCreationRequest WithExpiration(string expiration)
        {
            Expiration = expiration;
            return this;
        }

        public LinkCreationRequest WithCustomDomain(string domain)
        {
            Domain = domain;
            return this;
        }

        public async Task<Link> SubmitAsync(string server = API_URL)
        {
            var body = new
            {
                target = Target ?? throw new ArgumentNullException(nameof(Target)),
                domain = Domain,
                customurl = Slug,
                description = Description,
                expire_in = Expiration,
                password = Password,
                reuse = Reuse
            };
            var client = new RestClient(server);
            var request = new RestRequest(LINKS_ENDPOINT, DataFormat.Json);
            request.AddHeader("X-API-KEY", ApiKey);
            request.AddJsonBody(body);
            var response = await client.ExecutePostAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<Link>(content);
        }
    }
}