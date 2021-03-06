﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Angular2Mvc5Application1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "heroApi",
                url: "api/{controller}/{action}/{id}",
                defaults: new { controller = "Hero", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Default",
            url: "{*url}",
            defaults: new { controller = "Home", action = "Index" }
        );

        }
    }
}
