using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;
using VinylPi.Models.ApiResponses;
using static VinylPi.Models.ApiResponses.CollectionItemsByFolderReponseDto;

namespace VinylPi.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        private string _discogs_authorize_url;
        private string _discogs_consumer_key;
        private string _discogs_consumer_secret;
        private string _discogs_key;
        private string _discogs_request_token_url;
        private string _discogs_token_url;


        public ApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _discogs_key = Environment.GetEnvironmentVariable("DISCOGS_KEY");
            _discogs_consumer_key = Environment.GetEnvironmentVariable(variable: "DISCOGS_CONSUMER_KEY");
            _discogs_authorize_url = Environment.GetEnvironmentVariable(variable: "DISCOGS_AUTHORIZE_URL");
            _discogs_consumer_secret = Environment.GetEnvironmentVariable(variable: "DISCOGS_CONSUMER_SECRET");
            _discogs_request_token_url = Environment.GetEnvironmentVariable(variable: "DISCOGS_REQUEST_TOKEN_URL");
            _discogs_token_url = Environment.GetEnvironmentVariable(variable: "DISCOGS_TOKEN_URL");
        }

        public async Task<string> GetApiDataFromDiscogs(string url)
        {
            //_httpClient.DefaultRequestHeaders.Add("Authorization", $"Discogs key={_discogs_key}, secret={_discogs_consumer_secret}");            
            //_httpClient.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded");
            //_httpClient.DefaultRequestHeaders.Add("User-Agent", "some_user_agent");
            //_httpClient.DefaultRequestHeaders.Add("Authorization",
            //    $"OAuth oauth_consumer_key={_discogs_consumer_key}, oauth_nonce={Guid.NewGuid().ToString()}, oauth_signature={_discogs_consumer_secret}&, oauth_signature_method=PLAINTEXT, oauth_timestamp={((int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds)}, oauth_callback={"none"}");
            //url += $"/releases&key={_discogs_consumer_key}&secret={_discogs_consumer_secret}";

            url += $"&token={_discogs_key}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
