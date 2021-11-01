using System;
using Microsoft.AspNetCore.Mvc;

namespace EndpointsTests.AspNet
{
    public class MyAttribute : Attribute
    {
        public MyAttribute(string[] template) {}
    }
    
    [Route("api/[controller]")]
    public class AttributesArrayController : Controller
    {
        [My(new []{"123", "123", nameof(AttributesArrayController)})]
        public void Action1() {}
    }
}