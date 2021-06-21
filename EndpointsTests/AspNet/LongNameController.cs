using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class LongNameControllerLongNameControllerLongNameControllerLongNameController : ControllerBase
    {
        [HttpGet("TheRouteIsLongTooTheRouteIsLongTooTheRouteIsLongTooTheRouteIsLongToo")]
        public void Action() { }
    }
}
