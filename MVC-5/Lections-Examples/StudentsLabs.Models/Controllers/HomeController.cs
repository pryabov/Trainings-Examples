using System.Web.Mvc;
using WorkWithModels.Models.Home;

namespace WorkWithModels.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult DynamicView()
		{
			HomeModel model = new HomeModel
				{
					Field1 = "Field 1",
					Field2 = "Field 2",
					Field3 = "Field 3"
				};

			return View(model);
		}

		public ActionResult StrongTypeView()
		{
			HomeModel model = new HomeModel
				{
					Field1 = "Field 1",
					Field2 = "Field 2",
					Field3 = "Field 3"
				};

			return View(model);
		}
	}
}
