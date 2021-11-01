using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtractCommonController : ControllerBase
    {
        // Tests for Extract common routes part feature
        
        // To test the feature, extract common for all routes `extract-me` part using quick fix
        // Then only this part should be extracted and nothing more, RSRP-485398
        
        [HttpGet, Route("extract-me/route1.csv")]
        public void Action1(string test){}

        [HttpGet, Route("extract-me/route2.txt")]
        public void Action2(string test){}

        [HttpGet, Route("extract-me/route2.json")]
        public void Action3(string test){}

        [HttpGet, Route("extract-me/valid/route2.json")]
        public void Action4(string test) { }
    }
}