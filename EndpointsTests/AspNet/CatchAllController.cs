using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatchAllController : ControllerBase
    {
        // Tests for catch all parameters
        
        // valid catch all parameter
        [HttpGet("valid/{*test}")]
        public void Action1(string test){}
        
        // not valid - catch all segment is not at the end
        [HttpGet("invalid/{*test}/a")]
        public void Action2(string test){}

        // not valid - catch all is not the only part in the segment
        [HttpGet("invalid/a{*test}a")]
        public void Action3(string test){}

        // not valid - catch all is optional
        [HttpGet("invalid/{*test?}")]
        public void Action4(string test){}
    }
}