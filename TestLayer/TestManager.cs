using DataLayer;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;

namespace TestingLayer
{
    [SetUpFixture]
    public class TestManager
    {
        internal static CatalogforMoviesDBContext dbContext;

        
        [OneTimeSetUp]
        public void Init()
        {
            var options = new DbContextOptionsBuilder<CatalogforMoviesDBContext>().UseInMemoryDatabase("TestDb").Options;

            dbContext = new CatalogforMoviesDBContext(options);
        }

        [OneTimeTearDown]
        public void Dispose()
        {
            dbContext?.Dispose();
        }
    }
}