namespace Kutt.NET
{
    /// <summary>
    /// Constants which will be used
    /// </summary>
    public static class Constants
    {
        internal const string API_URL = "https://kutt.it/api/v2";           // API URL
        internal const string DEFAULT_SERVER = "https://kutt.it";           // Main Server
        internal const string LINKS_ENDPOINT = "links";                     // Link EndPoints
        internal const string USERS_ENDPOINT = "users";                     // Users EndPoints
        internal const string LINKS_ENDPOINT_WITH_ID = "links/{id}";        // Link EndPoints With ID
        internal const string LINK_STATS_ENDPOINT = "links/{id}/stats";     // Link Stats EndPoint 
        internal const string DOMAINS_ENDPOINT = "domains";                 // Domain EndPoints
        internal const string DOMAINS_ENDPOINT_WITH_ID = "domains/{id}";    // Domain EndPoints With ID
    }
}