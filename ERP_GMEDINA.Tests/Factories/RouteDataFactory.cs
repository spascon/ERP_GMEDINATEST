using System.Web.Routing;
using System;
using Microsoft.Pex.Framework;

namespace System.Web.Routing
{
    /// <summary>A factory for System.Web.Routing.RouteData instances</summary>
    public static partial class RouteDataFactory
    {
        /// <summary>A factory for System.Web.Routing.RouteData instances</summary>
        [PexFactoryMethod(typeof(RouteData))]
        public static RouteData Create(RouteBase route_routeBase, IRouteHandler routeHandler_iRouteHandler)
        {
            RouteData routeData = new RouteData(route_routeBase, routeHandler_iRouteHandler)
              ;
            return routeData;

            // TODO: Edit factory method of RouteData
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
