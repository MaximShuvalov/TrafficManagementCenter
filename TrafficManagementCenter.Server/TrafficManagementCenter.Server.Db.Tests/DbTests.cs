using Model;
using NUnit.Framework;
using TrafficManagementCenter.Server.Db.Repositories;

namespace TrafficManagementCenter.Server.Db.Tests
{
    public class DbTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Ignore("Интеграционный")]
        public void AddSubtypeAppealTest()
        {
            var repos = new SubtypeAppealRepository();
            var subtype = new SubtypeAppeal()
            {
                Name = "TestSubtype",
                Note = "Subtype create only test"
            };
            repos.Add(subtype);
            
            Assert.Pass();
        }
        
        [Test]
        [Ignore("Интеграционный")]
        public void AddTypeAppealTest()
        {
            var repos = new TypeAppealRepository();
            var type = new TypeAppeal()
            {
                Name = "TestType",
                Note = "Type create only test"
            };
            repos.Add(type);
            
            Assert.Pass();
        }
    }
}