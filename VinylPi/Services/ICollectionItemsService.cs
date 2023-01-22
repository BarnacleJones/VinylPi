using VinylPi.Models.ApiResponses;

namespace VinylPi.Services
{
    public interface ICollectionItemsService
    {        
        public Task<string> GetCollectionItemsByFolderAsync(string userName, int folderId);

    }
}
