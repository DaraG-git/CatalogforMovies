using NUnit.Framework;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace TestingLayer
{
    [TestFixture]
    public class TestViewersManager
    {
        private ViewersDBManager _manager;
        private CatalogforMoviesDBContext _context;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<CatalogforMoviesDBContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) // Unique DB for isolation
                .Options;

            _context = new CatalogforMoviesDBContext(options);
            _manager = new ViewersDBManager(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        [Test]
        public void Create_ShouldAddViewer()
        {
            var viewer = new Viewer("Alice", "alice@example.com", "secret", "123-456-7890", new DateTime(1990, 1, 1));
            _manager.Create(viewer);

            var result = _manager.Read(viewer.ID);
            Assert.IsNotNull(result);
            Assert.AreEqual("Alice", result.Name);
            Assert.AreEqual("alice@example.com", result.Email);
        }

        [Test]
        public void ReadAll_ShouldReturnAllViewers()
        {
            var v1 = new Viewer("Bob", "bob@example.com", "pass1", "111-111-1111", new DateTime(1985, 5, 10));
            var v2 = new Viewer("Charlie", "charlie@example.com", "pass2", "222-222-2222", new DateTime(1980, 12, 20));

            _manager.Create(v1);
            _manager.Create(v2);

            var allViewers = _manager.ReadAll().ToList();
            Assert.AreEqual(2, allViewers.Count);
        }

        [Test]
        public void Update_ShouldModifyViewer()
        {
            var viewer = new Viewer("Dana", "dana@example.com", "initial", "333-333-3333", new DateTime(2000, 3, 15));
            _manager.Create(viewer);

            viewer.Email = "dana_updated@example.com";
            _manager.Update(viewer);

            var updated = _manager.Read(viewer.ID);
            Assert.AreEqual("dana_updated@example.com", updated.Email);
        }

        [Test]
        public void Delete_ShouldRemoveViewer()
        {
            var viewer = new Viewer("Eli", "eli@example.com", "remove", "444-444-4444", new DateTime(1995, 7, 7));
            _manager.Create(viewer);

            _manager.Delete(viewer.ID);

            var deleted = _manager.Read(viewer.ID);
            Assert.IsNull(deleted);
        }
    }
}