namespace VinylPi.DataAccess.Models.CollectionModels
{
    public class Release
    {
        public int? Id { get; set; }
        public int? Instance_id { get; set; }
        public DateTime? Date_added { get; set; }
        public int? Rating { get; set; }
        public BasicInformation? basic_information { get; set; }
    }
}
