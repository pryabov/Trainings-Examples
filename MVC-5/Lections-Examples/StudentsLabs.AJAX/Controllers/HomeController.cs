using System;
using System.Web.Mvc;
using StudentsLabs.AJAX.Models.Home;

namespace StudentsLabs.AJAX.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult BeforeActionLink()
		{
			return View();
		}

		public ActionResult GetSecondPartial(bool isFirstPartial)
		{
			if (Request.IsAjaxRequest())
			{
				if (isFirstPartial)
				{
					return PartialView("Controls/SecondPartial");
				}

				return PartialView("Controls/FirstPartial");
			}

			throw new NotSupportedException();
		}

		public ActionResult WithActionLink()
		{
			return View();
		}

		public ActionResult WithAjaxForm()
		{
			return View();
		}

		public ActionResult AjaxFormPost(UserViewModel postedModel)
		{
			return PartialView("Controls/SuccessPartial");
		}
	}
}
