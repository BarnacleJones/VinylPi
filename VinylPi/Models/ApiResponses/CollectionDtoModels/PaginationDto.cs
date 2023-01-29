
namespace VinylPi.Models.ApiResponses.CollectionModels
{
    public class PaginationDto
    {
        public int? Page { get; set; }
        public int? Pages { get; set; }
        public int? Per_page { get; set; }
        public int? Items { get; set; }
        public UrlsDto? Urls { get; set; }
    }
}
