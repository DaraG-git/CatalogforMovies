using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class CatalogforMoviesDBContext : DbContext
    {
        public CatalogforMoviesDBContext() : base()
        {

        }
        public CatalogforMoviesDBContext(DbContextOptions<CatalogforMoviesDBContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=127.0.0.1;Database=CatalogforMoviesDb;Uid=root;Pwd=didy2707#@#;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Viewer> Viewers { get; set; }
        public DbSet<Ranking> Rankings { get; set; }

    }
}
