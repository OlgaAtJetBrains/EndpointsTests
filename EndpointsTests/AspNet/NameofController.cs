using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameofController : ControllerBase
    {
        // Tests for Routes should understand nameof in route's template feature, see RIDER-66492
        
        private const string Value = "";
        
        // should be /Value
        [HttpGet("valid" + nameof(Value))]
        public void Action1() {}
        
        // Should be  ...valid/{Value}
        // there should be no warnings
        [HttpGet("valid/{" + nameof(Value) +"}")]
        public void Action2() {}
    }
}