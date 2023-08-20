using System.Web.Mvc;
using System.Web.Routing;

namespace LogicEstate
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Edit",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Edit", id = UrlParameter.Optional },
            constraints: new { httpMethod = new HttpMethodConstraint("PUT") }
        );

            routes.MapRoute(
                name: "Delete",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Delete", id = UrlParameter.Optional },
                constraints: new { httpMethod = new HttpMethodConstraint("DELETE") }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
