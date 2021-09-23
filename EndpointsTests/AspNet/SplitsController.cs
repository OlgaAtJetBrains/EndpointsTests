using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    [Area("Area")]
    public class SplitsController : ControllerBase
    {
        private const string ConstValue = "const";
        private const string item1 = "item";
        private const string item2 = "/";
        
        // Should be displayed as `api/Gaps/{const}`
        [HttpPut("valid/{" + ConstValue + "}")]
        // Should not be displayed in Endpoints tab
        [HttpPut(template: "invalid/{" + test +"}")]
        // Should show `Parameter name expected` highlighting 
        [HttpPut(template: "invalid/{" + null +"}")]
        // Should show `Parameter name expected` highlighting 
        // Should also show that class name is not expected here 
        [HttpPut(template: "invalid/{" + Program +"}")]
        // Type "" inside any token
        // Should not raise RSRP-486121
        [HttpGet("[controller]/[action]/[area]")]
        // Should show highlighting that catch all section is misplaced
        // see RSRP-486137, check after 221
        [HttpGet("test{*" + ConstValue +"}")]
        
        
        public void Action1() {}
        

    }
}