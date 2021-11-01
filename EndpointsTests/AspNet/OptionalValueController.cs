#nullable enable
using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionalValueController : ControllerBase
    {
        // Tests for optional value in route template
        // Note, endpoints viewer would not show question mark inside the routes 
        
        //valid optional
        [HttpGet("valid/{test?}")]
        public void Action(string? test) { }
        //valid optional
        [HttpGet("valid/{test?}")]
        public void Action2(string test) { }
        
        //valid optional int
        [HttpGet("valid/{test:int?}")]
        public void Action3(int? test) { }
        //valid optional int
        [HttpGet("valid/{test:int?}")]
        public void Action4(int test) { }
        
        //not valid syntax
        [HttpGet("invalid/{?test}")]
        public void Action5(string test) { }
    }
}