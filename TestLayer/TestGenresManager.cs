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
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) // Creates a new in-memory database for each test
                .Options;

            _context = new CatalogforMoviesDBContext(options);
            _manager = new GenresDBManager(_context);
        }

        [TearDown]
        public void TearDown()
        {
            // Optionally clean up the database to ensure isolation between tests
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [Test]
        public void Create_ShouldAddGenre()
        {
            var genre = new Genre("Action");

            // Act
            _manager.Create(genre);

            // Assert: After calling Create, ensure that the genre is correctly saved in the database
            var result = _manager.Read(genre.Id);
            Assert.IsNotNull(result); // The genre should exist now
            Assert.AreEqual("Action", result.Name); // The name should match the input
        }

        [Test]
        public void ReadAll_ShouldReturnAllGenres()
        {
            var genre1 = new Genre("Drama");
            var genre2 = new Genre("Comedy");
            _manager.Create(genre1);
            _manager.Create(genre2);

            // Act: Get all genres from the database
            var genres = _manager.ReadAll().ToList();

            // Assert: We should have 2 genres now
            Assert.AreEqual(2, genres.Count);
            Assert.Contains(genre1, genres);
            Assert.Contains(genre2, genres);
        }

        [Test]
        public void Update_ShouldModifyGenre()
        {
            var genre = new Genre("SciFi");
            _manager.Create(genre);

            // Act: Modify the genre name
            genre.Name = "Science Fiction";
            _manager.Update(genre);

            // Assert: Check if the updated genre is reflected
            var updated = _manager.Read(genre.Id);
            Assert.AreEqual("Science Fiction", updated.Name);
        }

        [Test]
        public void Delete_ShouldRemoveGenre()
        {
            var genre = new Genre("Thriller");
            _manager.Create(genre);
            int id = genre.Id;

            // Act: Delete the genre
            _manager.Delete(id);

            // Assert: Ensure that the genre was deleted
            var deleted = _manager.Read(id);
            Assert.IsNull(deleted); // The genre should no longer exist
        }
    }
}
