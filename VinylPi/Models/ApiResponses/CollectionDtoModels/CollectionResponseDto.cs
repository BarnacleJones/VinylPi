using VinylPi.Models.ApiResponses.CollectionModels;

namespace VinylPi.Models.ApiResponses
{
    public partial class CollectionResponseDto
    {
        //https://json2csharp.com/ - put in the json response, generates lots of classes, split them up
        //https://stackoverflow.com/questions/27675413/store-json-data-object-to-database-in-asp-net-mvc-entity-framework

        public virtual PaginationDto? Pagination { get; set; }
        public virtual ICollection<ReleaseDto>? Releases { get; set; }
    }
}
