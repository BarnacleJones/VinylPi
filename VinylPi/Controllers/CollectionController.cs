using Microsoft.AspNetCore.Mvc;
using VinylPi.Services;

namespace VinylPi.Controllers
{
    public class CollectionController : Controller
    {
        private readonly IApiService _apiService;

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

            //TODO figure out how to deal with pagination
            //collect all the data from all pages in a new (or same) service to seed a database with EF with data

            //https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver16

            //https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-7.0&tabs=visual-studio

            //make database maintenance page to update database with new response
            //use database to make collection page
            //click on each parent item to go to its relevant child pages, views for all

            return View(data);
        }


        

    }

}