namespace VinylPi.DataAccess.Models.CollectionModels
{
    public partial class CollectionResponse
    {
        public int Id { get; set; }
        public virtual Pagination? Pagination { get; set; }
        public virtual ICollection<Release>? Releases { get; set; }

    }
}
