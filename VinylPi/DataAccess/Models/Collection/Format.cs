namespace VinylPi.DataAccess.Models.CollectionModels
{
    public class Format
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Qty { get; set; }
        public List<Descriptions>? Descriptions { get; set; }
        public string? Text { get; set; }
    }
}
