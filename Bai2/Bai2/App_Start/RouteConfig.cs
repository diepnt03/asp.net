using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bai2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "test",
                url: "{haui}/{testpara}/{msg}/{number}",
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                defaults: new { controller = "RouteConfigDemo", action = "test" ,msg ="null",number = 2}
            );
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
               defaults: new { controller = "Hello", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Hello",
               url: "{controller}/{action}/{ten}/{id}",
               //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
               defaults: new { controller = "Hello", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
