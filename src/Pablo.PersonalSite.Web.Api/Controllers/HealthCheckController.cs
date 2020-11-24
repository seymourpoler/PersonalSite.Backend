using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Pablo.PersonalSite.Web.Api.Controllers
{
    public class HealthCheckController : Controller
    {
        private readonly ILogger<HealthCheckController> logger;

        public HealthCheckController(ILogger<HealthCheckController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("/api/healthcheck")]
        public IActionResult GetStatus()
        {
            logger.LogInformation("Status OK...");
            return Ok("Pablo Company PersonalSite's API Rest");
        }
    }
}