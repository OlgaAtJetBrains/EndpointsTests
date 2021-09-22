using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlashController : ControllerBase
    {
        // If the route starts with "/" or "~/" then the route
        // should be displayed without Controller's route in endpoints viewer
        
        // should be /valid
        [HttpPut("/valid")]
        // should be /valid
        [HttpPut("~/valid")]
        // should be /api/Slash/valid
        [HttpPut("valid")]
        public void Action1() {}
    }
}