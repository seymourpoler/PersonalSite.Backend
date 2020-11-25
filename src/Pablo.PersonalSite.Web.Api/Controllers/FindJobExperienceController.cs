using System;
using Microsoft.AspNetCore.Mvc;
using Pablo.PersonalSite.Domain.JobExperience.Find;

namespace Pablo.PersonalSite.Web.Api.Controllers
{
    public class JobExperienceController : Controller
    {
        private readonly IFindJobExpecienceRepository repository;

        public JobExperienceController(IFindJobExpecienceRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("/api/jobexperiencies")]
        public IActionResult Find()
        {
            return Ok(repository.Find());
        }
    }
}