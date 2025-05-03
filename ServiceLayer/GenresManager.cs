using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    public static class GenresManager
    {
        public static void Create(Genre item)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var genresDBManager = new GenresDBManager(dbContext);
            genresDBManager.Create(item);
        }

        public static Genre Read(int key)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var genresDBManager = new GenresDBManager(dbContext);
            return genresDBManager.Read(key);
        }

        public static IEnumerable<Genre> ReadAll()
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var genresDBManager = new GenresDBManager(dbContext);
            return genresDBManager.ReadAll();
        }

        public static void Update(Genre genre)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var genresDBManager = new GenresDBManager(dbContext);
            genresDBManager.Update(genre);
        }

        public static void Delete(int key)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var genresDBManager = new GenresDBManager(dbContext);
            genresDBManager.Delete(key);
        }
    }
}
