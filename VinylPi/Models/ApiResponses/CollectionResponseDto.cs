using VinylPi.Models.ApiResponses.CollectionModels;

namespace VinylPi.Models.ApiResponses
{
    public partial class CollectionResponseDto
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        //https://json2csharp.com/ - put in the json response, generates lots of classes, split them up
        //https://stackoverflow.com/questions/27675413/store-json-data-object-to-database-in-asp-net-mvc-entity-framework

        //public virtual ICollection<Artist>? Artists { get; set; }
        //public virtual ICollection<BasicInformation>? BasicInformation { get; set; }
        //public virtual ICollection<Format>? Format { get; set; }
        //public virtual ICollection<Label>? Label { get; set; }
        public virtual Pagination Pagination { get; set; }
        public virtual ICollection<Release>? Releases { get; set; }

        //public virtual ICollection<Root>? Root { get; set; }
        //public virtual ICollection<Urls>? Urls { get; set; }

    }
}
