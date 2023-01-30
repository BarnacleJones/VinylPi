namespace VinylPi.DataAccess.Models.Collection
{
    public class Pagination
    {
        public int? Id { get; set; }
        public int? Pages { get; set; }
        public int? Per_page { get; set; }
        public int? Items { get; set; }
        public Urls? Urls { get; set; }
    }
}
