using MyTested.AspNetCore.Mvc;
using NUnit.Framework;
using Pablo.PersonalSite.Web.Api.Controllers;

namespace Pablo.PersonalSite.Web.Api.Unit.Test
{
    [TestFixture]
    public class RoutesShould
    {
        [Test]
        public void map_to_health_check()
        {
            MyMvc
                .Routing()
                .ShouldMap(request => request
                    .WithMethod(HttpMethod.Get)
                    .WithLocation("/api/healthcheck"))
                .To<HealthCheckController>(x =>
                    x.GetStatus());
        }
    }
}