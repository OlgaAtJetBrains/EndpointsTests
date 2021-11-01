using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class LongNameControllerLongNameControllerLongNameControllerLongNameController : ControllerBase
    {
        // Tests for long controller and route names
        
        [HttpGet("TheRouteIsLongTooTheRouteIsLongTooTheRouteIsLongTooTheRouteIsLongToo")]
        public void Action() {}
    }
}
