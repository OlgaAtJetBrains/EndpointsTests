using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerbsController : ControllerBase
    {
        // Should be GET and POST in Endpoints
        [HttpGet, HttpPost]
        public void Action1() { }
        
        // Should be GET and POST in Endpoints
        [HttpGet(""), HttpPost("")]
        public void Action2() { }
        
        // Should be GET and TEST in Endpoints
        // TEST verb should be validated and highlighted as an error
        // see RSRP-484902, check once fixed
        [AcceptVerbs("GET", "TEST")]
        public void Action3() { }
    }
}