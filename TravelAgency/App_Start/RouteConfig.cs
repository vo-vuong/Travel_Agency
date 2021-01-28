using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TravelAgency
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // BotDetect requests must not be routed
            routes.IgnoreRoute("{*botdetect}",
              new { botdetect = @"(.*)BotDetectCaptcha\.ashx" });

            routes.MapRoute(
                name: "Cart",
                url: "gio-hang",
                defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TravelAgency.Controllers" }
             );

            routes.MapRoute(
                name: "Add Cart",
                url: "them-gio-hang",
                defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
                 namespaces: new[] { "TravelAgency.Controllers" }
             );

            routes.MapRoute(
                name: "Search",
                url: "tim-kiem",
                defaults: new { controller = "Tour", action = "Search", id = UrlParameter.Optional },
                namespaces: new[] { "TravelAgency.Controllers" }
            );

            routes.MapRoute(
                name: "Tour Detail",
                url: "chi-tiet-tour/{id}",
                defaults: new { controller = "Tour", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TravelAgency.Controllers" }
             );

            routes.MapRoute(
                name: "Tour Sale",
                url: "tour-khuyen-mai",
                defaults: new { controller = "Tour", action = "Sale", id = UrlParameter.Optional },
                 namespaces: new[] { "TravelAgency.Controllers" }
             );

            routes.MapRoute(
                name: "Tour Domestic",
                url: "tour-trong-nuoc",
                defaults: new { controller = "Tour", action = "Domestic", id = UrlParameter.Optional },
                 namespaces: new[] { "TravelAgency.Controllers" }
             );

            routes.MapRoute(
                name: "Tour Abroad",
                url: "tour-ngoai-nuoc",
                defaults: new { controller = "Tour", action = "Abroad", id = UrlParameter.Optional },
                 namespaces: new[] { "TravelAgency.Controllers" }
             );

            routes.MapRoute(
                name: "Content Detail",
                url: "tin-tuc/chi-tiet/{id}",
                defaults: new { controller = "Content", action = "Detail", id = UrlParameter.Optional },
                 namespaces: new[] { "TravelAgency.Controllers" }
             );

            routes.MapRoute(
                name: "Content",
                url: "tin-tuc",
                defaults: new { controller = "Content", action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "TravelAgency.Controllers" }
             );

            routes.MapRoute(
                name: "Home",
                url: "trang-chu",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "TravelAgency.Controllers" }
             );

            routes.MapRoute(
                name: "Signup",
                url: "dang-ki",
                defaults: new { controller = "Signup", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TravelAgency.Controllers" }
            );

            routes.MapRoute(
                name: "Login",
                url: "dang-nhap",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TravelAgency.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TravelAgency.Controllers" }
            );
        }
    }
}
