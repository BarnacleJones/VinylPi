namespace VinylPi.Models.ApiResponses.CollectionModels
{
    public class ReleaseDto
    {
        public int? Id { get; set; }
        public int? Instance_id { get; set; }
        public DateTime? Date_added { get; set; }
        public int? Rating { get; set; }
        public BasicInformationDto? basic_information { get; set; }
    }
}
