using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using VinylPi.DataAccess;
using VinylPi.Services;

namespace VinylPi.Controllers
{
    public class CollectionController : Controller
    {
        private readonly IApiService _apiService;
        private readonly IDbContextOptions _dbContextOptions;

        public CollectionController(IApiService apiService)
        {
            _apiService= apiService;
        }

        public IActionResult Index()
        {
            //var request = _apiService.GetApiDataFromDiscogs($"https://api.discogs.com/users/gratefulbed/collection/releases/0");

            //request with pagination parameters
            var request = _apiService.GetApiDataFromDiscogs($"https://api.discogs.com/users/gratefulbed/collection/releases/0?page=2&per_page=100");
            
            var data = request.Result;


            return View(data);
        }


        

    }

}