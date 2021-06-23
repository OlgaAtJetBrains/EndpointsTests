using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapCustomConstraintController  : ControllerBase
    {
        [HttpGet("valid/{test:MapCustomConstraint}")]
        public void ActionMethod(MapCustomConstraint test) { }
        
        [HttpGet("invalid/{test:MapCustomConstraint2}")]
        public void ActionMethod2(MapCustomConstraint test) { }
    }
}