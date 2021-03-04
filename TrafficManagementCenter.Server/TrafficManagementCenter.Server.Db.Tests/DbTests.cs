using Model;
using NUnit.Framework;
using TrafficManagementCenter.Server.Db.Extensions;
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
        [Explicit("Интеграционный")]
        public void AddSubtypeAppealTest()
        {
            var repos = new SubtypeAppealRepository();
            var subtype = new SubtypeAppeal()
            {
                Name = "TestSubtype",
                Note = "Subtype create only test"
            };
            repos.Add(subtype);
            
            repos.Delete(subtype);
            
            Assert.Pass();
        }
        
        [Test]
        [Explicit("Интеграционный")]
        public void AddTypeAppealTest()
        {
            var repos = new TypeAppealRepository();
            var type = new TypeAppeal()
            {
                Name = "TestType",
                Note = "Type create only test"
            };
            repos.Add(type);
            
            repos.Delete(type);
            
            Assert.Pass();
        }
        
        [Test]
        [Explicit("Интеграционный")]
        public void AddAppealTest()
        {
            var repos = new AppealRepository();
            var appeal = new Appeal()
            {
                Email = "test@test.com"
            };
            repos.Add(appeal);
            
            repos.Delete(appeal);
            
            Assert.Pass();
        }
        
        [Test]
        [Explicit("Интеграционный")]
        public void GetAppealTest()
        {
            var repos = new AppealRepository();
            var appeal = new Appeal()
            {
                Email = "test@test.com"
            };
            repos.Add(appeal);
            var key =  appeal.GetAppealKey();
            
            var appealFromDb = repos.Get(key);
            
            repos.Delete(appeal);
            
            Assert.Equals(appeal, appealFromDb);
        }
    }
}