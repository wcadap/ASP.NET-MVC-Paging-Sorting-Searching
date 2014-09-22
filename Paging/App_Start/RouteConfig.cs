using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Paging
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "sort_Paging_CurrentFilter",
            //    url: "{controller}/{sortOrder}/{page}/{currentFilter}",
            //    defaults: new { controller = "Book", action = "Index", page = UrlParameter.Optional, sortOrder = UrlParameter.Optional, currentFilter = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "PageOnly",
            //    url: "{page}",
            //    defaults: new { controller = "Book", action = "Index", page = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "SortOnly",
            //    url: "{controller}/{sortOrder}",
            //    defaults: new { controller = "Book", action = "Index", sortOrder = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "PageOnly",
            //    url: "{controller}/{page}",
            //    defaults: new { controller = "Book", action = "Index", page = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Paging_and_sort",
            //    url: "{controller}/{page}/{sortOrder}",
            //    defaults: new { controller = "Book", action = "Index", page = UrlParameter.Optional, sortOrder = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Paging_and_sort_CurrentFilter",
            //    url: "{controller}/{page}/{sortOrder}/{currentFilter}",
            //    defaults: new { controller = "Book", action = "Index", page = UrlParameter.Optional, sortOrder = UrlParameter.Optional, currentFilter = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
