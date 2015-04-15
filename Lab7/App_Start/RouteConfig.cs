using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab7
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "home",
                url: "",
                defaults: new { controller = "Home", action = "products", }
            );

            routes.MapRoute(
              name: "article",
              url: "product/{article}",
              defaults: new { controller = "Product", action = "Index", name = "AB-123" },
                 constraints: new
                 {
                     name = "[A-Z]{2}-[0-9]{3}"
                 }
              );
            /*print*/
            routes.MapRoute(
                name: "Print",
                url: "product/{article}/Print",
                defaults: new { controller = "Product", action = "Print", name = "AB-123" },
                   constraints: new
                   {
                       name = "[A-Z]{2}-[0-9]{3}"
                   }
                );

            /*category*/
            routes.MapRoute(
              name: "Category",
              url: "products/{Category}/{page}",
              defaults: new { controller = "Product", action = "Category", category = "jewelry", page = "1" },
                 constraints: new
                 {
                     category = "[a-z]+",
                     page = "[0-9]+"
                 }
              );
       

            routes.MapRoute(
              name: "ProductDate",
              url: "products/date/{date}/{page}",
              defaults: new { controller = "Product", action = "Date", date = "2003-02-03", page = "1" },
                 constraints: new
                 {
                     date = new DataConstraint(),
                     page = @"\d+"
                 }
              );



            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
