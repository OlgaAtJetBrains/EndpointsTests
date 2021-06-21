#nullable enable
using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    //Endpoints viewer would not show question mark inside the routes 
    [Route("api/[controller]")]
    [ApiController]
    public class OptionalValueController : ControllerBase
    {
        //valid optional
        [HttpGet("valid/{test?}")]
        public void Action(string? test) { }
        //valid optional
        [HttpGet("valid/{test?}")]
        public void Action2(string test) { }
        
        //valid optional int
        [HttpGet("valid/{test:int?}")]
        public void Action22(int? test) { }
        //valid optional int
        [HttpGet("valid/{test:int?}")]
        public void Action222(int test) { }
        
        //not valid syntax
        [HttpGet("invalid/{?test}")]
        public void Action3(string test) { }
    }
}