using System.Linq;
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
        [Ignore("Интеграционный")]
        public void AddSubtypeAppealTest()
        {
            var subtype = new SubtypeAppeal()
            {
                Name = "TestSubtype",
                Note = "Subtype create only test"
            };
            using (var repos = new SubtypeAppealRepository())
            {
                repos.Add(subtype);
                repos.Delete(subtype);
            }

            Assert.Pass();
        }

        [Test]
        [Ignore("Интеграционный")]
        public void AddTypeAppealTest()
        {
            var type = new TypeAppeal()
            {
                Name = "TestType",
                Note = "Type create only test"
            };
            using (var repos = new TypeAppealRepository())
            {
                repos.Add(type);
                repos.Delete(type);
            }

            Assert.Pass();
        }

        [Test]
        [Explicit("Интеграционный")]
        public void GetAllAppealTest()
        {
            var appeal = new Appeal()
            {
                Email = "test@test.com"
            };

            var appeal1 = new Appeal()
            {
                Email = "test1@test.com"
            };

            using (var repos = new AppealRepository())
            {
                repos.Add(appeal);
                repos.Add(appeal1);

                var appeals = repos.GetEntities();

                Assert.IsTrue(appeals.ToList().Count() > 0);

                repos.Delete(appeal);
                repos.Delete(appeal1);
            }
        }

        [Test]
        [Ignore("Интеграционный")]
        public void AddAppealTest()
        {
            var appeal = new Appeal()
            {
                Email = "test@test.com"
            };

            using (var repos1 = new AppealRepository())
            {
                repos1.Add(appeal);
                repos1.Delete(appeal);
            }

            Assert.Pass();
        }
        
        [Test]
        [Ignore("Интеграционный")]
        public void GetAppealByIdTest()
        {
            var appeal = new Appeal()
            {
                Email = "test@test.com",
                Text = "Этот текст для теста"
            };

            using (var repos1 = new AppealRepository())
            {
                repos1.Add(appeal);
                var keyAppeal = repos1.GetIdByEmailAndText(appeal.Email, appeal.Text);
                var appealFromDb = repos1.Get(keyAppeal);
                Assert.AreEqual(appeal.Email, appealFromDb.Email);
                repos1.Delete(appeal);
            }
        }
    }
}