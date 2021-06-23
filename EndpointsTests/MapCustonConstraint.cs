using System;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace EndpointsTests
{
    public class MapCustomConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (!values.TryGetValue(routeKey, out var routeValue)) return false;

            var parameterValueString = Convert.ToString(routeValue, CultureInfo.InvariantCulture);
            return IsEmailAddressValid(parameterValueString);
        }
        private bool IsEmailAddressValid(string emailAddress)
        {
            return true;
        }
    }
}