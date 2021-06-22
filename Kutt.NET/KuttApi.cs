using System;
using RestSharp;
using static Kutt.NET.Constants;

namespace Kutt.NET
{
    public partial class KuttApi
    {
        private readonly RestClient Client;

        public KuttApi(string apiKey)
        {
            ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            Client = new RestClient(API_URL);
            Client.AddDefaultHeader("X-API-KEY", ApiKey);
        }

        private string ApiKey { get; }
    }
}