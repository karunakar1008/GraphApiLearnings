using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace WebApiWebAssembly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]

    public class ReportController : ControllerBase
    {
        //https://localhost:7035/api/Report/GetReport
        [Route("GetReport")]
        [Authorize(Roles ="Manager")]
        public IActionResult GetReport()
        {
            return Ok("Get report called");
        }

        //https://localhost:7035/api/Report/GetReportStatus
        [Route("GetReportStatus")]
        [Authorize]
        public IActionResult GetReportStatus()
        {
            return Ok("Get report Status called");
        }
    }
}
