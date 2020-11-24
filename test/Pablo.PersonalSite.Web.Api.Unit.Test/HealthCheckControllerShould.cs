using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using Pablo.PersonalSite.Web.Api.Controllers;
using Shouldly;

namespace Pablo.PersonalSite.Web.Api.Unit.Test
{
    [TestFixture]
    public class HealthCheckControllerShould
    {
        [Test]
        public void return_ok()
        {
            Mock<ILogger<HealthCheckController>> logger = new Mock<ILogger<HealthCheckController>>();
            var controller = new HealthCheckController(logger.Object);

            var response = controller.GetStatus() as OkObjectResult;

            response.StatusCode.ShouldBe((int)HttpStatusCode.OK);
        }
    }
}