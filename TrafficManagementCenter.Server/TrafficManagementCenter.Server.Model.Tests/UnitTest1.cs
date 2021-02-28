using Model;
using NUnit.Framework;

namespace TrafficManagementCenter.Server.Model.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateTypeAppealTest()
        {
            var typeAppeal = new TypeAppeal();
            typeAppeal.Key = 001;
            typeAppeal.Name = "Gibdd";
            typeAppeal.Note = "Проблемы, которые адресованы ГИБДД";
            Assert.Pass();
        }

        [Test]
        public void CreateSubtypeAppealTest()
        {
            var subtypeAppeal = new SubtypeAppeal();
            subtypeAppeal.Key = 0001;
            subtypeAppeal.Name = "Дорожные знаки";
            subtypeAppeal.Name = "Вопросы о нецелесообразности установленных знаков";
            subtypeAppeal.Type = new TypeAppeal();
            Assert.Pass();
        }
    }
}