using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VinylPi.Models;

namespace VinylPi.Services
{
    public class ApiService : Controller, IApiService
    {
        private readonly HttpClient _httpClient;

        //private string _discogs_consumer_key;


        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            //dont know if these ever worked but leaving as reference
            //_discogs_consumer_key = Environment.GetEnvironmentVariable(variable: "DISCOGS_CONSUMER_KEY");
        }

        public async Task<IActionResult> GetApiDataFromDiscogs(string url)
        {
            // Send the GET request with header for Discogs
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "VinylPi");
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            
            if (response.IsSuccessStatusCode)
            {
                // Get the JSON data and deserialize
                var json = await response.Content.ReadAsStringAsync();
                //var data = JsonConvert.DeserializeObject<CollectionItemsByFolderReponseDto>(json);
                var data = JsonConvert.DeserializeObject<CollectionResponseDto>(json);
                

                return Ok(data);
            }
            else
            {
                return StatusCode(500, "Failed to get data from API: " + response.ReasonPhrase);
            }

        }
    }
}
