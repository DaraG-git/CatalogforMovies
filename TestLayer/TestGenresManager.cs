using NUnit.Framework;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace TestingLayer
{
    [TestFixture]
    public class TestGenresManager
    {
        private CatalogforMoviesDBContext _context;
        private GenresDBManager _manager;

       
        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<CatalogforMoviesDBContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new CatalogforMoviesDBContext(options);
            _manager = new GenresDBManager(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        [Test]
        public void Create_ShouldAddGenre()
        {
            var genre = new Genre("Action");
            _manager.Create(genre);

            var result = _manager.Read(genre.Id);
            Assert.IsNotNull(result);
            Assert.AreEqual("Action", result.Name);
        }

        [Test]
        public void ReadAll_ShouldReturnAllGenres()
        {
            var genre1 = new Genre("Drama");
            var genre2 = new Genre("Comedy");
            _manager.Create(genre1);
            _manager.Create(genre2);

            var genres = _manager.ReadAll().ToList();
            Assert.AreEqual(2, genres.Count);
        }

        [Test]
        public void Update_ShouldModifyGenre()
        {
            var genre = new Genre("SciFi");
            _manager.Create(genre);

            genre.Name = "Science Fiction";
            _manager.Update(genre);

            var updated = _manager.Read(genre.Id);
            Assert.AreEqual("Science Fiction", updated.Name);
        }

        [Test]
        public void Delete_ShouldRemoveGenre()
        {
            var genre = new Genre("Thriller");
            _manager.Create(genre);
            int id = genre.Id;

            _manager.Delete(id);
            var deleted = _manager.Read(id);
            Assert.IsNull(deleted);
        }
    }
}