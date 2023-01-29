using Newtonsoft.Json;

namespace VinylPi.Models.ApiResponses
{
    public class CollectionItemsByFolderReponseDto
    {
        //another test format from https://json2csharp.com/
        //response from GET /users/{username}/collection/folders/{folder_id}/releases

        public class Artist
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("anv")]
            public string Anv { get; set; }

            [JsonProperty("join")]
            public string Join { get; set; }

            [JsonProperty("role")]
            public string Role { get; set; }

            [JsonProperty("tracks")]
            public string Tracks { get; set; }

            [JsonProperty("id")]
            public int? Id { get; set; }

            [JsonProperty("resource_url")]
            public string ResourceUrl { get; set; }
        }

        public class BasicInformation
        {
            [JsonProperty("id")]
            public int? Id { get; set; }

            [JsonProperty("master_id")]
            public int? MasterId { get; set; }

            [JsonProperty("master_url")]
            public string MasterUrl { get; set; }

            [JsonProperty("resource_url")]
            public string ResourceUrl { get; set; }

            [JsonProperty("thumb")]
            public string Thumb { get; set; }

            [JsonProperty("cover_image")]
            public string CoverImage { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("year")]
            public int? Year { get; set; }

            [JsonProperty("formats")]
            public List<Format> Formats { get; } = new List<Format>();

            [JsonProperty("labels")]
            public List<Label> Labels { get; } = new List<Label>();

            [JsonProperty("artists")]
            public List<Artist> Artists { get; } = new List<Artist>();

            [JsonProperty("genres")]
            public List<string> Genres { get; } = new List<string>();

            [JsonProperty("styles")]
            public List<string> Styles { get; } = new List<string>();
        }

        public class Format
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("qty")]
            public string Qty { get; set; }

            [JsonProperty("descriptions")]
            public List<string> Descriptions { get; } = new List<string>();

            [JsonProperty("text")]
            public string Text { get; set; }
        }

        public class Label
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("catno")]
            public string Catno { get; set; }

            [JsonProperty("entity_type")]
            public string EntityType { get; set; }

            [JsonProperty("entity_type_name")]
            public string EntityTypeName { get; set; }

            [JsonProperty("id")]
            public int? Id { get; set; }

            [JsonProperty("resource_url")]
            public string ResourceUrl { get; set; }
        }

        public class Pagination
        {
            [JsonProperty("page")]
            public int? Page { get; set; }

            [JsonProperty("pages")]
            public int? Pages { get; set; }

            [JsonProperty("per_page")]
            public int? PerPage { get; set; }

            [JsonProperty("items")]
            public int? Items { get; set; }

            [JsonProperty("urls")]
            public Urls Urls { get; set; }
        }

        public class Release
        {
            [JsonProperty("id")]
            public int? Id { get; set; }

            [JsonProperty("instance_id")]
            public int? InstanceId { get; set; }

            [JsonProperty("date_added")]
            public DateTime? DateAdded { get; set; }

            [JsonProperty("rating")]
            public int? Rating { get; set; }

            [JsonProperty("basic_information")]
            public BasicInformation BasicInformation { get; set; }
        }

        public class Root
        {
            [JsonProperty("pagination")]
            public Pagination Pagination { get; set; }

            [JsonProperty("releases")]
            public List<Release> Releases { get; } = new List<Release>();
        }

        public class Urls
        {
            [JsonProperty("last")]
            public string Last { get; set; }

            [JsonProperty("next")]
            public string Next { get; set; }
        }




    }
}
