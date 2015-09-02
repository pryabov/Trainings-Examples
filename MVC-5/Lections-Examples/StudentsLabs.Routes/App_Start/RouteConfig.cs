using System.Web.Mvc;
using System.Web.Routing;

namespace StudentsLabs.Routes
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "AddressRouteGetCity",
				url: "GetCity",
				defaults: new { controller = "Address", action = "GetCity" }
			);

			routes.MapRoute(
				name: "PersonRoute",
				url: "user/{action}",
				defaults: new { controller = "Person" }
			);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}