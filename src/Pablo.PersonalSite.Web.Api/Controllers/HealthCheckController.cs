using Microsoft.AspNetCore.Mvc;

namespace Pablo.PersonalSite.Web.Api.Controllers
{
    public class HealthCheckController : Controller
    {
        [HttpGet("/api/healthcheck")]
        public IActionResult GetStatus()
        {
            return Ok();
        }
    }
}