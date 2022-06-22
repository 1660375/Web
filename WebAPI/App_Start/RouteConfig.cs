﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAPI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Load",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Load_Test", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "BOMON",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "BOMONs", action = "GetBOMONs", id = UrlParameter.Optional }
            );
        }
    }
}