using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemoFirst
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",  //路由名称
                url: "{controller}/{action}/{id}",  //带有参数的URL
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } //路由参数的默认值
            );
        }
    }
}
