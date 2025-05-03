using NUnit.Framework;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingLayer
{
    [TestFixture]
    public class TestRankingsManager
    {
        private RankingsDBManager _manager;
        private CatalogforMoviesDBContext _context;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<CatalogforMoviesDBContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new CatalogforMoviesDBContext(options);
            _manager = new RankingsDBManager(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        [Test]
        public void Create_ShouldAddRanking()
        {
            var viewer = new Viewer { Name = "John Doe", Email = "john@example.com" };
            var ranking = new Ranking(viewer, DateTime.Now);
            _manager.Create(ranking);

            var result = _manager.Read(ranking.ID);
            Assert.IsNotNull(result);
            Assert.AreEqual("John Doe", result.Viewers.Name);
        }

        [Test]
        public void ReadAll_ShouldReturnAllRankings()
        {
            var viewer1 = new Viewer { Name = "Alice", Email = "alice@example.com" };
            var viewer2 = new Viewer { Name = "Bob", Email = "bob@example.com" };

            _manager.Create(new Ranking(viewer1, DateTime.Now));
            _manager.Create(new Ranking(viewer2, DateTime.Now));

            var rankings = _manager.ReadAll().ToList();
            Assert.AreEqual(2, rankings.Count);
        }

        [Test]
        public void Update_ShouldModifyRanking()
        {
            var viewer = new Viewer { Name = "Jane", Email = "jane@example.com" };
            var ranking = new Ranking(viewer, DateTime.Now);
            _manager.Create(ranking);

            ranking.CreationDate = ranking.CreationDate.AddDays(1);
            _manager.Update(ranking);

            var updated = _manager.Read(ranking.ID);
            Assert.AreEqual(ranking.CreationDate, updated.CreationDate);
        }

        [Test]
        public void Delete_ShouldRemoveRanking()
        {
            var viewer = new Viewer { Name = "Mike", Email = "mike@example.com" };
            var ranking = new Ranking(viewer, DateTime.Now);
            _manager.Create(ranking);

            _manager.Delete(ranking.ID);

            var deleted = _manager.Read(ranking.ID);
            Assert.IsNull(deleted);
        }
    }
}
