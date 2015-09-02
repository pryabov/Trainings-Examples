using System.Web.Mvc;

namespace StudentsLabs.Filters.Helpers.Filters
{
	public class LogExceptionFilterAttribute : HandleErrorAttribute
	{
		public override void OnException(ExceptionContext filterContext)
		{
			Logger.Error("Was Exception", filterContext.Exception);
		}
	}
}