using System;
using System.Web.Mvc;
using StudentsLabs.Filters.Helpers;
using StudentsLabs.Filters.Helpers.Filters;

namespace StudentsLabs.Filters.Controllers
{
	//[LogExceptionFilter]
	public class HomeController : Controller
	{
		protected override void OnException(ExceptionContext filterContext)
		{
			Logger.Error("Exception was thrown", filterContext.Exception);
			//base.OnException(filterContext);
		}

		[LogExceptionFilter]
		public ActionResult TestExceptionFilter()
		{
			throw new NotImplementedException();
		}

		[OnlyLocalActionFilter]
		public ActionResult TestActionFilter()
		{
			return Json(new { IsSuccess = true }, JsonRequestBehavior.AllowGet);
		}
	}
}
