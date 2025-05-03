using BusinessLayer;
using DataLayer;
using System.Collections.Generic;

namespace ServiceLayer
{
    public static class RankingsManager
    {
        public static void Create(Ranking item)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var rankingsDBManager = new RankingsDBManager(dbContext);
            rankingsDBManager.Create(item);
        }

        public static Ranking Read(int key)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var rankingsDBManager = new RankingsDBManager(dbContext);
            return rankingsDBManager.Read(key);
        }

        public static IEnumerable<Ranking> ReadAll()
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var rankingsDBManager = new RankingsDBManager(dbContext);
            return rankingsDBManager.ReadAll();
        }

        public static void Update(Ranking item)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var rankingsDBManager = new RankingsDBManager(dbContext);
            rankingsDBManager.Update(item);
        }

        public static void Delete(int key)
        {
            using var dbContext = new CatalogforMoviesDBContext();
            var rankingsDBManager = new RankingsDBManager(dbContext);
            rankingsDBManager.Delete(key);
        }
    }
}
