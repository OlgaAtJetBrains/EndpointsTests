using Microsoft.AspNetCore.Mvc;

namespace OtherEndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnotherMapCustomConstraintController  : ControllerBase
    {
        [HttpGet("/{test:MapCustomConstraint}")]
        [HttpGet("/{test:AnotherMapCustomConstraint}")]
        public void ActionMethod(AnotherMapCustomConstraint test) { }
    }
}