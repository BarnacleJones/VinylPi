namespace VinylPi.DataAccess.Models.Collection
{
    public class BasicInformation
    {
        public int? Id { get; set; }
        public int? Master_id { get; set; }
        public string? Master_url { get; set; }
        public string? Resource_url { get; set; }
        public string? Thumb { get; set; }
        public string? Cover_image { get; set; }
        public string? Title { get; set; }
        public int? Year { get; set; }
        public List<Format>? Formats { get; set; }
        public List<Label>? Labels { get; set; }
        public List<Artist>? Artists { get; set; }
        public List<Genres>? Genres { get; set; }
        public List<Styles>? Styles { get; set; }
    }
}
