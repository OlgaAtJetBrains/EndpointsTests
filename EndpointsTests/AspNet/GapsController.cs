using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    [Area("Area")]
    public class GapsController : ControllerBase
    {
        private const string ConstValue = "const";
        private const string TestConstValue = "{";
        
        // Should be displayed as `api/Gaps/{const}`
        [HttpPut("{" + ConstValue + "}")]
        // Should not be displayed in Endpoints tab
        [HttpPut("{" + test + "}")]
        // Type "" inside any token
        // Should not raise RSRP-486121
        [HttpGet("[controller]/[action]/[area]")]
        
        public void Action1() {}

    }
}