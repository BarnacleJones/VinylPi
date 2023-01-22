using AutoMapper;
using Newtonsoft.Json;
using VinylPi.Models.ApiResponses;
using static VinylPi.Models.ApiResponses.CollectionItemsByFolderReponseDto;

namespace VinylPi.Services
{
    public class CollectionItemsService : ICollectionItemsService
    {

        //private readonly Mapper _mapper;
        private readonly IApiService _apiService;

        public CollectionItemsService(IApiService apiService)
        {
            //_mapper = mapper;
            _apiService = apiService;
        }
    


        public async Task<string> GetCollectionItemsByFolderAsync(string userName, int folderId)
        {
            //var json = await _apiService.GetApiDataFromDiscogs($"https://api.discogs.com/users/{userName}/collection/folders/{folderId}/releases");

            var json = await _apiService.GetApiDataFromDiscogs($"https://api.discogs.com/database/search?king?gizzard");

            //var collection = _mapper.Map<CollectionDTO>(json);
            return json;
        }
    }
}
