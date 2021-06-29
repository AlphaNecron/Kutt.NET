using System;
using RestSharp;
using static Kutt.NET.Constants;

namespace Kutt.NET
{
    public partial class KuttApi
    {
        private readonly RestClient _client;

        public KuttApi(string apiKey)
        {
            ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _client = new RestClient(API_URL);
            _client.AddDefaultHeader("X-API-KEY", ApiKey);
        }


        public KuttApi(string apiKey, string customServer)
        {
            ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _client = new RestClient(Uri.IsWellFormedUriString(customServer,
                UriKind.Absolute)
                ? customServer
                : throw new ArgumentException("Please provide a valid server."));
            _client.AddDefaultHeader("X-API-KEY", ApiKey);
        }

        private string ApiKey { get; }
    }
}