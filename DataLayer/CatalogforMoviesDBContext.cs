using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class CatalogforMoviesDBContext : DbContext
    {
        public CatalogforMoviesDBContext(DbContextOptions<CatalogforMoviesDBContext> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Viewer> Viewers { get; set; }
        public DbSet<Ranking> Rankings { get; set; }

    }
}
