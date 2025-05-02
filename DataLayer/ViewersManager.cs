using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
/*{
    public class ViewersManager : IDB<Viewer, int>
    {
        private readonly CatalogforMoviesDBContext _dbContext;

        public ViewersManager(CatalogforMoviesDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Viewer item)
        {
            try
            {
                _dbContext.Viewers.Add(item);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create viewer.", ex);
            }
        }

        public Movie Read(string key)
        {
            try
            {
                return _dbContext.Viewers.Find(key); 
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to read movie.", ex);
            }
        }

        public IEnumerable<Viewer> ReadAll()
        {
            return _dbContext.Viewers.ToList();
        }

        public void Update(Viewer item)
        {
            try
            {
                _dbContext.Viewers.Update(item);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update viewer.", ex);
            }
        }

        public void Delete(int key)
        {
            try
            {
                var viewer = _dbContext.Viewers.Find(key);
                if (viewer != null)
                {
                    _dbContext.Viewers.Remove(viewer);
                    _dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete viewer.", ex);
            }
        }
    }
}


