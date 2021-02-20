using Microsoft.AspNetCore.Http;
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
    }
}