namespace VinylPi.Models.ApiResponses.CollectionModels
{
    public class Root
    {
        public Pagination? Pagination { get; set; }
        public List<Release>? Releases { get; set; }
    }
}
