using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public void Action() { }
        
        //TODO
        // custom constraint controller
        // open api
    }
}
