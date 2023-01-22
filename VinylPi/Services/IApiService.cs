using VinylPi.Models.ApiResponses;

namespace VinylPi.Services
{
    public interface IApiService
    {
        Task<string> GetApiDataFromDiscogs(string url);
    }
}
