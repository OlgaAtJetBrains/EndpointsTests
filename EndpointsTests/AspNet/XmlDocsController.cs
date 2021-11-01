using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    [Route("api/[controller]")]
    [ApiController]
    public class XmlDocsController : ControllerBase
    {
        // Tests to display XML comments in Endpoints viewer 

        /// <summary>
        /// Some XML doc here
        /// </summary>
        /// <param name="text"> string param </param>
        /// <param name="id"> int id </param>
        /// <param name="test"> some [from query] param</param>
        public void Action(string text, int id, [FromQuery] int test) { }

        /// <inheritdoc cref="Action(string,int,int)"></inheritdoc>
        public void Action(string test) { }
    }
}
