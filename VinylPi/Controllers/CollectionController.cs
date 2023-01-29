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
            //make database maintenance page to update database with new response
            //use database to make collection page
            //click on each parent item to go to its relevant child pages, views for all

            return View(data);
        }


        

    }

}