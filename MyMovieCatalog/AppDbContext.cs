using Microsoft.EntityFrameworkCore;
using MyMovieCatalog.Entities;

namespace MyMovieCatalog
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasData(
                new Movie() { Id = 1, Title = "Star Wars: A New Hope", Rating = "PG", ReleaseYear = 1977 },
                new Movie() { Id = 2, Title = "The Empire Strikes Back", Rating = "PG", ReleaseYear = 1980 },
                new Movie() { Id = 3, Title = "Return of the Jedi", Rating = "PG", ReleaseYear = 1983 }
            );
        }

        public DbSet<Movie> Movies => Set<Movie>();
    }
}
