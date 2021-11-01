using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultValueController : ControllerBase
    {
        // Tests for default values in route's templates
        
        // valid - default value
        [HttpGet("valid/{x=test}")]
        public void Action1(string x){ }

        // not valid - optional params cannot have default value
        [HttpGet("invalid/{x=test?}")]
        public void Action2(string x) { }
    }
}