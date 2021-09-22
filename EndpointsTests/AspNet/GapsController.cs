using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class GapsController : ControllerBase
    {
        private const string ConstValue = "const";
        private const string TestConstValue = "{";
        
        // Should be displayed as `api/Gaps/{const}`
        [HttpPut("{" + ConstValue + "}")]
        // Should not be displayed in Endpoints tab
        [HttpPut("{" + test + "}")]
        
        
        [HttpPut("/{" + TestConstValue + "}")]
        public void Action222() { }

    }
}