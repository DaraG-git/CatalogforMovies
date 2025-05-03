using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
        public class RankingsDBManager : IDB<Ranking, int>
        {
            private readonly CatalogforMoviesDBContext _dbContext;

            public RankingsDBManager(CatalogforMoviesDBContext dbContext)
            {
                _dbContext = dbContext;
            }

            public void Create(Ranking item)
            {
                try
                {
                    _dbContext.Rankings.Add(item);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to create ranking.", ex);
                }
            }

            public Ranking Read(int key)
            {
                try
                {
                    return _dbContext.Rankings.Find(key); // Ако ключът е string (напр. Id)
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to read ranking.", ex);
                }
            }

            public IEnumerable<Ranking> ReadAll()
            {
                return _dbContext.Rankings.ToList();
            }

            public void Update(Ranking item)
            {
                try
                {
                    _dbContext.Rankings.Update(item);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to update ranking.", ex);
                }
            }

            public void Delete(int key)
            {
                try
                {
                    var ranking = _dbContext.Rankings.Find(key);
                    if (ranking != null)
                    {
                        _dbContext.Rankings.Remove(ranking);
                        _dbContext.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to delete ranking.", ex);
                }
            }
        }
}
