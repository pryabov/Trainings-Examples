using System.Web.Mvc;

namespace Razor.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Test1()
		{
			return View();
		}

		public ActionResult Test2()
		{
			return View();
		}

		public ActionResult TestViewData()
		{
			ViewData["TestData"] = "This is ViewData";
			return View();
		}

		public ActionResult TestViewBag()
		{
			ViewBag.TestData = "This is ViewBag";
			return View();
		}

		public ActionResult ViewBagTitle()
		{
			return View();
		}
	}
}
