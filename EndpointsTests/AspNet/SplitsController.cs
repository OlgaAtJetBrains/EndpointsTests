using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    [Area("Area")]
    public class SplitsController : ControllerBase
    {
        private const string ConstValue = "const";
        private string Value = "not-const";
        
        // Should be displayed as `api/Gaps/{const}`
        [HttpPut("valid/{" + ConstValue + "}")]
        public void Action1() {}
        
        // Should not be displayed in Endpoints tab
        [HttpPut(template: "invalid/{" + test +"}")]
        public void Action2() {}
        
        // Should show `Parameter name expected` highlighting 
        [HttpPut(template: "invalid/{" + null +"}")]
        public void Action3() {}
        
        // Should show `Parameter name expected` highlighting 
        // Should also show that class name is not expected here 
        [HttpPut(template: "invalid/{" + Program +"}")]
        public void Action4() {}
        
        // Type "" inside any token
        // Should not raise RSRP-486121
        [HttpGet("valid/[controller]/[action]/[area]")]
        public void Action5() {}
        
        // Should show highlighting that catch all section is misplaced
        // see RSRP-486137, check after 221
        [HttpGet("invalid{*" + ConstValue +"}")]
        public void Action6() {}
        
        // Should not be displayed in Endpoints due to Value is not static
        [HttpGet("invalid/{" + Value +"}")]
        public void Action7() {}
        
        // Should not be displayed in Endpoints due to Value is not static
        [HttpGet("item/{[area]}")]
        public void Action8() {}
    }
}