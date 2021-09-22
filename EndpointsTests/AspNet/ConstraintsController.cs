using System;
using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstraintsController : ControllerBase
    {
        [HttpGet("valid/{test:alpha}")]
        public void Action(string test) { }

        [HttpGet("valid/{test:bool}")]
        public void Action2(bool test) { }

        [HttpGet("valid/{test:datetime}")]
        public void Action3(DateTime test) { }
        
        [HttpGet("valid/{test:decimal}")]
        public void Action4(decimal test) { }

        [HttpGet("valid/{test:double}")]
        public void Action5(double test) { }

        [HttpGet("valid/{test:float}")]
        public void Action6(float test) { }
        
        [HttpGet("valid/{test:guid}")]
        public void Action7(Guid test) { }

        [HttpGet("valid/{test:int}")]
        public void Action8(int test) { }

        [HttpGet("valid/{test:length(5):int}")]
        public void Action9(int test) { }

        [HttpGet("valid/{test:long}")]
        public void Action10(long test) { }
        
        [HttpGet("valid/{test:max(10)}")]
        public void Action11(int test) { }

        [HttpGet("valid/{test:maxlength(10)}")]
        public void Action12(string test) { }

        [HttpGet("valid/{test:min(10)}")]
        public void Action13(long test) { }

        [HttpGet("valid/{test:minlength(10)}")]
        public void Action14(string test) { }

        [HttpGet("valid/{test:range(10, 11)}")]
        public void Action15(long test) { }

        [HttpGet("valid/{test:regex()}")]
        public void Action17(string test) { }

        [HttpGet("{test:required}/valid")]        
        public void Action18(string test) { }


        [HttpGet("invalid/{test:}")]
        public void Action19(string test) { }

        [HttpGet("invalid/{test:qwe}")]
        public void Action20(string test) { }
    }
}
