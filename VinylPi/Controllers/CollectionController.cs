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
        private readonly ILogger<HomeController> _logger;
        private readonly ICollectionItemsService _collectionItemService;

        public CollectionController(ILogger<HomeController> logger, ICollectionItemsService collectionItemsService)
        {
            _logger = logger;
            _collectionItemService = collectionItemsService;
        }

        public IActionResult Index()
        {
            var json = _collectionItemService.GetCollectionItemsByFolderAsync("GratefulBed", 1);

            var a = json.Result;
            //var collectionItems = JsonConvert.DeserializeObject<CollectionItemsByFolderReponseDto>(json.Result);

            return View(json.Result);
        }


        

    }

}