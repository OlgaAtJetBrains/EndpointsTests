using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api")]
    [Area("AreaName")]
    [ApiController]
    public class TokensController : ControllerBase
    {
        // valid - valid tokens
        [HttpGet("[controller]/valid/[action]/[area]")]
        // not valid - not valid tokens
        [HttpGet("[controller1]/invalid/[action1]/[area1]")]
        public void ActionName() { }
    }
}