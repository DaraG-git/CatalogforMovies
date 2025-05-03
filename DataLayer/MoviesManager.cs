using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class MoviesManager : IDB<Movie, string>
    {
        private readonly CatalogforMoviesDBContext _dbContext;

        public MoviesManager(CatalogforMoviesDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Movie item)
        {
            try
            {
                _dbContext.Movies.Add(item);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create movie.", ex);
            }
        }

        public Movie Read(string key)
        {
            try
            {
                return _dbContext.Movies.Find(key); // Ако ключът е string (напр. Id)
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to read movie.", ex);
            }
        }

        public IEnumerable<Movie> ReadAll()
        {
            return _dbContext.Movies.ToList();
        }

        public void Update(Movie item)
        {
            try
            {
                _dbContext.Movies.Update(item);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update movie.", ex);
            }
        }

        public void Delete(string key)
        {
            try
            {
                var movie = _dbContext.Movies.Find(key);
                if (movie != null)
                {
                    _dbContext.Movies.Remove(movie);
                    _dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete movie.", ex);
            }
        }
    }
}


