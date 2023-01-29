
using VinylPi.Models.ApiResponses.CollectionDtoModels;

namespace VinylPi.Models.ApiResponses.CollectionModels
{
    public class BasicInformationDto
    {
        public int? Id { get; set; }
        public int? Master_id { get; set; }
        public string? Master_url { get; set; }
        public string? Resource_url { get; set; }
        public string? Thumb { get; set; }
        public string? Cover_image { get; set; }
        public string? Title { get; set; }
        public int? Year { get; set; }
        public List<FormatDto>? Formats { get; set; }
        public List<LabelDto>? Labels { get; set; }
        public List<ArtistDto>? Artists { get; set; }
        public List<string>? Genres { get; set; }
        public List<string>? Styles { get; set; }
    }
}
