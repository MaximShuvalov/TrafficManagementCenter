using Microsoft.AspNetCore.Http;
using Model;
using NUnit.Framework;
using TrafficManagementCenter.Server.Controllers;
using TrafficManagementCenter.Server.Db.Context;

namespace TrafficManagementCenter.Server.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Explicit("Integration")]
        public void AddCitizensAppealsTest()
        {
            var controller = new CitizensAppealsController(new AppDbContext());
        }

        [Test]
        [Explicit("Integration")]
        public void CitizensAppealsControllerPingTets()
        {
            var controller = new CitizensAppealsController(new AppDbContext());

            var result = controller.Ping();

            Assert.AreEqual(StatusCodes.Status200OK, result);
        }
        
        [Test]
        [Explicit("Integration")]
        public void CitizensAppealsControllerAddAppealTets()
        {
            var controller = new CitizensAppealsController(new AppDbContext());

            var appeal = new Appeal();

            //var result = controller.AddAppeal(appeal);
            //
            //Assert.AreEqual(StatusCodes.Status200OK, result);
        }
    }
}