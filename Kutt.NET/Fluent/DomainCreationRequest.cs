using System;
using System.Threading.Tasks;
using Kutt.NET.Domains;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using static Kutt.NET.Constants;

namespace Kutt.NET.Fluent
{
    public class DomainCreationRequest
    {
        public DomainCreationRequest(string apiKey, string domain)
        {
            ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            Domain = domain ?? throw new ArgumentNullException(nameof(domain));
        }

        internal string ApiKey { get; }

        public string Domain { get; private set; }

        public string Homepage { get; private set; }

        public DomainCreationRequest WithCustomHomepage(string homepage)
        {
            Homepage = homepage;
            return this;
        }

        public async Task<Domain> SubmitAsync(string server = API_URL)
        {
            var body = new
            {
                address = Domain ?? throw new ArgumentNullException(nameof(Domain)),
                homepage = Homepage
            };
            var client = new RestClient(server);
            var request = new RestRequest(DOMAINS_ENDPOINT, DataFormat.Json);
            request.AddHeader("X-API-KEY", ApiKey);
            request.AddJsonBody(body);
            var response = await client.ExecutePostAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new KuttException
                    ($"{(int) response.StatusCode}: {(JObject.Parse(content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<Domain>(content);
        }
    }
}