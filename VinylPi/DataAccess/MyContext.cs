using Microsoft.EntityFrameworkCore;
using VinylPi.Models.ApiResponses.CollectionModels;

namespace VinylPi.DataAccess
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists{ get; set; }
        public DbSet<BasicInformation> BasicInformation { get; set; }

        public DbSet<Format> Formats{ get; set; }
        public DbSet<Label> Labels{ get; set; }
        public DbSet<Pagination> Pagination { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Root> Root { get; set; }
        public DbSet<Urls> Urls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().ToTable("Artists");
            modelBuilder.Entity<BasicInformation>().ToTable("BasicInformation");
            modelBuilder.Entity<Format>().ToTable("Formats");

            modelBuilder.Entity<Label>().ToTable("Labels");
            modelBuilder.Entity<Pagination>().ToTable("Pagination");
            modelBuilder.Entity<Release>().ToTable("Releases");

            modelBuilder.Entity<Artist>().ToTable("Artist");
            modelBuilder.Entity<Root>().ToTable("Root");
            modelBuilder.Entity<Urls>().ToTable("Urls");
        }
    }
}
