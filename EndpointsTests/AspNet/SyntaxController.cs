using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class SyntaxController : ControllerBase
    {
        // valid
        [HttpGet("valid{test}")]
        // valid - template can contain special symbols
        [HttpGet("!@#$%^&*()_+-=`~;:'|/")]
        //not valid - ?
        [HttpGet("invalid?")]
        // not valid - no closing square bracket
        [HttpGet("invalid[")]
        // not valid - no closing square bracket
        [HttpGet("invalid[test")]
        // valid, but aa is not resolved
        [HttpGet("invalid[test]")]
        // not valid - not escaped closing square bracket
        [HttpGet("invalid]")]
        // not valid - no closing brace
        [HttpGet("invalid{")]
        // not valid - no closing brace
        [HttpGet("invalid{test")]
        // not valid - not escaped closing brace
        [HttpGet("invalid}")]
        // not valid - consecutive slashes
        [HttpGet("invalid//")]

        // valid - param name can contain special symbols
        [HttpGet("valid{test!@#$%^&()_+-=`~'<>}")]
        // not valid - param name cannot contain ?
        [HttpGet("invalid{tes?t}")] 
        // not valid - param name cannot contain *
        [HttpGet("invalid{tes*t}")] 
        // not valid - param name cannot contain {
        [HttpGet("invalid{tes{t}")] 
        // not valid - param name cannot contain [
        [HttpGet("invalid{tes[t}")] 
        // not valid - param name cannot contain /
        [HttpGet("invalid{tes/t}")] 

        // valid - optional params can be preceded only by single . in the segment
        [HttpGet("valid/.{test?}")] 
        // not valid - optional params can be preceded only by single . in the segment
        [HttpGet("invalid.{test?}")]

        // not valid - param declared more than once
        [HttpGet("aa/{test}{test}/q")]
        
        // not valid - more than one parameter in one section
        [HttpGet("aa/{test}{test2}/q")]
        public void Action(string test){}
    }
}
