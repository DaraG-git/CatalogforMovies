using NUnit.Framework;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TestingLayer
{
    [TestFixture]
    public class TestMoviesManager
    {
        private MoviesDBManager _manager;
        private CatalogforMoviesDBContext _context;
        private Genre _testGenre;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<CatalogforMoviesDBContext>()
                .UseInMemoryDatabase(databaseName: "MoviesTestDb")
                .Options;

            _context = new CatalogforMoviesDBContext(options);
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            // Add a test genre because Movie requires one
            _testGenre = new Genre { Id = 1, Name = "Sci-Fi" };
            _context.Genres.Add(_testGenre);
            _context.SaveChanges();

            _manager = new MoviesDBManager(_context);
        }

        [TearDown]
        public void Cleanup()
        {
            _context.Dispose();
        }

        [Test]
        public void Create_ShouldAddMovie()
        {
            var movie = new Movie("Inception", "Christopher Nolan", _testGenre, 2010, 8.8m)
            {
                MovieAdress = "M1"
            };
            _manager.Create(movie);

            var result = _manager.Read("M1");
            Assert.IsNotNull(result);
            Assert.AreEqual("Inception", result.Title);
        }

        [Test]
        public void ReadAll_ShouldReturnAllMovies()
        {
            _manager.Create(new Movie("Interstellar", "Christopher Nolan", _testGenre, 2014, 9.0m) { MovieAdress = "M2" });
            _manager.Create(new Movie("Tenet", "Christopher Nolan", _testGenre, 2020, 7.5m) { MovieAdress = "M3" });

            var movies = _manager.ReadAll().ToList();

            Assert.AreEqual(2, movies.Count);
        }

        [Test]
        public void Update_ShouldModifyMovie()
        {
            var movie = new Movie("The Matrix", "Wachowskis", _testGenre, 1999, 8.7m) { MovieAdress = "M4" };
            _manager.Create(movie);

            movie.Title = "The Matrix Reloaded";
            _manager.Update(movie);

            var updated = _manager.Read("M4");
            Assert.AreEqual("The Matrix Reloaded", updated.Title);
        }

        [Test]
        public void Delete_ShouldRemoveMovie()
        {
            var movie = new Movie("Avatar", "James Cameron", _testGenre, 2009, 7.9m) { MovieAdress = "M5" };
            _manager.Create(movie);

            _manager.Delete("M5");
            var deleted = _manager.Read("M5");

            Assert.IsNull(deleted);
        }
    }
}
