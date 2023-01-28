using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using VinylPi.Models.ApiResponses;
using static VinylPi.Models.ApiResponses.CollectionItemsByFolderReponseDto;

namespace VinylPi.Services
{
    public class ApiService : Controller, IApiService
    {
        private readonly HttpClient _httpClient;
        private string _discogs_authorize_url;
        private string _discogs_consumer_key;
        private string _discogs_consumer_secret;
        private string _discogs_key;
        private string _discogs_request_token_url;
        private string _discogs_token_url;


        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _discogs_key = Environment.GetEnvironmentVariable("DISCOGS_KEY");
            _discogs_consumer_key = Environment.GetEnvironmentVariable(variable: "DISCOGS_CONSUMER_KEY");
            _discogs_authorize_url = Environment.GetEnvironmentVariable(variable: "DISCOGS_AUTHORIZE_URL");
            _discogs_consumer_secret = Environment.GetEnvironmentVariable(variable: "DISCOGS_CONSUMER_SECRET");
            _discogs_request_token_url = Environment.GetEnvironmentVariable(variable: "DISCOGS_REQUEST_TOKEN_URL");
            _discogs_token_url = Environment.GetEnvironmentVariable(variable: "DISCOGS_TOKEN_URL");
        }

        public async Task<IActionResult> GetApiDataFromDiscogs(string url)
        {
            // Send the GET request
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "VinylPi");
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            
            // Check if the response was successful
            if (response.IsSuccessStatusCode)
            {
                // Get the JSON data
                var json = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON data
                var data = JsonConvert.DeserializeObject(json);

                // Return the data
                return Ok(data);
            }
            else
            {
                // Throw an exception if the response was not successful
                return StatusCode(500, "Failed to get data from API: " + response.ReasonPhrase);
            }

        }
    }
}
