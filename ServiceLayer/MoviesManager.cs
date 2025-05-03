using System.Collections.Generic;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    public static class MoviesManager
    {
        public static void Create(Movie item)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var moviesDBManager = new MoviesDBManager(dbContext);
            moviesDBManager.Create(item);
        }

        public static Movie Read(string key)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var moviesDBManager = new MoviesDBManager(dbContext);
            return moviesDBManager.Read(key);
        }

        public static IEnumerable<Movie> ReadAll()
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var moviesDBManager = new MoviesDBManager(dbContext);
            return moviesDBManager.ReadAll();
        }

        public static void Update(Movie movie)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var moviesDBManager = new MoviesDBManager(dbContext);
            moviesDBManager.Update(movie);
        }

        public static void Delete(string key)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var moviesDBManager = new MoviesDBManager(dbContext);
            moviesDBManager.Delete(key);
        }
    }
}
