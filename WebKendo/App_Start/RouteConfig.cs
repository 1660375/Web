using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebKendo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "KendoUI", id = UrlParameter.Optional }
            );
            routes.MapRoute("Kendo_editor",
                "Kendo_editor",
                new { Controller = "Home", Action = "Kendo_editor" });
        }
    }
}
