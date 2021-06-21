using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatchAllController : ControllerBase
    {
        // valid catch all parameter
        [HttpGet("valid/{*test}")]
        // not valid - catch all segment is not at the end
        [HttpGet("invalid/{*test}/a")]
        // not valid - catch all is not the only part in the segment
        [HttpGet("invalid/a{*test}a")]
        // not valid - catch all is optional
        [HttpGet("invalid/{*test?}")]
        public void Action(string test){}
    }
}