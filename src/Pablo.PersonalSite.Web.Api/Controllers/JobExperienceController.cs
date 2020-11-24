using System;
using Microsoft.AspNetCore.Mvc;

namespace Pablo.PersonalSite.Web.Api.Controllers
{
    public class JobExperienceController : Controller
    {
        [HttpGet("/api/jobexperiencies")]
        public IActionResult Find()
        {
            throw new NotImplementedException();
        }
    }
}