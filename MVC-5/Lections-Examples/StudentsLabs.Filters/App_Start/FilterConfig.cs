using System.Web.Mvc;
using StudentsLabs.Filters.Helpers.Filters;

namespace StudentsLabs.Filters
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			//There can be added your filter
			filters.Add(new HandleErrorAttribute());

			filters.Add(new LogExceptionFilterAttribute());
		}
	}
}