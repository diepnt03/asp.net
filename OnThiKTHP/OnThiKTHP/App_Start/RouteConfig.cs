using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnThiKTHP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();//khai báo sử dụng định tuyến thuộc tính

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

                //Đặt phương thức ActionResult Index đã có ở trên là mặc định khi chạy Project.
                defaults: new { controller = "NhanViens", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
