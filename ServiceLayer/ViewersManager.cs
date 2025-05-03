using BusinessLayer;
using DataLayer;
using System.Collections.Generic;

namespace ServiceLayer
{
    public static class ViewersManager
    {
        public static void Create(Viewer item)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var viewersDBManager = new ViewersDBManager(dbContext);
            viewersDBManager.Create(item);
        }

        public static Viewer Read(int key)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var viewersDBManager = new ViewersDBManager(dbContext);
            return viewersDBManager.Read(key);
        }

        public static IEnumerable<Viewer> ReadAll()
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var viewersDBManager = new ViewersDBManager(dbContext);
            return viewersDBManager.ReadAll();
        }

        public static void Update(Viewer item)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var viewersDBManager = new ViewersDBManager(dbContext);
            viewersDBManager.Update(item);
        }

        public static void Delete(int key)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var viewersDBManager = new ViewersDBManager(dbContext);
            viewersDBManager.Delete(key);
        }
    }
}
