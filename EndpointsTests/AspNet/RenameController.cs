using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenameController : ControllerBase
    {
        // Rename int constraint in route
        // Should not raise exceptions RSRP-485704
        [HttpGet("valid/{test:int}")]
        public void Action222(int test) { }
    }
}