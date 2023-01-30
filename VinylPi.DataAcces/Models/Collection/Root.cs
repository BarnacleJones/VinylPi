namespace VinylPi.DataAccess.Models.Collection
{
    public class Root
    {
        public int Id { get; set; }
        public Pagination? Pagination { get; set; }
        public List<Release>? Releases { get; set; }
    }
}
