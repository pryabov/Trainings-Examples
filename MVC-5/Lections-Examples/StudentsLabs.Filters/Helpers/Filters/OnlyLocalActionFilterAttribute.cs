using System.Diagnostics;
using System.Web.Mvc;

namespace StudentsLabs.Filters.Helpers.Filters
{
	public class OnlyLocalActionFilterAttribute : FilterAttribute, IActionFilter
	{
		private Stopwatch _timer;

		public void OnActionExecuting(ActionExecutingContext filterContext)
		{
			if (!filterContext.HttpContext.Request.IsLocal)
			{
				filterContext.Result = new HttpNotFoundResult();
			}
			_timer = Stopwatch.StartNew();
		}

		public void OnActionExecuted(ActionExecutedContext filterContext)
		{
			_timer.Stop();
			Logger.Info(string.Format("Action Executed for {0} milliseconds", _timer.ElapsedMilliseconds));
		}
	}
}