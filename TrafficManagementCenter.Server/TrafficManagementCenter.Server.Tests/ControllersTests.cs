using Microsoft.AspNetCore.Http;
using Model;
using NUnit.Framework;
using TrafficManagementCenter.Server.Controllers;

namespace TrafficManagementCenter.Server.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddCitizensAppealsTest()
        {
            var controller = new CitizensAppealsController();
        }

        [Test]
        public void CitizensAppealsControllerPingTets()
        {
            var controller = new CitizensAppealsController();

            var result = controller.Ping();

            Assert.AreEqual(StatusCodes.Status200OK, result);
        }
        
        [Test]
        public void CitizensAppealsControllerAddAppealTets()
        {
            var controller = new CitizensAppealsController();

            var appeal = new Appeal();

            var result = controller.AddAppeal(appeal);

            Assert.AreEqual(StatusCodes.Status200OK, result);
        }
    }
}