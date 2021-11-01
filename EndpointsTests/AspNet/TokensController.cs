using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api")]
    [Area("AreaName")]
    [ApiController]
    public class TokensController : ControllerBase
    {
        public const string action = "[action]"; 
        
        // valid - valid tokens
        [HttpGet("[controller]/valid/[action]/[area]")]
        public void Action1() { }

        // not valid - not valid tokens
        [HttpGet("[controller1]/invalid/[action1]/[area1]")]
        public void Action2() { }
        
        // Should be .../valid/{Action3}
        [HttpGet("valid/{[action]}")]
        public void Action3() { }
        
        // Should be .../valid/{Action4}
        [HttpGet("valid/{" + action+ "}")]
        public void Action4() { }
    }
}