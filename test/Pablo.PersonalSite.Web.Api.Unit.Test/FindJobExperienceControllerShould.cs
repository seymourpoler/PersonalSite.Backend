using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using Pablo.PersonalSite.Domain.JobExperience.Find;
using Pablo.PersonalSite.Domain.JobExperience.Find.Models;
using Pablo.PersonalSite.Web.Api.Controllers;
using Shouldly;

namespace Pablo.PersonalSite.Web.Api.Unit.Test
{
    [TestFixture]
    public class FindJobExperienceControllerShould
    {
        [Test]
        public void return_all_job_experiencies()
        {
            var jobExperiences = new[] {new JobExperience()};
            var repository = new Mock<FindJobExpecienceRepository>();
            repository
                .Setup(x => x.Find())
                .Returns(jobExperiences);
            var controller = new JobExperienceController(repository.Object);

            var response = controller.Find() as OkObjectResult;

            response.StatusCode.ShouldBe((int) HttpStatusCode.OK);
            response.Value.ShouldBeOfType<IReadOnlyList<JobExperience>>();
        }
    }
}