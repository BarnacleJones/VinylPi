namespace VinylPi.Models.ApiResponses.CollectionModels
{
    public class RootDto
    {
        public PaginationDto? Pagination { get; set; }
        public List<ReleaseDto>? Releases { get; set; }
    }
}
