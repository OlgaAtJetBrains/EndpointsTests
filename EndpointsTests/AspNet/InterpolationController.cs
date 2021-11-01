using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class InterpolationController : ControllerBase
    {
        private const string SomeVar = "test";

        // Tests for 
        
        // Should not raise any issues when route contains string interpolation

        // The route in endpoints should contain interpolated part

        [HttpGet( $"{SomeVar}" + "{someVar2}")]
        public void Action(string someVar2) {}
    }
}