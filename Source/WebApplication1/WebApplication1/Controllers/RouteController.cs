using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/routes")]
    public class RouteController : Controller
    {
        [HttpGet("{value}")]
        [Produces("application/json")]
        public ActionResult Get(string value)
        {
            var result = new
            {
                ReceivedValue = value,
                DecodedValue = HttpUtility.UrlDecode(value)
            };

            return Ok(result);
        }
    }
}
