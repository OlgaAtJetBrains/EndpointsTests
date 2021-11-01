using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlashController : ControllerBase
    {
        // Tests for displaying overrided routes in viewer correctly
        // If the route starts with "/" or "~/" then the route
        // should be displayed without Controller's route in endpoints viewer
     
        private const string Slash = "/";
        private const string TildaSlash = "~/";
        
        // should be /valid
        [HttpPut("/valid")]
        public void Action1() {}
        
        // should be /valid
        [HttpPut("~/valid")]
        public void Action2() {}
        
        // should be /valid
        // due to the slash in first string value
        [HttpGet(Slash + "valid")]
        public void Action3() {}
        
        // should be /valid
        // due to the tilda + slash in first string value
        [HttpGet(TildaSlash + "valid")]
        public void Action4() {}
        
        // should be /api/Slash/valid
        [HttpGet("valid")]
        public void Action5() {}
    }
}