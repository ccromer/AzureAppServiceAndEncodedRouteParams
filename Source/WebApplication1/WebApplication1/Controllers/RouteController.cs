using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace WebApplication1.Controllers
{
    [Route("api/routes")]
    public class RouteController : Controller
    {
        [HttpGet("{value}")]
        [Produces("application/json")]
        public ActionResult Get(string value)
        {
            Request.Headers.TryGetValue("X-Waws-Unencoded-Url", out var wawsHeader);

            var result = new
            {
                ReceivedValue = value,
                DecodedValue = HttpUtility.UrlDecode(value),
                XWawsUnencodedUrl = wawsHeader,
                AllHeaders = Request.Headers
            };

            return Ok(result);
        }
    }
}
