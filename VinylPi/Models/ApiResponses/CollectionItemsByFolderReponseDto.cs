namespace VinylPi.Models.ApiResponses
{
    public class CollectionItemsByFolderReponseDto
    {
        //response from GET /users/{username}/collection/folders/{folder_id}/releases
        public class CollectionDTO
        {
            public PaginationDTO? Pagination { get; set; }
            public List<ReleaseDTO>? Releases { get; set; }
        }

        public class ReleaseDTO
        {
            public int Id { get; set; }
            public int InstanceId { get; set; }
            public int FolderId { get; set; }
            public int Rating { get; set; }
            public BasicInformationDTO BasicInformation { get; set; }
            public List<NoteDTO> Notes { get; set; }
        }

        public class NoteDTO
        {
            public int FieldId { get; set; }
            public string Value { get; set; }
        }

        public class BasicInformationDTO
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int Year { get; set; }
            public string ResourceUrl { get; set; }
            public string Thumb { get; set; }
            public string CoverImage { get; set; }
            public List<FormatDTO> Formats { get; set; }
            public List<LabelDTO> Labels { get; set; }
            public List<ArtistDTO> Artists { get; set; }
            public List<string> Genres { get; set; }
            public List<string> Styles { get; set; }
        }

        public class FormatDTO
        {
            public string Qty { get; set; }
            public List<string> Descriptions { get; set; }
            public string Name { get; set; }
        }

        public class ArtistDTO
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Join { get; set; }
            public string ResourceUrl { get; set; }
            public string Anv { get; set; }
            public string Tracks { get; set; }
            public string Role { get; set; }
        }

        public class LabelDTO
        {
            public string ResourceUrl { get; set; }
            public string EntityType { get; set; }
            public string Catno { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class PaginationDTO
        {
            public int PerPage { get; set; }
            public int Pages { get; set; }
            public int Page { get; set; }
            public int Items { get; set; }
            public UrlsDTO Urls { get; set; }
        }

        public class UrlsDTO
        {
            public string Next { get; set; }
            public string Last { get; set; }
        }

    }
}
