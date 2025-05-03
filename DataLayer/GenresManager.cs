using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class GenresManager : IDB<Genre, int>
    {
        private readonly CatalogforMoviesDBContext _dbContext;

        public GenresManager(CatalogforMoviesDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Genre item)
        {
            try
            {
                _dbContext.Genres.Add(item);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create genre.", ex);
            }
        }

        public Genre Read(int key)
        {
            try
            {
                return _dbContext.Genres.Find(key); // Ако ключът е string (напр. Id)
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to read genre.", ex);
            }
        }

        public IEnumerable<Genre> ReadAll()
        {
            return _dbContext.Genres.ToList();
        }

        public void Update(Genre item)
        {
            try
            {
                _dbContext.Genres.Update(item);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update Genre.", ex);
            }
        }

        public void Delete(int key)
        {
            try
            {
                var genre = _dbContext.Genres.Find(key);
                if (genre != null)
                {
                    _dbContext.Genres.Remove(genre);
                    _dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete genre.", ex);
            }
        }
    }
}


