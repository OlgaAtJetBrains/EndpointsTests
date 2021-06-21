using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerbsController : ControllerBase
    {
        [HttpGet, HttpPost]
        [HttpGet(""), HttpPost("")]
        [AcceptVerbs("GET", "TEST")]
        public void Action() { }
    }
}