using System;
using RestSharp;
using static Kutt.NET.Constants;

namespace Kutt.NET
{
    public partial class KuttApi
    {
        private readonly RestClient Client;

        /// <summary>
        /// User's private API key
        /// </summary>
        public KuttApi(string apiKey)
        {
            ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            Client = new RestClient(API_URL);
            Client.AddDefaultHeader("X-API-KEY", ApiKey);
        }

        private string ApiKey { get; }
    }
}
