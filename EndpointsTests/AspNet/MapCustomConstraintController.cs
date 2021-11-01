using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapCustomConstraintController  : ControllerBase
    {
        // Tests for Constraints are being added through Map.Add() feature see RSRP-484029
        
        [HttpGet("valid/{test:MapCustomConstraint}")]
        public void ActionMethod(MapCustomConstraint test) {}
        
        [HttpGet("invalid/{test:MapCustomConstraint2}")]
        public void ActionMethod2(MapCustomConstraint test) {}
    }
}