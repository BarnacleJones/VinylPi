using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using VinylPi.Models;
using VinylPi.Models.ApiResponses;
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
            var request = _apiService.GetApiDataFromDiscogs($"https://api.discogs.com/users/gratefulbed/collection/releases/0");
            var data = request.Result;

            return View(data);
        }


        

    }

}