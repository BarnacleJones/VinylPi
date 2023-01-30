using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using VinylPi.DataAccess;

namespace VinylPi.Services
{
    public class CollectionDtoToDbService : ICollectionDtoToDbService
    {

        private readonly IApiService _apiService;
        private readonly IDbContextFactory<VinylDbContext> _dbContextFactory;

        public CollectionDtoToDbService(IApiService apiservice, IDbContextFactory<VinylDbContext> dbContextFactory)
        {
            _apiService= apiservice;
            _dbContextFactory= dbContextFactory;
            
        }

        public void UpdateDbWithLatestCollectionResponse()
        {
            var collectionUrl = $"https://api.discogs.com/users/gratefulbed/collection/releases/0?page=2&per_page=100";
            var data = _apiService.GetApiDataFromDiscogs(collectionUrl);




        }


    }
}
