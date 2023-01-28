using Microsoft.AspNetCore.Mvc;
using VinylPi.Models.ApiResponses;

namespace VinylPi.Services
{
    public interface IApiService
    {
        Task<IActionResult> GetApiDataFromDiscogs(string url);
    }
}
