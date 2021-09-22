using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtractCommonController : ControllerBase
    {
        // Should extract only `valid` part of the route, RSRP-485398
        [HttpGet, Route("valid/route1.csv")]
        [HttpGet, Route("valid/route2.txt")]
        [HttpGet, Route("valid/route2.json")]
        [HttpGet, Route("valid/valid/route2.json")]
        public void Action(string test) { }
    }
}