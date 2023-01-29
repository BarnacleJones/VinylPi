namespace VinylPi.Models.ApiResponses.CollectionModels
{
    public class Root
    {
        public int Id { get; set; }
        public Pagination? Pagination { get; set; }
        public List<Release>? Releases { get; set; }
    }
}
